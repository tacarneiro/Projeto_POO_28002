using Dados;
using Objects;

namespace Trabalho_POO
{
    public partial class Main : Form
    {
        Reservations reservations;
        Clients clients;
        Login login;
        New create;
        Accommodations accommodations;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideSideBar();
        }

        #region Login Page
        private void HideSideBar()
        {
            if (create != null)
            {
                create.Close();
            }

            sideBar.Visible = false;
            btSideBar.Visible = false;

            if (login == null)
            {
                login = new Login();
                login.FormClosed += Login_FormClosed;
                login.OnLoginSuccess += Login_OnLoginSuccess;
                login.OnCreateAccount += Login_OnCreateAccount;
                login.MdiParent = this;
                login.Dock = DockStyle.Fill;
                login.Show();
            }
        }

        private void Login_OnLoginSuccess()
        {
            sideBar.Visible = true;
            btSideBar.Visible = true;

            accommodations = new Accommodations();
            accommodations.FormClosed += Accommodations_FormClosed;
            accommodations.MdiParent = this;
            accommodations.Dock = DockStyle.Fill;
            accommodations.Show();
        }

        private void Accommodations_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private void Login_FormClosed(object? sender, FormClosedEventArgs e)
        {
            login = null;
        }

        private void Create_FormClosed(object? sender, FormClosedEventArgs e)
        {
            create = null;
        }
        #endregion

        #region Create User Page
        private void Login_OnCreateAccount()
        {
            if (create == null)
            {
                create = new New();
                create.FormClosed += Create_FormClosed;
                create.OnCreateSuccess += Create_OnCreateSuccess;
                create.OnCreateCancel += Create_OnCreateCancel;
                create.MdiParent = this;
                create.Dock = DockStyle.Fill;
                create.Show();
            }
        }

        private void Create_OnCreateCancel()
        {
            HideSideBar();
        }

        private void Create_OnCreateSuccess()
        {
            HideSideBar();
        }
        #endregion

        #region Menu Controllers
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 228)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 48)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btManage_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sideBarExpand = true;
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 5;
                if (sideBar.Width <= 75)
                {
                    sideBarExpand = false;
                    sideBarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 5;
                if (sideBar.Width >= 206)
                {
                    sideBarExpand = true;
                    sideBarTransition.Stop();
                }
            }
        }

        private void btSideBar_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }

        private void btReservations_Click_1(object sender, EventArgs e)
        {
            if (reservations == null)
            {
                reservations = new Reservations();
                reservations.FormClosed += Reservations_FormClosed;
                reservations.MdiParent = this;
                reservations.Dock = DockStyle.Fill;
                reservations.Show();
            }
            else
            {
                reservations.Activate();
            }
        }

        private void Reservations_FormClosed(object? sender, FormClosedEventArgs e)
        {
            reservations = null;
        }

        private void btClients_Click_1(object sender, EventArgs e)
        {
            if (accommodations == null)
            {
                accommodations = new Accommodations();
                accommodations.FormClosed += Clients_FormClosed;
                accommodations.MdiParent = this;
                accommodations.Dock = DockStyle.Fill;
                accommodations.Show();
            }
            else
            {
                accommodations.Activate();
            }
        }

        private void Clients_FormClosed(object? sender, FormClosedEventArgs e)
        {
            accommodations = null;
        }
        #endregion
    }
}
