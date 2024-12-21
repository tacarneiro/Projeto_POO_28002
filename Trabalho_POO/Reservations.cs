using Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadReservations();
        }

        #region Load Reservations
        private void LoadReservations()
        {
            try
            {
                var reservations = Dados.Reservations.LoadReservations();

                dgvReservations.Rows.Clear();

                foreach (var reservation in reservations)
                {
                    dgvReservations.Rows.Add(
                        reservation.ReservationID,
                        reservation.ClientName,
                        reservation.AccommodationName,
                        reservation.CheckInDate.ToString("dd/MM/yyyy"),
                        reservation.CheckOutDate.ToString("dd/MM/yyyy"),
                        reservation.TotalPrice.ToString("C"),
                        reservation.ReservationStatus
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Other Functions
        private void ConfigureDataGridView()
        {
            dgvReservations.Columns.Clear();

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ReservationID",
                HeaderText = "Reservation ID",
                Visible = false
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClientID",
                HeaderText = "Client ID",
                Width = 200
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AccommodationID",
                HeaderText = "Accommodation ID",
                Width = 200
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CheckInDate",
                HeaderText = "Check-In Date",
                Width = 200
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CheckOutDate",
                HeaderText = "Check-Out Date",
                Width = 200
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalPrice",
                HeaderText = "Total Price",
                Width = 100
            });

            dgvReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ReservationStatus",
                HeaderText = "Status",
                Width = 180
            });
        }

        #endregion
        private void Reservations_Load(object sender, EventArgs e)
        {

        }
    }
}
