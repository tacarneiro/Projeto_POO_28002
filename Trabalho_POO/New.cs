using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Excecoes.Excecoes;
using System.Globalization;

namespace Trabalho_POO
{
    public partial class New : Form
    {
        public event Action OnCreateSuccess;
        public event Action OnCreateCancel;
        //private List<User> users = new List<User>();

        public New()
        {
            InitializeComponent();
        }

        private void New_Load(object sender, EventArgs e)
        {
            ClearFields(tbBirthDate, tbEmail, tbName, tBoxPassword);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            ClearFields(tbBirthDate, tbEmail, tbName, tBoxPassword);
        }

        #region Create Button
        private void btCreate_Click(object sender, EventArgs e) {
            string name = tbName.Text.Trim(),
                   email = tbEmail.Text.Trim(),
                   password = tBoxPassword.Text,
                   role = "User";

            DateTime dataNascimento;
            Guid id = Guid.NewGuid();

            string filePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Bd", "Users.txt");

            if (!DateTime.TryParse(tbBirthDate.Text, out dataNascimento))
            {
                MessageBox.Show("Data de nascimento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ValidateFields(name, email, password);
                ValidateUserExists(email);

                //var newUser = new User(id, name, email, dataNascimento, password, role);

                //string userData = $"{newUser.Id},{newUser.Name},{newUser.Email},{newUser.DataNascimento:yyyy-MM-dd},{newUser.Password},{newUser.Role}";
                //File.AppendAllText(filePath, userData + Environment.NewLine);

                ClearFields(tbBirthDate, tbEmail, tbName, tBoxPassword);
                OnCreateSuccess?.Invoke();
                this.Close();
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
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ValidateFields(string name, string email, string password){
            if (string.IsNullOrWhiteSpace(name))
                throw new NullArgumentException("name");

            if (string.IsNullOrWhiteSpace(email))
                throw new NullArgumentException("email");

            if (string.IsNullOrWhiteSpace(password))
                throw new NullArgumentException("password");
        }

        private void ValidateUserExists(string email) {
            LoadUsers();
            //if (users.Any(user => user.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            //{
            //    throw new UserExistsException("Já existe um usuário com este email.");
            //}
        }

        private void LoadUsers()
        {
            string filePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Bd", "Users.txt");

            if (!File.Exists(filePath))
            {
                throw new FileNotFound();
            }

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length != 6)
                {
                    throw new InvalidLineFormatException();
                }

                Guid id;
                if (!Guid.TryParse(parts[0], out id))
                {
                    throw new InvalidGuidException("Formato de ID inválido.");
                }

                string name = parts[1],
                       email = parts[2];

                DateTime dataNascimento;
                if (!DateTime.TryParseExact(parts[3], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
                {
                    throw new InvalidDateFormatException();
                }

                string password = parts[4],
                       role = parts[5];

                //var user = new User(id, name, email, dataNascimento, password, role);
                //users.Add(user);
            }
        }
        #endregion

        private static void ClearFields(params TextBox[] textBoxes) {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
    }
}
