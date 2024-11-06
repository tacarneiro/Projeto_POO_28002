using Dados;
using Excecoes;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void LoadUsersTest()
        {
            bool result = true;
            Users.LoadUsers(out string error);

            if (error != null)
            {
                result = false;
            }


            Assert.IsTrue(result);
        }
    }
}