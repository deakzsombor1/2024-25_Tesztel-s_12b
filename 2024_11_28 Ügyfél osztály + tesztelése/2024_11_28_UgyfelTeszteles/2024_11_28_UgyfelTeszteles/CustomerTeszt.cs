﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;
using NUnit.Framework.Internal;

namespace _2024_11_28_UgyfelTeszteles
{
    [TestFixture]
    internal class CustomerTeszt
    {
        List<Customer> customers;
        [SetUp]
        public void SetUp()
        {
            customers = new List<Customer>
            {
                new Customer("John", "Doe", "JohnDoe@gmail.com", new DateTime(1990, 05, 15)),
                new Customer("Jane", "Smith", "janesmith@example.com", new DateTime(1985, 08, 22)),
                new Customer("Alice", "Johnson", "alicejohnson@example.com", new DateTime(1992, 11, 03)),
                new Customer("Bob", "Brown", "bobbrown@example.com", new DateTime(1995, 07, 25)),
                new Customer("Emily", "Miller", "emilymiller@example.com", new DateTime(1998, 12, 12))
            };
        }

        [TestCase(34, 0)]
        [TestCase(39, 1)]
        [TestCase(32,2)]
        [TestCase(44, 3)]
        [TestCase(29, 4)]
        public void GetAge_ReturnsCorrectAges(int expectAge, int index)
        {
            int age = customers[index].GetAge();
            ClassicAssert.AreEqual(expectAge, age);
        }

        [TestCase( 0)]
        [TestCase( 1)]
        [TestCase( 2)]
        [TestCase( 3)]
        [TestCase( 4)]
        public void IsEmailValid_ValidEmails_ReturnsTrue(int index)
        {
            bool IsEmailValid = customers[index].IsEmailValid();
            ClassicAssert.IsTrue(IsEmailValid);
        }

        [TestCaseSource(nameof(Test_ReturnsAges))]
        public void GetAge_ReturnsCorrectAges_Source(int expectAge, int index)
        {
            int age = customers[index].GetAge();
            ClassicAssert.AreEqual (expectAge, age);
        }


        public static IEnumerable<TestCaseData> Test_ReturnsAges()
        {
            int valami = FuggvenyMeghivase();
            yield return new TestCaseData(34, 0);
            yield return new TestCaseData(39, 1);
            yield return new TestCaseData(32, 2);
            yield return new TestCaseData(44, 3);
            yield return new TestCaseData(29, 4);
            yield return new TestCaseData(36, 5);
        }

        private static int FuggvenyMeghivase()
        {
            return 34;
        }
    }
}
