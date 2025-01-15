using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace _2025_01_09_TDD
{
    [TestFixture]
    internal class Test_BankAccount
    {
        BankAccount customer;
        [SetUp]
        public void SetUp()
        {
            customer = new BankAccount(2000);
        }

        [Test]
        public void BankAccount_BalanceValue()
        {
            ClassicAssert.AreEqual(customer.Balance, 2000);
        }

        [Test]
        public void BankAccount_Deposit_IncreaseBalance()
        {
            customer.Deposit(50);
            ClassicAssert.AreEqual(customer.Balance, 2050);
        }
    }
}
