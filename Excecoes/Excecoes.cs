namespace Excecoes
{
    public class Excecoes
    {
        #region Null Argument
        public class NullArgumentException : Exception
        {
            public NullArgumentException(string fieldName) : base($"The field {fieldName} cannot be empty or null!") { }
        }
        #endregion

        #region File Not Found
        public class FileNotFound : Exception {
            public FileNotFound() : base("O ficheiro dos users não foi encontrado.") { }
            public FileNotFound(string message) : base(message) { }
        }
        #endregion

        #region Line Format Invalid
        public class InvalidLineFormatException : Exception
        {
            public InvalidLineFormatException() : base("O formato da linha de dados está incorreto. Esperado: id,nome,email,dataNascimento,password,role.") { }
            public InvalidLineFormatException(string message) : base(message) { }
        }
        #endregion

        #region Date Format Invalid
        public class InvalidDateFormatException : Exception
        {
            public InvalidDateFormatException() : base("Formato de data de nascimento inválido. Use o formato 'yyyy-MM-dd'.") { }
            public InvalidDateFormatException(string message) : base(message) { }
        }
        #endregion

        #region Invalid Date
        public class InvalidDateException : Exception
        {
            public InvalidDateException() : base("Data inválida!") { }

            public InvalidDateException(string message) : base(message) { }
        }
        #endregion

        #region User Not Found
        public class UserNotFoundException: Exception
        {
            public UserNotFoundException() : base("User not found. Check the email you entered!") { }
            public UserNotFoundException(string message) : base(message) { }
        }
        #endregion

        #region Wrong Password
        public class WrongPasswordException : Exception
        {
            public WrongPasswordException() : base("Incorrect password.Try again!") { }
            public WrongPasswordException(string message) : base(message) { }
        }
        #endregion

        #region User Already Exists
        public class UserExistsException : Exception
        {
            public UserExistsException() : base("User already exists!") { }
            public UserExistsException(string message) : base(message) { }
        }
        #endregion

        #region Invalid Guid Id
        public class InvalidGuidException : Exception
        {
            public InvalidGuidException() : base("Invalid guid id!") { }
            public InvalidGuidException(string message) : base(message) { }
        }
        #endregion

        #region Not Found
        public class NotFoundException : Exception 
        {
            public NotFoundException(string message) : base(message) { }
        }
        #endregion
    }
}
