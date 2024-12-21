using static Excecoes.Excecoes;

namespace Objects
{
    public abstract class Accommodation
    {
        #region Attributes
        public Guid AccommodationID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public bool Available { get; set; }
        public string Image { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Accommodation"/> class with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier of the accommodation.</param>
        /// <param name="name">The name of the accommodation.</param>
        /// <param name="type">The type of the accommodation (e.g., hotel, apartment, house).</param>
        /// <param name="location">The location of the accommodation.</param>
        /// <param name="price">The price per night for the accommodation.</param>
        /// <param name="capacity">The maximum number of guests the accommodation can host.</param>
        /// <param name="available">The availability status of the accommodation.</param>
        /// <param name="image">The image URL for the accommodation.</param>
        public Accommodation(Guid accommodationId, string name, string type, string location, decimal price, int capacity, bool available, string image)
        {
            AccommodationID = accommodationId;
            Name = name;
            Type = type;
            Location = location;
            Price = price;
            Capacity = capacity;
            Available = available;
            Image = image;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Sets the availability status of the accommodation.
        /// </summary>
        /// <param name="availability">New availability status.</param>
        public void SetAvailability(bool availability)
        {
            Available = availability;
        }

        /// <summary>
        /// Abstract method to get the availability status of the accommodation.
        /// </summary>
        /// <returns>Returns true if the accommodation is available, false otherwise.</returns>
        public abstract bool GetAvailability();
        #endregion
    }
}
