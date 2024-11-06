using Dados;
using Objects;
using static Excecoes.Excecoes;

namespace Trabalho_POO
{
    public partial class Login : Form
    {
        public event Action OnLoginSuccess;
        public event Action OnCreateAccount;
        private List<User> users = new List<User>();

        public Login()
        {
            InitializeComponent();
        }

        #region Load Users
        private void Login_Load(object sender, EventArgs e)
        {
            users = Users.LoadUsers(out string error);

            if (error != null)
            {
                
            }
        }
        #endregion

        #region Login Button
        private void btLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim(),
                   password = tbPassword.Text;

            try
            {
                ValidateFields(email, password);

                User user = users.Find(user => user.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

                if (user == null)
                {
                    throw new UserNotFoundException();
                }

                if (user.Password != password)
                {
                    throw new WrongPasswordException();
                }

                OnLoginSuccess?.Invoke();
                this.Close();
            }
            catch (NullArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UserNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (WrongPasswordException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateFields(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new NullArgumentException("email");

            if (string.IsNullOrWhiteSpace(password))
                throw new NullArgumentException("password");
        }
        #endregion

        #region Create Account
        private void llCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnCreateAccount?.Invoke();
            this.Close();
        }
        #endregion
    }
}
