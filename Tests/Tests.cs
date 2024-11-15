using Dados;
using Objects;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        private List<User> users = new List<User>();
        private User user = null;
        private Accommodations accommodation = null;

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
            
            
           accommodation = new Accommodations( 
                name: "Beachside Villa",
                type: "Villa",
                location: "Miami Beach",
                price: 250.00m,
                capacity: 6
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
        public void UpdateUsersTeste()
        {
            // Fazer
        }

        [TestMethod]
        public void RemoveUsersTeste()
        {
            // Fazer
        }

        [TestMethod]
        public void CreateReservation()
        {
            // Fazer
        }

        [TestMethod]
        public void LoadAccommodation()
        {
            // Fazer
        }

        [TestMethod]
        public void CreateAccomodation()
        {
            // Fazer
        }
    }
}