using static Excecoes.Excecoes;
namespace Objects;

public class Reservation
{
    #region Attributes
    public Guid ReservationID { get; private set; }
    public Guid ClientID { get; private set; }
    public Guid AccommodationID { get; private set; }
    public DateTime CheckInDate { get; private set; }
    public DateTime CheckOutDate { get; private set; }
    public decimal TotalPrice { get; private set; }
    public string ReservationStatus { get; private set; }
    #endregion

    #region Properties

    #endregion

    #region Constructor
    public Reservation(Guid id, Guid clientId, Guid accommodationId, DateTime checkInDate, DateTime checkOutDate, decimal totalPrice, string status)
    {
        ReservationID = id;
        ClientID = clientId;
        AccommodationID = accommodationId;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        TotalPrice = totalPrice;
        ReservationStatus = status;

        ValidateFields();
    }
    #endregion

    #region Methods
    /// <summary>
    /// Confirms the reservation, updating the status.
    /// </summary>
    public void ConfirmReservation()
    {
        ReservationStatus = "Confirmed";
    }

    /// <summary>
    /// Cancels the reservation, updating the status.
    /// </summary>
    public void CancelReservation()
    {
        ReservationStatus = "Canceled";
    }

    /// <summary>
    /// Calculates the total number of days in the reservation.
    /// </summary>
    /// <returns>Total number of days reserved.</returns>
    public int GetReservationTime()
    {
        return (CheckOutDate - CheckInDate).Days;
    }

    /// <summary>
    /// Validates the reservation by checking that the client and dates are valid.
    /// </summary>
    public void ValidateFields()
    {
        if (ClientID == Guid.Empty)
            throw new ArgumentNullException(nameof(ClientID), "Client ID cannot be empty.");

        if (AccommodationID == Guid.Empty)
            throw new ArgumentNullException(nameof(AccommodationID), "Accommodation ID cannot be empty.");

        if (CheckInDate < DateTime.Today)
            throw new ArgumentException("Check-in date cannot be in the past.");

        if (CheckOutDate <= CheckInDate)
            throw new ArgumentException("Check-out date must be after the check-in date.");

        if (TotalPrice <= 0)
            throw new ArgumentException("Total price must be greater than zero.");
    }
    #endregion
}

