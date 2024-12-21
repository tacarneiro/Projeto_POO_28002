namespace Trabalho_POO
{
    partial class Reservations
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
            dgvReservations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // dgvReservations
            // 
            dgvReservations.BackgroundColor = Color.WhiteSmoke;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.GridColor = Color.WhiteSmoke;
            dgvReservations.Location = new Point(1, 117);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.Size = new Size(1137, 525);
            dgvReservations.TabIndex = 0;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 643);
            Controls.Add(dgvReservations);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reservations";
            Text = "Reservations";
            Load += Reservations_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReservations;
    }
}