namespace Trabalho_POO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel5 = new Panel();
            button4 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel7 = new Panel();
            button6 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sideBarTransition = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
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
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.Black;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.Black;
            nightControlBox1.Location = new Point(1083, 11);
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 196, 220);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nightControlBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1232, 50);
            panel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(40, 196, 220);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(211, 673);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 196, 220);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 60);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 196, 220);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-5, -7);
            button1.Name = "button1";
            button1.Size = new Size(248, 74);
            button1.TabIndex = 6;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 196, 220);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 60);
            panel3.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(40, 196, 220);
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-5, -7);
            button2.Name = "button2";
            button2.Size = new Size(248, 74);
            button2.TabIndex = 6;
            button2.Text = "Reservas";
            button2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(40, 196, 220);
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel5);
            flowLayoutPanel2.Location = new Point(545, 138);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(233, 228);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(40, 196, 220);
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 135);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 60);
            panel5.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(40, 196, 220);
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(-5, -7);
            button4.Name = "button4";
            button4.Size = new Size(248, 74);
            button4.TabIndex = 6;
            button4.Text = "Clientes";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(40, 196, 220);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(546, 374);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 48);
            panel4.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(40, 196, 220);
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-5, -7);
            button3.Name = "button3";
            button3.Size = new Size(243, 64);
            button3.TabIndex = 6;
            button3.Text = "Definições";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(40, 196, 220);
            panel6.Controls.Add(button5);
            panel6.Location = new Point(546, 485);
            panel6.Name = "panel6";
            panel6.Size = new Size(233, 48);
            panel6.TabIndex = 10;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(40, 196, 220);
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(-5, -7);
            button5.Name = "button5";
            button5.Size = new Size(243, 64);
            button5.TabIndex = 6;
            button5.Text = "Sair";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(40, 196, 220);
            panel7.Controls.Add(button6);
            panel7.Location = new Point(546, 431);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 48);
            panel7.TabIndex = 11;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(40, 196, 220);
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(-5, -7);
            button6.Name = "button6";
            button6.Size = new Size(243, 64);
            button6.TabIndex = 6;
            button6.Text = "Sobre";
            button6.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Tick += menuTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 723);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private Panel panel7;
        private Button button6;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sideBarTransition;
    }
}
