using static Excecoes.Excecoes;
namespace Objects;

public class Reservation
{
    #region Attributes
    public Guid ReservationID { get; private set; }
    public User ClientID { get; set; }
    //public Accommodation Accommodation { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public string ReservationStatus { get; private set; }
    #endregion

    #region Properties

    #endregion

    #region Constructor
    public Reservation(User clientID, DateTime checkInDate, DateTime checkOutDate)
    {
        try
        {
            if (CheckInDate >= CheckOutDate)
                throw new ArgumentException("Check-out date must be later than check-in date.");

            ReservationID = Guid.NewGuid();
            ClientID = clientID;
            //AccommodationID = 
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            ReservationStatus = "Pending";
        }
        catch (NullArgumentException ex)
        {
            throw new Exception(ex.Message);
        }
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
    public void ValidateReservation()
    {
        if (ClientID == null)
            throw new NullArgumentException("Client cannot be null.");

        if (CheckInDate < DateTime.Today)
            throw new InvalidDateException("Check-in date cannot be earlier than today.");
    }
    #endregion
}

