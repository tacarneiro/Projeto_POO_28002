using Dados;
using Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
                available: true,
                image: ""
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

        [TestMethod, Priority(1)]
        public void LoadUsersTest()
        {
            bool result = Users.LoadUsers(out users);

            Assert.IsTrue(result);
        }

        [TestMethod, Priority(2)]
        public void AddUsersTest()
        {
            bool result = Users.AddUser(user);

            Assert.IsTrue(result);
        }

        [TestMethod, Priority(3)]
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


        [TestMethod, Priority(1)]
        public void LoadReservationsTest()
        {
            var loadedReservations = Reservations.LoadReservations();

            Assert.IsTrue(loadedReservations.Contains(reservation));
        }

        [TestMethod, Priority(2)]
        public void CreateReservationTest()
        {
            bool result = Reservations.AddReservation(reservation);
            Assert.IsTrue(result);

            var retrievedReservation = Reservations.FindReservationById(reservation.ReservationID);
            Assert.IsNotNull(retrievedReservation);
        }

        [TestMethod, Priority(3)]
        public void CancelReservationTest()
        {
            Reservations.CancelReservation(reservation.ReservationID);

            var retrievedReservation = Reservations.FindReservationById(reservation.ReservationID);
            Assert.IsTrue(retrievedReservation.ReservationStatus == "Canceled");
        }


        [TestMethod, Priority(1)]
        public void LoadAccommodationsTest()
        {
            var loadedAccommodations = Accommodations.LoadAccommodations();
            Assert.IsTrue(loadedAccommodations.Any());
        }

        [TestMethod, Priority(2)]
        public void CreateAccomodationTeste()
        {
            bool result = Accommodations.AddAccommodation(accommodation);
            Assert.IsTrue(result);

            var retrievedAccommodation = Accommodations.GetAllAccommodations()
                .FirstOrDefault(a => a.AccommodationID == accommodation.AccommodationID);
            Assert.IsNotNull(retrievedAccommodation);
        }

        [TestMethod, Priority(3)]
        public void UpdateAvailabilityTest()
        {
            Accommodations.UpdateAvailability(accommodation.AccommodationID, false);

            var retrievedAccommodation = Accommodations.FindAccommodationById(accommodation.AccommodationID);
            Assert.IsFalse(retrievedAccommodation.Available);
        }

        [TestMethod, Priority(4)]
        public void DeleteAccommodationTest()
        {
            Accommodations.DeleteAccommodation(accommodation.AccommodationID);

            var result = Accommodations.GetAllAccommodations()
                .FirstOrDefault(a => a.AccommodationID == accommodation.AccommodationID);
            Assert.IsNull(result);
        }
    }
}