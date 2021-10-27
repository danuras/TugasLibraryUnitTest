using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    class UserTest
    {
        User user;
        [SetUp]
        public void Init()
        {
            user = new User();
        }
        [Test]
        public void IsValidUserTest()
        {
            Assert.AreEqual(true, user.IsValidUser("admin", "admin"));
            Assert.AreEqual(false, user.IsValidUser("nimda", "nimda"));
        }
    }
}
