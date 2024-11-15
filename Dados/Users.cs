using static Excecoes.Excecoes;
using System.Globalization;
using Objects;

namespace Dados
{
    public class Users
    {
        /// <summary>
        /// Users Class
        /// </summary>
        /// 
        #region Attributes
        private static List<User> users = new List<User>();
        #endregion

        #region Properties
        public static List<User> GetUsers()
        {
            return users;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Load User Function
        /// </summary>
        /// 
        public static bool LoadUsers(out List<User> users)
        {
            string filePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Users.txt";
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
            catch (FileNotFoundException ex)
            {
                throw new Exception("Error occurred" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred " + ex.Message);
            }
        }

        private static User BuildUser(string line)
        {
            var parts = line.Split(',');

            if (parts.Length != 6)
                return null;

            if (!Guid.TryParse(parts[0], out Guid id))
                return null;

            if (!DateTime.TryParseExact(parts[3], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
                return null;

            var name = parts[1];
            var email = parts[2];
            var password = parts[4];
            var role = parts[5];

            return new User(id, name, email, dataNascimento, password, role);
        }

        /// <summary>
        /// Add User Function
        /// </summary>
        /// 
        public static bool AddUser(User user)
        {
            string filePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Users.txt";

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
        /// Validate User Exists Function
        /// </summary>
        /// 
        public static bool ValidateUserExists(string email)
        {
            return users.Any(user => user.Email == email);
        }
        #endregion
    }
}
