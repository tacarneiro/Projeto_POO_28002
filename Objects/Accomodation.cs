using static Excecoes.Excecoes;

namespace Objects
{
    public class Accommodations
    {
        #region Attributes
        public Guid AccommodationID { get; private set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public bool Available { get; private set; }
        #endregion

        #region Constructor
        public Accommodations(string name, string type, string location, decimal price, int capacity)
        {
            ValidateFields(name, type, location, price, capacity);

            AccommodationID = Guid.NewGuid();
            Name = name;
            Type = type;
            Location = location;
            Price = price;
            Capacity = capacity;
            Available = true;
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
        private static void ValidateFields(string name, string type, string location, decimal price, int capacity)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Name cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentNullException(nameof(type), "Type cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(location))
                throw new ArgumentNullException(nameof(location), "Location cannot be null or empty.");

            if (price <= 0)
                throw new ArgumentException("Price per night must be greater than zero.", nameof(price));

            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.", nameof(capacity));
        }

        #endregion
    }
}
