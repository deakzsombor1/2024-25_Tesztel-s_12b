using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;
using System.Runtime.InteropServices;

namespace _2024_12_06_UgyfelosztalyEsTesztelese
{
    [TestFixture]
    internal class CustomersTests
    {
        List<Customer> customers;
        [SetUp]
        public void SetUp()
        {
            customers = new List<Customer>{
                new Customer("John", "Doe", "JohnDoe@gmail.com", new DateTime(1990, 5, 15)),
                new Customer("Jane", "Smith", "janesmith@example.com",new DateTime(1985, 8, 22)),
                new Customer("Alice", "Johnson", "alicejohnson@example.com", new DateTime(1992, 11, 3)),
                new Customer("Bob", "Brown", "bobbrown@example.com", new DateTime(1980, 2, 10)),
                new Customer("Charlie", "Davis", "charliedavis@example.com", new DateTime(1995, 7, 25)),
                new Customer("Emily", "Miller", "emilymiller@example.com", new DateTime(1988, 12, 12))
            };
        }
        [TestCase(34, 0)]
        [TestCase(39, 1)]
        [TestCase(32, 2)]
        [TestCase(44, 3)]
        [TestCase(29, 4)]
        [TestCase(36, 5)]
        public void GetAge_ReturnsCorrectAges(int expectAge, int index)
        {
            int age = customers[index].GetAge();
            ClassicAssert.AreEqual(expectAge,age);
        }

        [TestCase( 0)]
        [TestCase( 1)]
        [TestCase( 2)]
        [TestCase( 3)]
        [TestCase( 4)]
        [TestCase( 5)]
        public void IsEmailValid_ValidEmails_ReturnsTrue(int index)
        {
            bool isEmailValid = customers[index].IsEmailValid();
            ClassicAssert.IsTrue(isEmailValid);
        }

        [TestCaseSource(nameof(Test_ReturnsAges))]
        public void GetAge_ReturnsCorrectAges_Source(int expectAge, int index)
        {
            int age = customers[index].GetAge();
            ClassicAssert.AreEqual(expectAge, age);
        }


        public static IEnumerable<TestCaseData> Test_ReturnsAges()
        {
            yield return new TestCaseData(34,0);
            yield return new TestCaseData(39,1);
            yield return new TestCaseData(32,2);
            yield return new TestCaseData(44,3);
            yield return new TestCaseData(29,4);
            yield return new TestCaseData(36,5);
        }

        private static int FuggvenyMeghivase()
        {
            return 34;
        }
    }
}
