using System.Collections.Generic;
using NUnit.Framework;

namespace Module16.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void FindAll_Basic()
        {
            var users = new List<User>(); //moq UserRepository.FindAll()
            
            Assert.That(users.Count == 3);
            Assert.That(users[0].Name == "Антон");
            Assert.That(users[1].Name == "Иван");
            Assert.That(users[2].Name == "Алексей");
        }
    }
}