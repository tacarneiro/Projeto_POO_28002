using static Excecoes.Excecoes;
using System.Globalization;
using System.Text.Json;
using Objects;

namespace Dados
{
    public class Users : User
    {
        #region Attributes
        private static List<Users> users = new List<Users>();
        private const string filePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Users.txt";
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Users"/> class.
        /// </summary>
        /// <param name="id">The unique identifier of the user.</param>
        /// <param name="name">The name of the user.</param>
        /// <param name="email">The email of the user.</param>
        /// <param name="dataNascimento">The birth date of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="role">The role of the user.</param>
        public Users(Guid id, string name, string email, DateTime dataNascimento, string password, string role)
            : base(id, name, email, dataNascimento, password, role)
        {
            ValidateFields(name, email, dataNascimento, password, role);

            if (dataNascimento > DateTime.Now)
                throw new InvalidDateException();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Load all users from the file and add them to the list.
        /// </summary>
        /// <param name="users">The list to store users loaded from the file.</param>
        /// <returns>True if users are successfully loaded, otherwise false.</returns>
        public static bool LoadUsers(out List<User> users)
        {
            users = new List<User>();

            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("Arquivo de usuários não encontrado.");

                var lines = File.ReadLines(filePath);

                foreach (var line in lines)
                {
                    var user = BuildUser(line);
                    if (user != null)
                    {
                        users.Add(user);
                    }
                }

                return users.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro: " + ex.Message);
            }
        }

        /// <summary>
        /// Create a user instance from a line in the file.
        /// </summary>
        /// <param name="line">The line from the file containing user data.</param>
        /// <returns>A new <see cref="User"/> object if the line is valid, otherwise null.</returns>
        private static User BuildUser(string line)
        {
            var parts = line.Split(',');

            if (parts.Length != 6)
                return null;

            if (!Guid.TryParse(parts[0], out Guid id))
                return null;

            if (!DateTime.TryParseExact(parts[3], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
                return null;

            return new Users(
                id: id,
                name: parts[1],
                email: parts[2],
                dataNascimento: dataNascimento,
                password: parts[4],
                role: parts[5]
            );
        }

        /// <summary>
        /// Add a new user to the list and save to the file.
        /// </summary>
        /// <param name="user">The user to be added.</param>
        /// <returns>True if the user was successfully added, otherwise false.</returns>
        public static bool AddUser(Users user)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFound();

                if (!ValidateUserExists(user.Email))
                {
                    string userData = $"{user.Id},{user.Name},{user.Email},{user.DataNascimento:yyyy-MM-dd},{user.Password},{user.Role}";
                    File.AppendAllText(filePath, userData + Environment.NewLine);
                    users.Add(user);

                    return true;
                }
                else
                {
                    throw new UserExistsException("A user with this email already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred", ex);
            }
        }

        /// <summary>
        /// Validate if a user exists based on the email.
        /// </summary>
        /// <param name="email">The email of the user to check.</param>
        /// <returns>True if the user exists, otherwise false.</returns>
        public static bool ValidateUserExists(string email)
        {
            return users.Any(user => user.Email == email);
        }

        /// <summary>
        /// Validate input fields for user creation.
        /// </summary>
        /// <param name="name">The name of the user.</param>
        /// <param name="email">The email of the user.</param>
        /// <param name="dataNascimento">The birth date of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="role">The role of the user.</param>
        private static void ValidateFields(string name, string email, DateTime dataNascimento, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new NullArgumentException("Name");

            if (string.IsNullOrWhiteSpace(email))
                throw new NullArgumentException("Email");

            if (dataNascimento == default)
                throw new NullArgumentException("DataNascimento");

            if (string.IsNullOrWhiteSpace(password))
                throw new NullArgumentException("Password");

            if (string.IsNullOrWhiteSpace(role))
                throw new NullArgumentException("Role");
        }

        /// <summary>
        /// Override the abstract method to return the user's name.
        /// </summary>
        /// <returns>The name of the user.</returns>
        public override string GetName()
        {
            return Name;
        }
        #endregion
    }
}
