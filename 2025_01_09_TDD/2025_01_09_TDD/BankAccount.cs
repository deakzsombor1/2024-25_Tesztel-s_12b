using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_09_TDD
{
    internal class BankAccount
    {
        public int Balance { get; set; }
        public BankAccount(int balance) 
        {
            Balance = balance;
        }

        public void Deposit(int value)
        {
            Balance += value;
        }
    }
}
