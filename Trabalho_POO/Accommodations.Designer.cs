﻿namespace Trabalho_POO
{
    partial class Accommodations
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
            flpAccommodations = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // flpAccommodations
            // 
            flpAccommodations.AutoScroll = true;
            flpAccommodations.Location = new Point(0, 44);
            flpAccommodations.Name = "flpAccommodations";
            flpAccommodations.Size = new Size(1122, 560);
            flpAccommodations.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 196, 220);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(992, 4);
            button1.Name = "button1";
            button1.Size = new Size(109, 36);
            button1.TabIndex = 1;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Accommodations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 604);
            Controls.Add(button1);
            Controls.Add(flpAccommodations);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Accommodations";
            Text = "Accommodations";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpAccommodations;
        private Button button1;
    }
}