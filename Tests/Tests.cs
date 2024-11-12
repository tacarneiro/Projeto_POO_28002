using Dados;
using Excecoes;
using Newtonsoft.Json.Bson;
using Objects;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        private List<User> users = new List<User>();
        private User user = null;

        [TestInitialize]
        public void Setup()
        {
            user = new User(Guid.NewGuid(), "Teste", "teste@gmail.com", new DateTime(2004,2,11), "teste123", "Client");
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
    }
}