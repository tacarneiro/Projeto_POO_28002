using static Excecoes.Excecoes;
namespace Objects;

public class User
{
    #region ATRIBUTOS
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public string Password { get; private set; }
    public string Role { get; private set; }
    #endregion

    #region CONSTRUTORES
    public User(Guid id, string name, string email, DateTime dataNascimento, string password, string role)
    {
        try {
            Id = id;
            ValidateFields(name, email, dataNascimento, password, role);
            Name = name;
            Email = email;
            DataNascimento = dataNascimento;
            Password = password;
            Role = role;
        }
        catch { 
        
        }
    }

    #endregion

    #region OUTROS MÉTODOS
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

        if (string.IsNullOrWhiteSpace(password))
            throw new NullArgumentException("Role");
    }
    #endregion
}
