using Dados;
using Objects;

namespace Trabalho_POO
{
    public partial class Accommodations : Form
    {
        CreateAcc createacc;

        public Accommodations()
        {
            InitializeComponent();
            LoadAccommodations();
        }

        #region Load Accomodations
        private void LoadAccommodations()
        {
            try
            {
                flpAccommodations.Controls.Clear();

                var accommodations = Dados.Accommodations.LoadAccommodations();

                foreach (var accommodation in accommodations)
                {
                    var ImagePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Images\\" + accommodation.Image;

                    // Validar se imagem existe
                    if (!File.Exists(ImagePath))
                    {
                        throw new FileNotFoundException($"Image not found: {ImagePath}");
                    }

                    var card = new Panel
                    {
                        Width = 350,
                        Height = 450,
                        BackColor = Color.White,
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Adicionar a disponibilidade
                    var availabilityLabel = new Label
                    {
                        Text = accommodation.Available ? "Available" : "Not Available",
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        ForeColor = accommodation.Available ? Color.Green : Color.Red,
                        AutoSize = true,
                        Dock = DockStyle.Top,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    card.Controls.Add(availabilityLabel);

                    // Adicionar a localização
                    var locationLabel = new Label
                    {
                        Text = $"Location: {accommodation.Location}",
                        Font = new Font("Segoe UI", 10),
                        AutoSize = true,
                        Dock = DockStyle.Top,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    card.Controls.Add(locationLabel);

                    // Adicionar o preço
                    var priceLabel = new Label
                    {
                        Text = $"Price: {accommodation.Price:C}",
                        Font = new Font("Segoe UI", 10),
                        AutoSize = true,
                        Dock = DockStyle.Top,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    card.Controls.Add(priceLabel);

                    // Adicionar a capacidade
                    var capacityLabel = new Label
                    {
                        Text = $"Capacity: {accommodation.Capacity} people",
                        Font = new Font("Segoe UI", 10),
                        AutoSize = true,
                        Dock = DockStyle.Top,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    card.Controls.Add(capacityLabel);

                    // Adicionar o nome do alojamento
                    var nameLabel = new Label
                    {
                        Text = accommodation.Name,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        AutoSize = true,
                        Dock = DockStyle.Top,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Margin = new Padding(10)
                    };
                    card.Controls.Add(nameLabel);


                    var pictureBox = new PictureBox
                    {
                        Width = 330,
                        Height = 150,
                        Image = Image.FromFile(ImagePath),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Top,
                        Margin = new Padding(10)
                    };

                    card.Controls.Add(pictureBox);

                    // Adicionar um botão para ação (exemplo: reservar)
                    var actionButton = new Button
                    {
                        Text = "Edit",
                        BackColor = Color.FromArgb(40, 196, 220),
                        ForeColor = Color.White,
                        Dock = DockStyle.Bottom,
                        Height = 45,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold)
                    };
                    actionButton.Click += (sender, e) => EditAccommodation(accommodation);
                    card.Controls.Add(actionButton);

                    flpAccommodations.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Other Functions
        private void EditAccommodation(Accommodation accommodation)
        {
            if (createacc == null || createacc.IsDisposed)
            {
                createacc = new CreateAcc();
                createacc.FormClosed += Createacc_FormClosed;
                createacc.Dock = DockStyle.Fill;
            }

            createacc.SetAccommodationData(accommodation);

            createacc.Show();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (createacc == null)
            {
                createacc = new CreateAcc();
                createacc.FormClosed += Createacc_FormClosed;
                createacc.Dock = DockStyle.Fill;
                createacc.Show();
            }
        }

        private void Createacc_FormClosed(object? sender, FormClosedEventArgs e)
        {
            createacc = null;
            LoadAccommodations();
        }
        #endregion

        private void flpAccommodations_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
