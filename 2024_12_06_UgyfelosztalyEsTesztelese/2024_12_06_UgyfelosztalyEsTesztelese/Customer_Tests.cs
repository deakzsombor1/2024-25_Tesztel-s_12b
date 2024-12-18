using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace _2024_12_06_UgyfelosztalyEsTesztelese
{
    [TestFixture]
    internal class Customer_Tests
    {
        Customer customer;
        [SetUp]
        public void SetUp()
        {
            customer = new Customer("John", "Doe", "JohnDoe@gmail.com", new DateTime(1990, 05, 15));
        }

        [Test]
        public void GetAge_ReturnsCorrectAge()
        {
            int age = customer.GetAge();
            ClassicAssert.AreEqual(34, age);
        }

        [Test]
        public void IsEmailValid_ValidEmail_ReturnsTrue()
        {
            bool isEmailValid = customer.IsEmailValid();
            //ClassicAssert.AreEqual(true, isEmailValid);
            ClassicAssert.IsTrue(isEmailValid);
        }

        [Test]
        public void IsEmailValid_inValidEmail_ReturnsFalse()
        {
            customer.email = "valami@barmihu";
            bool isEmailValid = customer.IsEmailValid();
            //ClassicAssert.AreEqual(false, isEmailValid);
            ClassicAssert.IsFalse(isEmailValid);
        }

        [Test]
        public void GetFullName_ReturnsCorrectFullName()
        {
            string name = customer.GetFullName();
            ClassicAssert.AreEqual("John Doe", name);
        }

        [Test]
        public void Customer_Constructor_SetsPropertiesCorrectly()
        {
            ClassicAssert.AreEqual("John", customer.firstName);
            ClassicAssert.AreEqual("Doe", customer.lastName);
            ClassicAssert.AreEqual("JohnDoe@gmail.com", customer.email);
            ClassicAssert.AreEqual(new DateTime(1990,05,15), customer.birthDate);
        }


        [TearDown]
        public void TearDown()
        {
            customer = null;
        }
    }
}
