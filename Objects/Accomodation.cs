using static Excecoes.Excecoes;

namespace Objects
{
    public class Accommodation
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
        public Accommodation(Guid id, string name, string type, string location, decimal price, int capacity, bool available, string image)
        {
            AccommodationID = id;
            Name = name;
            Type = type;
            Location = location;
            Price = price;
            Capacity = capacity;
            Available = available;
            Image = image;

            ValidateFields();
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
        /// Validate fields on Constructor.
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

        #endregion
    }
}
