namespace Trabalho_POO
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btSideBar = new PictureBox();
            panel2 = new Panel();
            sideBar = new FlowLayoutPanel();
            menuContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            btManage = new Button();
            panel3 = new Panel();
            btReservations = new Button();
            panel5 = new Panel();
            btClients = new Button();
            panel7 = new Panel();
            btAbout = new Button();
            panel6 = new Panel();
            btLogOut = new Button();
            panel4 = new Panel();
            btSettings = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sideBarTransition = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)btSideBar).BeginInit();
            panel2.SuspendLayout();
            sideBar.SuspendLayout();
            menuContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.Black;
            nightControlBox1.DisableMinimizeColor = Color.Black;
            nightControlBox1.EnableCloseColor = Color.Black;
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.Black;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.Black;
            nightControlBox1.Location = new Point(1093, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 8);
            label1.Name = "label1";
            label1.Size = new Size(291, 30);
            label1.TabIndex = 2;
            label1.Text = "Gestão Alojamento Turístico";
            // 
            // btSideBar
            // 
            btSideBar.Image = (Image)resources.GetObject("btSideBar.Image");
            btSideBar.Location = new Point(3, 5);
            btSideBar.Name = "btSideBar";
            btSideBar.Size = new Size(58, 40);
            btSideBar.SizeMode = PictureBoxSizeMode.CenterImage;
            btSideBar.TabIndex = 1;
            btSideBar.TabStop = false;
            btSideBar.Click += btSideBar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 196, 220);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nightControlBox1);
            panel2.Controls.Add(btSideBar);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1232, 50);
            panel2.TabIndex = 4;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(40, 196, 220);
            sideBar.Controls.Add(menuContainer);
            sideBar.Controls.Add(panel7);
            sideBar.Controls.Add(panel6);
            sideBar.Controls.Add(panel4);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 50);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(75, 673);
            sideBar.TabIndex = 3;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(40, 196, 220);
            menuContainer.Controls.Add(panel1);
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(panel5);
            menuContainer.Location = new Point(3, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(233, 48);
            menuContainer.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 196, 220);
            panel1.Controls.Add(btManage);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 60);
            panel1.TabIndex = 5;
            // 
            // btManage
            // 
            btManage.BackColor = Color.FromArgb(40, 196, 220);
            btManage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btManage.ForeColor = Color.White;
            btManage.Image = (Image)resources.GetObject("btManage.Image");
            btManage.ImageAlign = ContentAlignment.MiddleLeft;
            btManage.Location = new Point(-10, -9);
            btManage.Name = "btManage";
            btManage.Padding = new Padding(30, 0, 45, 0);
            btManage.Size = new Size(245, 73);
            btManage.TabIndex = 6;
            btManage.Text = "    Manage";
            btManage.UseVisualStyleBackColor = false;
            btManage.Click += btManage_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 196, 220);
            panel3.Controls.Add(btReservations);
            panel3.Location = new Point(3, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 60);
            panel3.TabIndex = 6;
            // 
            // btReservations
            // 
            btReservations.BackColor = Color.FromArgb(40, 196, 220);
            btReservations.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btReservations.ForeColor = Color.White;
            btReservations.Image = (Image)resources.GetObject("btReservations.Image");
            btReservations.ImageAlign = ContentAlignment.MiddleLeft;
            btReservations.Location = new Point(-5, -13);
            btReservations.Name = "btReservations";
            btReservations.Padding = new Padding(30, 0, 45, 0);
            btReservations.Size = new Size(248, 83);
            btReservations.TabIndex = 6;
            btReservations.Text = "    Reservations";
            btReservations.UseVisualStyleBackColor = false;
            btReservations.Click += btReservations_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(40, 196, 220);
            panel5.Controls.Add(btClients);
            panel5.Location = new Point(3, 135);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 60);
            panel5.TabIndex = 8;
            // 
            // btClients
            // 
            btClients.BackColor = Color.FromArgb(40, 196, 220);
            btClients.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClients.ForeColor = Color.White;
            btClients.Image = (Image)resources.GetObject("btClients.Image");
            btClients.ImageAlign = ContentAlignment.MiddleLeft;
            btClients.Location = new Point(-5, -7);
            btClients.Name = "btClients";
            btClients.Padding = new Padding(30, 0, 45, 0);
            btClients.Size = new Size(248, 74);
            btClients.TabIndex = 6;
            btClients.Text = "    Clients";
            btClients.UseVisualStyleBackColor = false;
            btClients.Click += btClients_Click_1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(40, 196, 220);
            panel7.Controls.Add(btAbout);
            panel7.Location = new Point(3, 57);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 48);
            panel7.TabIndex = 11;
            // 
            // btAbout
            // 
            btAbout.BackColor = Color.FromArgb(40, 196, 220);
            btAbout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAbout.ForeColor = Color.White;
            btAbout.Image = (Image)resources.GetObject("btAbout.Image");
            btAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btAbout.Location = new Point(-5, -7);
            btAbout.Name = "btAbout";
            btAbout.Padding = new Padding(30, 0, 45, 0);
            btAbout.Size = new Size(243, 64);
            btAbout.TabIndex = 6;
            btAbout.Text = "    About";
            btAbout.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(40, 196, 220);
            panel6.Controls.Add(btLogOut);
            panel6.Location = new Point(3, 111);
            panel6.Name = "panel6";
            panel6.Size = new Size(233, 48);
            panel6.TabIndex = 10;
            // 
            // btLogOut
            // 
            btLogOut.BackColor = Color.FromArgb(40, 196, 220);
            btLogOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogOut.ForeColor = Color.White;
            btLogOut.Image = (Image)resources.GetObject("btLogOut.Image");
            btLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btLogOut.Location = new Point(-5, -7);
            btLogOut.Name = "btLogOut";
            btLogOut.Padding = new Padding(30, 0, 45, 0);
            btLogOut.Size = new Size(243, 64);
            btLogOut.TabIndex = 6;
            btLogOut.Text = "    Logout";
            btLogOut.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(40, 196, 220);
            panel4.Controls.Add(btSettings);
            panel4.Location = new Point(3, 165);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 48);
            panel4.TabIndex = 9;
            // 
            // btSettings
            // 
            btSettings.BackColor = Color.FromArgb(40, 196, 220);
            btSettings.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSettings.ForeColor = Color.White;
            btSettings.Image = (Image)resources.GetObject("btSettings.Image");
            btSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btSettings.Location = new Point(-5, -7);
            btSettings.Name = "btSettings";
            btSettings.Padding = new Padding(30, 0, 45, 0);
            btSettings.Size = new Size(243, 64);
            btSettings.TabIndex = 6;
            btSettings.Text = "    Settings";
            btSettings.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sideBarTransition
            // 
            sideBarTransition.Interval = 10;
            sideBarTransition.Tick += sideBarTransition_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 723);
            Controls.Add(sideBar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Main";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btSideBar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            sideBar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private PictureBox btSideBar;
        private Panel panel2;
        private FlowLayoutPanel sideBar;
        private Panel panel1;
        private Button btManage;
        private Panel panel3;
        private Button btReservations;
        private FlowLayoutPanel menuContainer;
        private Panel panel4;
        private Button btSettings;
        private Panel panel5;
        private Button btClients;
        private Panel panel6;
        private Button btLogOut;
        private Panel panel7;
        private Button btAbout;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sideBarTransition;
    }
}
