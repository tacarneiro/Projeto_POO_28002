using static Excecoes.Excecoes;
namespace Objects;

public abstract class Reservation
{
    #region Attributes
    public Guid ReservationID { get; protected set; }
    public Guid ClientID { get; protected set; }
    public string ClientName { get; protected set; }
    public Guid AccommodationID { get; protected set; }
    public string AccommodationName { get; protected set; }
    public DateTime CheckInDate { get; protected set; }
    public DateTime CheckOutDate { get; protected set; }
    public decimal TotalPrice { get; protected set; }
    public string ReservationStatus { get; protected set; }
    #endregion

    #region Properties

    #endregion

    #region Constructor
    /// <summary>
    /// Initializes a new instance of the <see cref="Reservation"/> class with the specified parameters.
    /// </summary>
    /// <param name="id">The unique identifier of the reservation.</param>
    /// <param name="clientId">The unique identifier of the client associated with the reservation.</param>
    /// <param name="clientName">The name of the client associated with the reservation.</param>
    /// <param name="accommodationId">The unique identifier of the accommodation associated with the reservation.</param>
    /// <param name="accommodationName">The name of the accommodation associated with the reservation.</param>
    /// <param name="checkInDate">The check-in date for the reservation.</param>
    /// <param name="checkOutDate">The check-out date for the reservation.</param>
    /// <param name="totalPrice">The total price for the reservation.</param>
    /// <param name="status">The current status of the reservation.</param>
    public Reservation(Guid id, Guid clientId, string clientName, Guid accommodationId, string accommodationName, DateTime checkInDate, DateTime checkOutDate, decimal totalPrice, string status)
    {
        ReservationID = id;
        ClientID = clientId;
        ClientName = clientName;
        AccommodationID = accommodationId;
        AccommodationName = accommodationName;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        TotalPrice = totalPrice;
        ReservationStatus = status;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Abstract method that should be implemented to return the reservation status.
    /// </summary>
    /// <returns>The current status of the reservation.</returns>
    public abstract string GetStatus();
    #endregion
}
