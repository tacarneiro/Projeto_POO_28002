using static Excecoes.Excecoes;
using System.Globalization;
using Objects;
using System.Text;

namespace Dados
{
    public class Reservations
    {
        /// <summary>
        /// Reservations Class
        /// </summary>
        /// 
        #region Attributes
        private static List<Reservation> reservations = new List<Reservation>();
        public const string FilePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Reservations.txt";
        #endregion

        #region Properties
        public static List<Reservation> GetAllReservations()
        {
            return reservations;
        }

        /// <summary>
        /// Return all reservations by client ID.
        /// </summary>
        public static List<Reservation> GetReservationsByClient(Guid clientId)
        {
            return reservations.Where(r => r.ClientID == clientId && r.ReservationStatus == "Confirmed").ToList();
        }

        /// <summary>
        /// Return all reservations by accomodation ID.
        /// </summary>
        public static List<Reservation> GetReservationsByAccommodation(Guid accommodationId)
        {
            return reservations.Where(r => r.AccommodationID == accommodationId && r.ReservationStatus == "Confirmed").ToList();
        }

        /// <summary>
        /// Finds an reservation by ID.
        /// </summary>
        public static Reservation FindReservationById(Guid reservationId)
        {
            return reservations.FirstOrDefault(r => r.ReservationID == reservationId)
                   ?? throw new NotFoundException("Reservation not found.");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a new reservation to the repository and saves to file.
        /// </summary>
        public static bool AddReservation(Reservation reservation)
        {
            if (reservation == null)
                throw new ArgumentNullException(nameof(reservation));

            if (!IsAccommodationAvailable(reservation.AccommodationID, reservation.CheckInDate, reservation.CheckOutDate))
                throw new InvalidOperationException("The selected accommodation is not available for the specified dates.");

            try
            {
                reservation.ValidateFields();

                reservations.Add(reservation);

                SaveToFile();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding reservation: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Cancel an reservation by ID and saves changes.
        /// </summary>
        public static void CancelReservation(Guid reservationId)
        {
            var reservation = FindReservationById(reservationId);
            reservation.CancelReservation();

            SaveToFile();
        }

        /// <summary>
        /// Saves all reservations to a text file.
        /// </summary>
        private static void SaveToFile()
        {
            var lines = reservations.Select(r => $"{r.ReservationID},{r.ClientID},{r.AccommodationID},{r.CheckInDate:yyyy-MM-dd},{r.CheckOutDate:yyyy-MM-dd},{r.TotalPrice}");
            File.WriteAllLines(FilePath, lines, Encoding.UTF8);
        }

        /// <summary>
        /// Loads reservations from a text file into the repository.
        /// </summary>
        public static List<Reservation> LoadReservations()
        {
            var reservations = new List<Reservation>();

            if (!File.Exists(FilePath))
                return reservations;

            var lines = File.ReadAllLines(FilePath, Encoding.UTF8);

            foreach (var line in lines)
            {
                try
                {
                    var reservation = BuildReservation(line);
                    if (reservation != null)
                    {
                        reservations.Add(reservation);
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error loading reservation: {ex.Message}");
                }
            }

            return reservations;
        }

        private static Reservation BuildReservation(string line)
        {
            var parts = line.Split(',');

            if (parts.Length != 6)
                throw new InvalidOperationException("Invalid reservation data format.");

            if (!Guid.TryParse(parts[0], out Guid reservationId))
                throw new InvalidOperationException("Invalid Reservation ID format.");

            if (!Guid.TryParse(parts[1], out Guid clientId))
                throw new InvalidOperationException("Invalid Client ID format.");

            if (!Guid.TryParse(parts[2], out Guid accommodationId))
                throw new InvalidOperationException("Invalid Accommodation ID format.");

            if (!DateTime.TryParseExact(parts[3], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime checkInDate))
                throw new InvalidOperationException("Invalid Check-in Date format.");

            if (!DateTime.TryParseExact(parts[4], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime checkOutDate))
                throw new InvalidOperationException("Invalid Check-out Date format.");

            if (!decimal.TryParse(parts[5], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal totalPrice))
                throw new InvalidOperationException("Invalid Total Price format.");

            return new Reservation(
                reservationId,
                clientId,
                accommodationId,
                checkInDate,
                checkOutDate,
                totalPrice,
                parts[6]
            );
        }

        private static bool IsAccommodationAvailable(Guid accommodationId, DateTime checkIn, DateTime checkOut)
        {
            return !reservations.Any(r =>
                r.AccommodationID == accommodationId &&
                r.ReservationStatus == "Confirmed" &&
                ((checkIn >= r.CheckInDate && checkIn < r.CheckOutDate) ||
                 (checkOut > r.CheckInDate && checkOut <= r.CheckOutDate) ||
                 (checkIn <= r.CheckInDate && checkOut >= r.CheckOutDate)));
        }
        #endregion
    }
}
