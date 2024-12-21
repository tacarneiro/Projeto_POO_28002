using Dados;
using Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        private List<Users> users = new List<Users>();
        private Users user = null;
        private Accommodations accommodation = null;
        private Reservations reservation = null;

        [TestInitialize]
        public void Setup()
        {
            user = new Users(
                id: Guid.NewGuid(), 
                name: "Teste", 
                email: "teste@gmail.com", 
                dataNascimento: new DateTime(2004,2,11), 
                password: "teste123", 
                role: "Client"
            );
            
           accommodation = new Accommodations(
                accommodationId: Guid.NewGuid(),
                name: "Beachside Villa",
                type: "Villa",
                location: "Miami Beach",
                price: 250.00m,
                capacity: 6,
                available: true,
                image: ""
            );

            reservation = new Reservations(
                reservationId: Guid.NewGuid(),
                clientId: user.Id,
                clientName: user.Name,
                accommodationId: accommodation.AccommodationID,
                accommodationName: accommodation.Name,
                checkInDate: DateTime.Now.AddDays(1),
                checkOutDate: DateTime.Now.AddDays(7),
                totalPrice: 1750.00m,
                reservationStatus: "Confirmed"
            );
        }

        [TestMethod]
        public void LoadUsersTest()
        {
            //bool result = Users.LoadUsers(out users);

            //Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddUsersTest()
        {
            bool result = Users.AddUser(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LoadReservationsTest()
        {
            var loadedReservations = Reservations.LoadReservations();

            Assert.IsTrue(loadedReservations.Contains(reservation));
        }
    }
}