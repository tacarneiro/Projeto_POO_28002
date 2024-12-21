namespace Trabalho_POO
{
    partial class CreateAcc
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
            btCreateAccomodation = new Button();
            tbType = new TextBox();
            tbName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbPrice = new TextBox();
            tbLocation = new TextBox();
            label1 = new Label();
            label4 = new Label();
            tbCapacity = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cbAvailable = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btCreateAccomodation
            // 
            btCreateAccomodation.BackColor = SystemColors.Control;
            btCreateAccomodation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCreateAccomodation.ForeColor = Color.Black;
            btCreateAccomodation.Location = new Point(483, 341);
            btCreateAccomodation.Name = "btCreateAccomodation";
            btCreateAccomodation.Size = new Size(147, 45);
            btCreateAccomodation.TabIndex = 24;
            btCreateAccomodation.Text = "Create";
            btCreateAccomodation.UseVisualStyleBackColor = false;
            btCreateAccomodation.Click += btCreateAccomodation_Click;
            // 
            // tbType
            // 
            tbType.BackColor = SystemColors.Control;
            tbType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbType.ForeColor = Color.DimGray;
            tbType.Location = new Point(238, 190);
            tbType.MaxLength = 14;
            tbType.Name = "tbType";
            tbType.Size = new Size(273, 29);
            tbType.TabIndex = 23;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.Control;
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.DimGray;
            tbName.Location = new Point(238, 141);
            tbName.Name = "tbName";
            tbName.Size = new Size(273, 29);
            tbName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Light", 14.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(183, 193);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 21;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(173, 141);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // tbPrice
            // 
            tbPrice.BackColor = SystemColors.Control;
            tbPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPrice.ForeColor = Color.DimGray;
            tbPrice.Location = new Point(702, 194);
            tbPrice.MaxLength = 14;
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(273, 29);
            tbPrice.TabIndex = 28;
            // 
            // tbLocation
            // 
            tbLocation.BackColor = SystemColors.Control;
            tbLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbLocation.ForeColor = Color.DimGray;
            tbLocation.Location = new Point(702, 145);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(273, 29);
            tbLocation.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Light", 14.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(649, 194);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 26;
            label1.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Light", 14.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(618, 147);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 25;
            label4.Text = "Location";
            // 
            // tbCapacity
            // 
            tbCapacity.BackColor = SystemColors.Control;
            tbCapacity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCapacity.ForeColor = Color.DimGray;
            tbCapacity.Location = new Point(238, 241);
            tbCapacity.Name = "tbCapacity";
            tbCapacity.Size = new Size(273, 29);
            tbCapacity.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Light", 14.25F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(616, 245);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 30;
            label5.Text = "Available";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Light", 14.25F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(156, 241);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 29;
            label6.Text = "Capacity";
            // 
            // cbAvailable
            // 
            cbAvailable.AutoSize = true;
            cbAvailable.Location = new Point(705, 251);
            cbAvailable.Name = "cbAvailable";
            cbAvailable.Size = new Size(15, 14);
            cbAvailable.TabIndex = 33;
            cbAvailable.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.back;
            pictureBox1.Location = new Point(1043, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 57);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // CreateAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 513);
            Controls.Add(pictureBox1);
            Controls.Add(cbAvailable);
            Controls.Add(tbCapacity);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(tbPrice);
            Controls.Add(tbLocation);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(btCreateAccomodation);
            Controls.Add(tbType);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "CreateAcc";
            Text = "CreateAcc";
            Load += CreateAcc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCreateAccomodation;
        private TextBox tbType;
        private TextBox tbName;
        private Label label3;
        private Label label2;
        private TextBox tbPrice;
        private TextBox tbLocation;
        private Label label1;
        private Label label4;
        private TextBox tbCapacity;
        private Label label5;
        private Label label6;
        private CheckBox cbAvailable;
        private PictureBox pictureBox1;
    }
}