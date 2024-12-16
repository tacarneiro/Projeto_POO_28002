using Objects;
using System.Globalization;
using System.Text;
using static Excecoes.Excecoes;

namespace Dados
{
    public class Accommodations
    {
        #region Attributes
        private static List<Accommodation> accommodations = new List<Accommodation>();
        private const string FilePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Accomodations.txt";
        #endregion

        #region Properties
        public static List<Accommodation> GetAllAccommodations()
        {
            return accommodations;
        }

        public static Accommodation FindAccommodationById(Guid accommodationId)
        {
            return accommodations.FirstOrDefault(a => a.AccommodationID == accommodationId)
                ?? throw new NotFoundException("Accommodation not found.");
        }
        #endregion

        #region Methods
        public static bool AddAccommodation(Accommodation accommodation)
        {
            if (accommodation == null)
                throw new NullArgumentException("Accommodation");

            try
            {
                accommodation.ValidateFields();
                accommodations.Add(accommodation);

                SaveFile(accommodation);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding accommodation: {ex.Message}");
                return false;
            }
        }

        public static void UpdateAvailability(Guid accommodationId, bool availability)
        {
            var accommodation = FindAccommodationById(accommodationId);
            accommodation.SetAvailability(availability);

            RewriteFile();
        }

        public static void DeleteAccommodation(Guid accommodationId)
        {
            var accommodation = FindAccommodationById(accommodationId);

            accommodations.Remove(accommodation);

            RewriteFile();
        }

        public static void UpdateAccommodation(Accommodation updatedAccommodation)
        {
            var index = accommodations.FindIndex(a => a.AccommodationID == updatedAccommodation.AccommodationID);

            if (index == -1)
            {
                throw new NotFoundException("Accommodation not found.");
            }

            accommodations[index] = updatedAccommodation;

            RewriteFile();
        }


        private static void SaveFile(Accommodation accommodation)
        {
            var line = $"{accommodation.AccommodationID}," +
                       $"{accommodation.Name}," +
                       $"{accommodation.Type}," +
                       $"{accommodation.Location}," +
                       $"{accommodation.Price.ToString(CultureInfo.InvariantCulture)}," +
                       $"{accommodation.Capacity}," +
                       $"{accommodation.Available}," +
                       "BeachsideVilla.jpeg";

            File.AppendAllText(FilePath, line + Environment.NewLine, Encoding.UTF8);
        }

        private static void RewriteFile()
        {
            var lines = accommodations.Select(a =>
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

        public static List<Accommodation> LoadAccommodations()
        {
            var loadedAccommodations = new List<Accommodation>();

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

            accommodations = loadedAccommodations;
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
