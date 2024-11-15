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
            try
            {
                Users.LoadUsers(out users);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Login Button
        private void btLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim(),
                   password = tbPassword.Text.Trim();

            try
            {
                ValidateFields(email, password);

                User user = users.Find(u => string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase));

                if (user == null)
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (user.Password != password)
                {
                    MessageBox.Show("Senha incorreta.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                OnLoginSuccess?.Invoke();
                this.Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
