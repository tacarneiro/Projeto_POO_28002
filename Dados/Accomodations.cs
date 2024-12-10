using Objects;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using static Excecoes.Excecoes;

namespace Dados
{
    public class Accommodations
    {
        /// <summary>
        /// Accomodations Class
        /// </summary>
        /// 
        #region Attributes
        private static List<Accommodation> accommodations = new List<Accommodation>();
        private const string FilePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Accomodations.txt";
        #endregion

        #region Properties
        /// <summary>
        /// Returns all accomodations.
        /// </summary>
        public static List<Accommodation> GetAllAccommodations()
        {
            return accommodations;
        }

        /// <summary>
        /// Finds an accommodation by ID.
        /// </summary>
        public static Accommodation FindAccommodationById(Guid accommodationId)
        {
            return accommodations.FirstOrDefault(a => a.AccommodationID == accommodationId) 
                ?? throw new NotFoundException("Accommodation not found.");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a new accommodation to the repository and saves to file.
        /// </summary>
        public static bool AddAccommodation(Accommodation accommodation)
        {
            if (accommodation == null)
                throw new NullArgumentException("Accommodation");

            try
            {
                accommodation.ValidateFields();

                accommodations.Add(accommodation);

                SaveToFile();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding accommodation: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Updates the availability status of an accommodation and saves changes.
        /// </summary>
        public static void UpdateAvailability(Guid accommodationId, bool availability)
        {
            var accommodation = FindAccommodationById(accommodationId);
            accommodation.SetAvailability(availability);

            SaveToFile();
        }

        /// <summary>
        /// Deletes an accommodation by ID and saves changes.
        /// </summary>
        public static void DeleteAccommodation(Guid accommodationId)
        {
            var accommodation = FindAccommodationById(accommodationId);
            accommodations.Remove(accommodation);

            SaveToFile();
        }

        /// <summary>
        /// Saves all accommodations to a text file.
        /// </summary>
        private static void SaveToFile()
        {
            var lines = accommodations.Select(a => $"{a.AccommodationID},{a.Name},{a.Type},{a.Location},{a.Price.ToString(CultureInfo.InvariantCulture)},{a.Capacity},{a.Available}");
            File.WriteAllLines(FilePath, lines, Encoding.UTF8);
        }

        /// <summary>
        /// Loads accommodations from a text file into the repository.
        /// </summary>
        public static List<Accommodation> LoadAccomodations()
        {
            var accommodations = new List<Accommodation>();

            if (!File.Exists(FilePath))
                return accommodations;

            var lines = File.ReadAllLines(FilePath, Encoding.UTF8);

            foreach (var line in lines)
            {
                try
                {
                    var accomodation = BuildAccommodation(line);
                    if (accommodations != null)
                    {
                        accommodations.Add(accomodation);
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error loading reservation: {ex.Message}");
                }
            }

            return accommodations;
        }

        private static Accommodation BuildAccommodation(string line)
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

            return new Accommodation(
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

        #endregion
    }
}
