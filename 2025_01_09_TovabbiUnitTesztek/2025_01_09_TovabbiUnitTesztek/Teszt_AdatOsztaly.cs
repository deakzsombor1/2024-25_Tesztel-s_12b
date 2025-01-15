using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Diagnostics;

namespace _2025_01_09_TovabbiUnitTesztek
{
    [TestFixture]
    internal class Teszt_AdatOsztaly
    {
        AdatOsztaly peldany;
        [SetUp]
        public void Setup()
        {
            peldany = new AdatOsztaly();
        }

        [Test]
        public void AdatOsztaly_Osszesites()
        {
            int n = 10000;
            var ido = Stopwatch.StartNew();
            int osszeg = peldany.Osszegez1tolNig(n);
            ido.Stop();
            ClassicAssert.LessOrEqual(ido.ElapsedMilliseconds, 50);
        }

        [Test]
        public void AdatOsztaly_IsValidString()
        {
            bool valasz = peldany.IsValidString(null);
            ClassicAssert.IsFalse(valasz);
        }

        [Test]
        public void AdatOsztaly_IsValidString_Empty()
        {
            bool valasz = peldany.IsValidString("");
            ClassicAssert.IsFalse(valasz);
        }

        [TestCase("a")]
        [TestCase("b")]
        public void AdatOsztaly_ValidString_String(string input)
        {
            bool valasz = peldany.IsValidString(input);
            ClassicAssert.IsTrue(valasz);
        }

        [TearDown]
        public void Teardown()
        {
            peldany = null;
        }
    }
}
