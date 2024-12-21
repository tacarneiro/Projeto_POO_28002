
using Dados;
using Objects;
using System.Globalization;
using static Excecoes.Excecoes;

namespace Trabalho_POO
{
    public partial class CreateAcc : Form
    {
        private Dados.Accommodations accommodationToEdit;

        public CreateAcc()
        {
            InitializeComponent();
        }

        #region Create Accommodation
        private void btCreateAccomodation_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                if (accommodationToEdit != null)
                {
                    accommodationToEdit.Name = tbName.Text.Trim();
                    accommodationToEdit.Type = tbType.Text.Trim();
                    accommodationToEdit.Location = tbLocation.Text.Trim();
                    accommodationToEdit.Price = decimal.Parse(tbPrice.Text.Trim(), CultureInfo.InvariantCulture);
                    accommodationToEdit.Capacity = int.Parse(tbCapacity.Text.Trim());
                    accommodationToEdit.Available = cbAvailable.Checked;

                    Dados.Accommodations.UpdateAccommodation(accommodationToEdit);
                    MessageBox.Show("Accommodation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var newAccommodation = new Dados.Accommodations(
                        Guid.NewGuid(),
                        tbName.Text.Trim(),
                        tbType.Text.Trim(),
                        tbLocation.Text.Trim(),
                        decimal.Parse(tbPrice.Text.Trim(), CultureInfo.InvariantCulture),
                        int.Parse(tbCapacity.Text.Trim()),
                        cbAvailable.Checked,
                        ""
                    );

                    if (Dados.Accommodations.AddAccommodation(newAccommodation))
                    {
                        MessageBox.Show("Accommodation created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                ClearFields(tbName, tbType, tbLocation, tbPrice, tbCapacity);
                cbAvailable.Checked = false;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onClosePage()
        {
            ClearFields(tbName, tbType, tbLocation, tbPrice, tbCapacity, cbAvailable);
            this.Hide();
        }
        #endregion

        #region Other Functions
        private static void ClearFields(params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Clear();
                }
            }
        }

        private bool ValidateFields()
        {
            Control[] controls = { tbName, tbType, tbLocation, tbPrice, tbCapacity };

            foreach (var control in controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"The field '{textBox.Name}' cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    return false;
                }
            }

            if (!decimal.TryParse(tbPrice.Text, out _))
            {
                MessageBox.Show("The field 'Price' must be a valid decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPrice.Focus();
                return false;
            }

            if (!int.TryParse(tbCapacity.Text, out _))
            {
                MessageBox.Show("The field 'Capacity' must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCapacity.Focus();
                return false;
            }

            return true;
        }

        public void SetAccommodationData(Dados.Accommodations accommodation)
        {
            accommodationToEdit = accommodation;

            tbName.Text = accommodation.Name;
            tbType.Text = accommodation.Type;
            tbLocation.Text = accommodation.Location;
            tbPrice.Text = accommodation.Price.ToString(CultureInfo.InvariantCulture);
            tbCapacity.Text = accommodation.Capacity.ToString();
            cbAvailable.Checked = accommodation.Available;

            btCreateAccomodation.Text = "Edit";
        }
        #endregion

        private void CreateAcc_Load(object sender, EventArgs e)
        {

        }
    }
}
