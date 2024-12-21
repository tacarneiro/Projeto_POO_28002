using static Excecoes.Excecoes;
using System.Globalization;
using Objects;
using System.Text;

namespace Dados
{
    public class Reservations : Reservation
    {
        #region Attributes
        private static List<Reservations> reservations = new List<Reservations>();
        public const string FilePath = "C:\\Projeto_POO_28002-dev\\Projeto_POO_28002-dev\\Trabalho_POO\\Bd\\Reservations.txt";
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Reservations"/> class.
        /// </summary>
        /// <param name="reservationId">Unique identifier for the reservation.</param>
        /// <param name="clientId">Unique identifier for the client making the reservation.</param>
        /// <param name="clientName">Name of the client.</param>
        /// <param name="accommodationId">Unique identifier for the accommodation.</param>
        /// <param name="accommodationName">Name of the accommodation.</param>
        /// <param name="checkInDate">Check-in date of the reservation.</param>
        /// <param name="checkOutDate">Check-out date of the reservation.</param>
        /// <param name="totalPrice">Total price of the reservation.</param>
        /// <param name="reservationStatus">Status of the reservation (e.g., "Confirmed").</param>
        /// <exception cref="InvalidOperationException">Thrown if the accommodation is not available for the selected dates.</exception>
        public Reservations(Guid reservationId, Guid clientId, string clientName, Guid accommodationId, string accommodationName, DateTime checkInDate, DateTime checkOutDate, decimal totalPrice, string reservationStatus)
            : base(reservationId, clientId, clientName, accommodationId, accommodationName, checkInDate, checkOutDate, totalPrice, reservationStatus)
        {
            if (!IsAccommodationAvailable(accommodationId, checkInDate, checkOutDate))
            {
                throw new InvalidOperationException("Accommodation is not available for the selected dates.");
            }

            reservations.Add(this);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a new reservation to the repository and saves it to a file.
        /// </summary>
        /// <param name="reservation">The reservation object to add.</param>
        /// <returns>True if the reservation is successfully added; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the reservation is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown if the accommodation is not available for the specified dates.</exception>
        public static bool AddReservation(Reservations reservation)
        {
            if (reservation == null)
                throw new ArgumentNullException(nameof(reservation));

            if (!IsAccommodationAvailable(reservation.AccommodationID, reservation.CheckInDate, reservation.CheckOutDate))
                throw new InvalidOperationException("The selected accommodation is not available for the specified dates.");

            try
            {
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
        /// <returns>A list of reservations loaded from the file.</returns>
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

        /// <summary>
        /// Builds a reservation object from a CSV line.
        /// </summary>
        /// <param name="line">The line containing reservation data in CSV format.</param>
        /// <returns>A reservation object.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the data format is invalid.</exception>
        private static Reservation BuildReservation(string line)
        {
            var parts = line.Split(',');

            if (parts.Length != 9)
                throw new InvalidOperationException("Invalid reservation data format. Expected 9 columns.");

            if (!Guid.TryParse(parts[0], out Guid reservationId))
                throw new InvalidOperationException("Invalid Reservation ID format.");

            if (!Guid.TryParse(parts[1], out Guid clientId))
                throw new InvalidOperationException("Invalid Client ID format.");

            string clientName = parts[2];

            if (!Guid.TryParse(parts[3], out Guid accommodationId))
                throw new InvalidOperationException("Invalid Accommodation ID format.");

            string accommodationName = parts[4];

            if (!DateTime.TryParseExact(parts[5], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime checkInDate))
                throw new InvalidOperationException("Invalid Check-in Date format.");

            if (!DateTime.TryParseExact(parts[6], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime checkOutDate))
                throw new InvalidOperationException("Invalid Check-out Date format.");

            if (!decimal.TryParse(parts[7], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal totalPrice))
                throw new InvalidOperationException("Invalid Total Price format.");

            return new Reservations(
                reservationId,
                clientId,
                clientName,
                accommodationId,
                accommodationName,
                checkInDate,
                checkOutDate,
                totalPrice,
                parts[8]
            );
        }

        /// <summary>
        /// Checks if the specified accommodation is available for the given date range.
        /// </summary>
        /// <param name="accommodationId">ID of the accommodation to check.</param>
        /// <param name="checkIn">Start date of the period.</param>
        /// <param name="checkOut">End date of the period.</param>
        /// <returns>True if the accommodation is available; otherwise, false.</returns>
        private static bool IsAccommodationAvailable(Guid accommodationId, DateTime checkIn, DateTime checkOut)
        {
            return !reservations.Any(r =>
                r.AccommodationID == accommodationId &&
                r.ReservationStatus == "Confirmed" &&
                ((checkIn >= r.CheckInDate && checkIn < r.CheckOutDate) ||
                 (checkOut > r.CheckInDate && checkOut <= r.CheckOutDate) ||
                 (checkIn <= r.CheckInDate && checkOut >= r.CheckOutDate)));
        }

        /// <summary>
        /// Validates the fields of the reservation.
        /// </summary>
        private static void ValidateFields(string clientName, string clientEmail, DateTime clientBirthDate, string clientPassword, string reservationRole)
        {
            if (string.IsNullOrWhiteSpace(clientName))
                throw new NullArgumentException("Name");

            if (string.IsNullOrWhiteSpace(clientEmail))
                throw new NullArgumentException("Email");

            if (clientBirthDate == default)
                throw new NullArgumentException("DataNascimento");

            if (string.IsNullOrWhiteSpace(clientPassword))
                throw new NullArgumentException("Password");

            if (string.IsNullOrWhiteSpace(reservationRole))
                throw new NullArgumentException("Role");
        }

        /// <summary>
        /// Gets the status of the reservation.
        /// </summary>
        /// <returns>The status of the reservation.</returns>
        public override string GetStatus()
        {
            return ReservationStatus;
        }
        #endregion
    }
}
