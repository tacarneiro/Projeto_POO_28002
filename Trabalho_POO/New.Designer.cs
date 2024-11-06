namespace Trabalho_POO
{
    partial class New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New));
            btCreate = new Button();
            tbEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbName = new TextBox();
            label6 = new Label();
            tbBirthDate = new TextBox();
            tBoxPassword = new TextBox();
            btBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btBack).BeginInit();
            SuspendLayout();
            // 
            // btCreate
            // 
            btCreate.BackColor = Color.FromArgb(40, 196, 220);
            btCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCreate.ForeColor = Color.White;
            btCreate.Location = new Point(549, 415);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(147, 53);
            btCreate.TabIndex = 23;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = false;
            btCreate.Click += btCreate_Click;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.FromArgb(40, 196, 220);
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = Color.White;
            tbEmail.Location = new Point(303, 336);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(273, 29);
            tbEmail.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(221, 336);
            label2.Name = "label2";
            label2.Size = new Size(66, 30);
            label2.TabIndex = 19;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(440, 143);
            label1.Name = "label1";
            label1.Size = new Size(373, 65);
            label1.TabIndex = 18;
            label1.Text = "Create Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(673, 336);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 25;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(675, 264);
            label5.Name = "label5";
            label5.Size = new Size(113, 30);
            label5.TabIndex = 24;
            label5.Text = "Birth Date";
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(40, 196, 220);
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.White;
            tbName.Location = new Point(303, 268);
            tbName.Name = "tbName";
            tbName.Size = new Size(273, 29);
            tbName.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(221, 268);
            label6.Name = "label6";
            label6.Size = new Size(71, 30);
            label6.TabIndex = 28;
            label6.Text = "Name";
            // 
            // tbBirthDate
            // 
            tbBirthDate.BackColor = Color.FromArgb(40, 196, 220);
            tbBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbBirthDate.ForeColor = Color.White;
            tbBirthDate.Location = new Point(794, 264);
            tbBirthDate.MaxLength = 10;
            tbBirthDate.Name = "tbBirthDate";
            tbBirthDate.Size = new Size(273, 29);
            tbBirthDate.TabIndex = 30;
            // 
            // tBoxPassword
            // 
            tBoxPassword.BackColor = Color.FromArgb(40, 196, 220);
            tBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tBoxPassword.ForeColor = Color.White;
            tBoxPassword.Location = new Point(794, 340);
            tBoxPassword.MaxLength = 14;
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.PasswordChar = '*';
            tBoxPassword.Size = new Size(273, 29);
            tBoxPassword.TabIndex = 31;
            // 
            // btBack
            // 
            btBack.Image = (Image)resources.GetObject("btBack.Image");
            btBack.Location = new Point(11, 12);
            btBack.Name = "btBack";
            btBack.Size = new Size(60, 60);
            btBack.SizeMode = PictureBoxSizeMode.AutoSize;
            btBack.TabIndex = 32;
            btBack.TabStop = false;
            btBack.Click += btBack_Click;
            // 
            // New
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 196, 220);
            ClientSize = new Size(1232, 723);
            Controls.Add(btBack);
            Controls.Add(tBoxPassword);
            Controls.Add(tbBirthDate);
            Controls.Add(tbName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(btCreate);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "New";
            Text = "New";
            Load += New_Load;
            ((System.ComponentModel.ISupportInitialize)btBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCreate;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        //private TextBox tbPassword;
        private Label label4;
        private Label label5;
        private TextBox tbName;
        private Label label6;
        private TextBox tbBirthDate;
        private TextBox tBoxPassword;
        private PictureBox btBack;
    }
}