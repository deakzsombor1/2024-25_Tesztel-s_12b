using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;

namespace _2024_11_28_UgyfelTeszteles
{

    [TestFixture]
    internal class Customer_teszt
    {
        Customer c;
        [SetUp]
        public void SetUp()
        {
            c = new Customer("John", "Doe", "JohnDoe@gmail.com", new DateTime(1990,05,15));
        }

        [Test]
        public void GetAge_ReturnsCorrectAge()
        {
            int age = c.GetAge();
            ClassicAssert.AreEqual(34, age);
        }

        [Test]
        public void IsEmailValid_ValidEmail_ReturnsTrue()
        {
            bool isEmailValid = c.IsEmailValid();
            ClassicAssert.IsTrue(isEmailValid);
        }

        [Test]
        public void IsEmailValid_ValidEmail_ReturnsFalse()
        {
            c.email = "valami@barmihu";
            bool isEmailValid = c.IsEmailValid();
            ClassicAssert.IsFalse(isEmailValid);
        }

        [Test]
        public void GetFullName_ReturnsCorrectFullName()
        {
            string name = c.GetFullName();
            ClassicAssert.AreEqual("John Doe", name);
        }

        [Test]
        public void Customer_Constructor_SetPropertiesCorrectly()
        {
            ClassicAssert.AreEqual("John", c.firstName);
            ClassicAssert.AreEqual("Doe", c.lastName);
            ClassicAssert.AreEqual("JohnDoe@gmail.com", c.email);
            ClassicAssert.AreEqual(new DateTime(1990,05,15), c.birthDate);
        }

        [TearDown]
        public void TearDown()
        {
            c = null;
        }

    }
}
