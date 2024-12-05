using Dados;
using Objects;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        private List<User> users = new List<User>();
        private User user = null;
        private Accommodation accommodation = null;
        private Reservation reservation = null;

        [TestInitialize]
        public void Setup()
        {
            user = new User(
                id: Guid.NewGuid(), 
                name: "Teste", 
                email: "teste@gmail.com", 
                dataNascimento: new DateTime(2004,2,11), 
                password: "teste123", 
                role: "Client"
            );
            
           accommodation = new Accommodation( 
                id: Guid.NewGuid(),
                name: "Beachside Villa",
                type: "Villa",
                location: "Miami Beach",
                price: 250.00m,
                capacity: 6,
                available: true
            );

            reservation = new Reservation(
                id: Guid.NewGuid(),
                clientId: user.Id,
                accommodationId: accommodation.AccommodationID,
                checkInDate: DateTime.Now.AddDays(1),
                checkOutDate: DateTime.Now.AddDays(7),
                totalPrice: 1750.00m,
                status: "Confirmed"
            );
        }

        [TestMethod]
        public void LoadUsersTest()
        {
            bool result = Users.LoadUsers(out users);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddUsersTest()
        {
            bool result = Users.AddUser(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpdateUsersTest()
        {
            // Fazer
        }

        [TestMethod]
        public void RemoveUsersTest()
        {
            //Users.DeleteUser(user.Id);

            //var result = Users.GetUsers().FirstOrDefault(u => u.Id == user.Id);
            //Assert.IsNull(result);
        }


        [TestMethod]
        public void LoadReservationsTest()
        {
            var loadedReservations = Reservations.LoadReservations();

            Assert.IsTrue(loadedReservations.Contains(reservation));
        }

        [TestMethod]
        public void CreateReservationTest()
        {
            bool result = Reservations.AddReservation(reservation);
            Assert.IsTrue(result);

            var retrievedReservation = Reservations.FindReservationById(reservation.ReservationID);
            Assert.IsNotNull(retrievedReservation);
        }

        [TestMethod]
        public void CancelReservationTest()
        {
            Reservations.CancelReservation(reservation.ReservationID);

            var retrievedReservation = Reservations.FindReservationById(reservation.ReservationID);
            Assert.IsTrue(retrievedReservation.ReservationStatus == "Canceled");
        }


        [TestMethod]
        public void LoadAccommodationsTest()
        {
            var loadedAccommodations = Accommodations.LoadAccomodations();
            Assert.IsTrue(loadedAccommodations.Any());
        }

        [TestMethod]
        public void CreateAccomodationTeste()
        {
            bool result = Accommodations.AddAccommodation(accommodation);
            Assert.IsTrue(result);

            var retrievedAccommodation = Accommodations.GetAllAccommodations()
                .FirstOrDefault(a => a.AccommodationID == accommodation.AccommodationID);
            Assert.IsNotNull(retrievedAccommodation);
        }

        [TestMethod]
        public void DeleteAccommodationTest()
        {
            Accommodations.DeleteAccommodation(accommodation.AccommodationID);

            var result = Accommodations.GetAllAccommodations()
                .FirstOrDefault(a => a.AccommodationID == accommodation.AccommodationID);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void UpdateAvailabilityTest()
        {
            Accommodations.UpdateAvailability(accommodation.AccommodationID, false);

            var retrievedAccommodation = Accommodations.FindAccommodationById(accommodation.AccommodationID);
            Assert.IsFalse(retrievedAccommodation.Available);
        }
    }
}