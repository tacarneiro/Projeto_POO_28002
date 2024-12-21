using Objects;
using Dados;
using static Excecoes.Excecoes;
using System.Globalization;

namespace Trabalho_POO
{
    public partial class New : Form
    {
        public event Action OnCreateSuccess;
        public event Action OnCreateCancel;
        private List<User> users = new List<User>();

        public New()
        {
            InitializeComponent();
        }

        private void New_Load(object sender, EventArgs e)
        {
            ClearFields(mbBirthDate, tbEmail, tbName, tBoxPassword);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ClearFields(mbBirthDate, tbEmail, tbName, tBoxPassword);
        }

        #region Create Button
        private void btCreate_Click(object sender, EventArgs e) {
            string name = tbName.Text.Trim(),
                   email = tbEmail.Text.Trim(),
                   password = tBoxPassword.Text;

            DateTime dataNascimento = DateTime.Parse(mbBirthDate.Text).Date;

            try
            {
                bool result = Users.AddUser(new Users(Guid.NewGuid(), name, email, dataNascimento, password, "Client"));

                if (result)
                {
                    ClearFields(mbBirthDate, tbEmail, tbName, tBoxPassword);
                    OnCreateSuccess?.Invoke();
                    this.Close();
                }
            }
            catch (UserExistsException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Clear();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private static void ClearFields(params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Clear();
                }
            }
        }

    }
}
