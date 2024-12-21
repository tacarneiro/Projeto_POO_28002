using static Excecoes.Excecoes;
namespace Objects;

public abstract class User
{
    #region Attributes
    public Guid Id { get; protected set; }
    public string Name { get; protected set; }
    public string Email { get; protected set; }
    public DateTime DataNascimento { get; protected set; }
    public string Password { get; protected set; }
    public string Role { get; protected set; }
    #endregion

    #region Properties

    #endregion

    #region Constructor
    /// <summary>
    /// Initializes a new instance of the <see cref="User"/> class with the specified parameters.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <param name="name">The name of the user.</param>
    /// <param name="email">The email address of the user.</param>
    /// <param name="dataNascimento">The birth date of the user.</param>
    /// <param name="password">The password for the user.</param>
    /// <param name="role">The role assigned to the user.</param>
    public User(Guid id, string name, string email, DateTime dataNascimento, string password, string role)
    {
        Id = id;
        Name = name;
        Email = email;
        DataNascimento = dataNascimento;
        Password = password;
        Role = role;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Abstract method that should be implemented to return the user's name.
    /// </summary>
    /// <returns>The name of the user.</returns>
    public abstract string GetName();
    #endregion
}
