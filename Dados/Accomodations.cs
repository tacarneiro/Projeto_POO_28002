using Objects;
using System.Globalization;
using System.Text;
using static Excecoes.Excecoes;

namespace Dados
{
    public class Accommodations : Accommodation
    {
        #region Attributes
        private static List<Accommodations> accommodationsList = new List<Accommodations>();
        private const string FilePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Accommodations.txt";
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Accommodations"/> class.
        /// </summary>
        /// <param name="accommodationId">The unique identifier for the accommodation.</param>
        /// <param name="name">The name of the accommodation.</param>
        /// <param name="type">The type of the accommodation (e.g., Hotel, Apartment).</param>
        /// <param name="location">The location of the accommodation.</param>
        /// <param name="price">The price per night for the accommodation.</param>
        /// <param name="capacity">The capacity of the accommodation (number of people it can host).</param>
        /// <param name="available">Indicates if the accommodation is available for booking.</param>
        /// <param name="image">The image URL or file path for the accommodation's image.</param>
        public Accommodations(Guid accommodationId, string name, string type, string location, decimal price, int capacity, bool available, string image)
            : base(accommodationId, name, type, location, price, capacity, available, image)
        {
            accommodationsList.Add(this);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets all accommodations stored in memory.
        /// </summary>
        /// <returns>A list of all accommodations.</returns>
        public static List<Accommodations> GetAllAccommodations()
        {
            return accommodationsList;
        }

        /// <summary>
        /// Finds an accommodation by its unique identifier.
        /// </summary>
        /// <param name="accommodationId">The unique identifier of the accommodation.</param>
        /// <returns>The accommodation if found, otherwise throws an exception.</returns>
        public static Accommodations FindAccommodationById(Guid accommodationId)
        {
            return accommodationsList.FirstOrDefault(a => a.AccommodationID == accommodationId)
                ?? throw new NotFoundException("Accommodation not found.");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a new accommodation to the list and saves it to the file.
        /// </summary>
        /// <param name="accommodation">The accommodation to be added.</param>
        /// <returns>True if the accommodation was successfully added.</returns>
        public static bool AddAccommodation(Accommodations accommodation)
        {
            if (accommodation == null)
                throw new NullArgumentException("Accommodation");

            try
            {
                accommodation.ValidateFields();
                accommodationsList.Add(accommodation);

                SaveFile(accommodation);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding accommodation: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Updates the availability status of an accommodation.
        /// </summary>
        /// <param name="accommodationId">The unique identifier of the accommodation to update.</param>
        /// <param name="availability">The new availability status of the accommodation.</param>
        public static void UpdateAvailability(Guid accommodationId, bool availability)
        {
            var accommodation = FindAccommodationById(accommodationId);
            accommodation.SetAvailability(availability);

            RewriteFile();
        }

        /// <summary>
        /// Deletes an accommodation from the list and updates the file.
        /// </summary>
        /// <param name="accommodationId">The unique identifier of the accommodation to be deleted.</param>
        public static void DeleteAccommodation(Guid accommodationId)
        {
            var accommodation = FindAccommodationById(accommodationId);
            accommodationsList.Remove(accommodation);

            RewriteFile();
        }

        /// <summary>
        /// Updates an existing accommodation with new information.
        /// </summary>
        /// <param name="updatedAccommodation">The accommodation with updated details.</param>
        public static void UpdateAccommodation(Accommodations updatedAccommodation)
        {
            var index = accommodationsList.FindIndex(a => a.AccommodationID == updatedAccommodation.AccommodationID);

            if (index == -1)
                throw new NotFoundException("Accommodation not found.");

            accommodationsList[index] = updatedAccommodation;

            RewriteFile();
        }

        /// <summary>
        /// Saves a new accommodation to the file.
        /// </summary>
        /// <param name="accommodation">The accommodation to be saved.</param>
        private static void SaveFile(Accommodations accommodation)
        {
            var line = $"{accommodation.AccommodationID}," +
                       $"{accommodation.Name}," +
                       $"{accommodation.Type}," +
                       $"{accommodation.Location}," +
                       $"{accommodation.Price.ToString(CultureInfo.InvariantCulture)}," +
                       $"{accommodation.Capacity}," +
                       $"{accommodation.Available}," +
                       $"{accommodation.Image}";

            File.AppendAllText(FilePath, line + Environment.NewLine, Encoding.UTF8);
        }

        /// <summary>
        /// Rewrites the accommodation file with the updated list of accommodations.
        /// </summary>
        private static void RewriteFile()
        {
            var lines = accommodationsList.Select(a =>
                $"{a.AccommodationID}," +
                $"{a.Name}," +
                $"{a.Type}," +
                $"{a.Location}," +
                $"{a.Price.ToString(CultureInfo.InvariantCulture)}," +
                $"{a.Capacity}," +
                $"{a.Available}," +
                $"{a.Image}");

            File.WriteAllLines(FilePath, lines, Encoding.UTF8);
        }

        /// <summary>
        /// Loads accommodations from a file and stores them in memory.
        /// </summary>
        /// <returns>A list of loaded accommodations.</returns>
        public static List<Accommodations> LoadAccommodations()
        {
            var loadedAccommodations = new List<Accommodations>();

            if (!File.Exists(FilePath))
                return loadedAccommodations;

            var lines = File.ReadAllLines(FilePath, Encoding.UTF8);

            foreach (var line in lines)
            {
                try
                {
                    var accommodation = BuildAccommodation(line);
                    if (accommodation != null)
                    {
                        loadedAccommodations.Add(accommodation);
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error loading accommodation: {ex.Message}");
                }
            }

            accommodationsList = loadedAccommodations;
            return accommodationsList;
        }

        /// <summary>
        /// Builds an accommodation from a line of data read from the file.
        /// </summary>
        /// <param name="line">A line of data representing an accommodation.</param>
        /// <returns>An <see cref="Accommodations"/> object if valid data, otherwise null.</returns>
        private static Accommodations BuildAccommodation(string line)
        {
            var parts = line.Split(',');

            if (parts.Length != 8)
                throw new InvalidOperationException("Invalid accommodation data format.");

            if (!decimal.TryParse(parts[4], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal pricePerNight))
                throw new InvalidOperationException("Invalid price format.");

            if (!int.TryParse(parts[5], out int capacity))
                throw new InvalidOperationException("Invalid capacity format.");

            if (!bool.TryParse(parts[6], out bool isAvailable))
                throw new InvalidOperationException("Invalid availability format.");

            return new Accommodations(
                Guid.Parse(parts[0]),
                parts[1],
                parts[2],
                parts[3],
                pricePerNight,
                capacity,
                isAvailable,
                parts[7]
            );
        }

        /// <summary>
        /// Validates the fields of the accommodation when being created or updated.
        /// </summary>
        public void ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException(nameof(Name), "Name cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(Type))
                throw new ArgumentNullException(nameof(Type), "Type cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(Location))
                throw new ArgumentNullException(nameof(Location), "Location cannot be null or empty.");

            if (Price <= 0)
                throw new ArgumentException("Price must be greater than zero.", nameof(Price));

            if (Capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.", nameof(Capacity));
        }

        /// <summary>
        /// Gets the availability status of the accommodation.
        /// </summary>
        /// <returns>True if the accommodation is available, otherwise false.</returns>
        public override bool GetAvailability()
        {
            return Available;
        }
        #endregion
    }
}
