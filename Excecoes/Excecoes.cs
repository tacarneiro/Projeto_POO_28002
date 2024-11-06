namespace Excecoes
{
    public class Excecoes
    {
        #region Argumento Nulo
        public class NullArgumentException : Exception
        {
            public NullArgumentException(string fieldName) : base($"The field {fieldName} cannot be empty or null!") { }
        }
        #endregion

        #region File Not Found
        public class FileNotFound : Exception {
            public FileNotFound() : base("O ficheiro dos users não foi encontrado.") { }
        }
        #endregion

        #region Line Format Invalid
        public class InvalidLineFormatException : Exception
        {
            public InvalidLineFormatException() : base("O formato da linha de dados está incorreto. Esperado: id,nome,email,dataNascimento,password,role.") { }
        }
        #endregion

        #region Date Format Invalid
        public class InvalidDateFormatException : Exception
        {
            public InvalidDateFormatException() : base("Formato de data de nascimento inválido. Use o formato 'yyyy-MM-dd'.") { }
        }
        #endregion

        #region User Not Found
        public class UserNotFoundException: Exception
        {
            public UserNotFoundException() : base("User not found. Check the email you entered!") { }
        }
        #endregion

        #region Wrong Password
        public class WrongPasswordException : Exception
        {
            public WrongPasswordException() : base("Incorrect password.Try again!") { }
        }
        #endregion

        #region User Already Exists
        public class UserExistsException : Exception
        {
            public UserExistsException(string message) : base(message) { }
        }
        #endregion

        #region Invalid Guid Id
        public class InvalidGuidException : Exception
        {
            public InvalidGuidException(string message) : base(message) { }
        }
        #endregion
    }
}
