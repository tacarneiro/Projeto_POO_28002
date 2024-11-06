namespace Trabalho_POO
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btLogin = new Button();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            llCreate = new LinkLabel();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.FromArgb(40, 196, 220);
            btLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = Color.White;
            btLogin.Location = new Point(578, 490);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(147, 53);
            btLogin.TabIndex = 17;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(40, 196, 220);
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.White;
            tbPassword.Location = new Point(523, 378);
            tbPassword.MaxLength = 14;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(273, 29);
            tbPassword.TabIndex = 16;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.FromArgb(40, 196, 220);
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = Color.White;
            tbEmail.Location = new Point(523, 306);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(273, 29);
            tbEmail.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(402, 379);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(441, 306);
            label2.Name = "label2";
            label2.Size = new Size(66, 30);
            label2.TabIndex = 13;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(531, 181);
            label1.Name = "label1";
            label1.Size = new Size(237, 65);
            label1.TabIndex = 12;
            label1.Text = "Welcome";
            // 
            // llCreate
            // 
            llCreate.ActiveLinkColor = Color.White;
            llCreate.AutoSize = true;
            llCreate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llCreate.ForeColor = Color.White;
            llCreate.LinkColor = Color.White;
            llCreate.Location = new Point(552, 422);
            llCreate.Name = "llCreate";
            llCreate.Size = new Size(210, 21);
            llCreate.TabIndex = 18;
            llCreate.TabStop = true;
            llCreate.Text = "Click to create an account";
            llCreate.LinkClicked += llCreate_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 196, 220);
            ClientSize = new Size(1232, 723);
            Controls.Add(llCreate);
            Controls.Add(btLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form2";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogin;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel llCreate;
    }
}