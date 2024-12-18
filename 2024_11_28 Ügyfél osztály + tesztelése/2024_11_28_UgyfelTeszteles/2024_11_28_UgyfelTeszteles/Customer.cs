using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_28_UgyfelTeszteles
{
    internal class Customer
    {
        public string firstName, lastName, email;
        public DateTime birthDate;

        public Customer(string fn, string ln, string email, DateTime bd)
        {
            firstName = fn;
            lastName = ln;
            this.email = email;
            birthDate = bd;
        }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.AddYears(age) > today.Date) age--;
            return age;
        }

        public bool IsEmailValid()
        {
            string[] emailParts = email.Split('@');
            if (emailParts.Length == 2)
            {
                string[] domain = emailParts[1].Split('.');
                if(OnlyNumbersLetters(emailParts[0]) && domain.Length == 2)
                {
                    if (OnlyLetters(domain[0]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool OnlyNumbersLetters(string sz)
        {
            int i = 0;
            while(i < sz.Length && (char.IsDigit(sz[i]) || char.IsLetter(sz[i])))
            {
                i++;
            }
            return i >= sz.Length;
        }

        private bool OnlyLetters(string sz)
        {
            int i = 0;
            while (i < sz.Length && char.IsLetter(sz[i]))
            {
                i++;
            }
            return i >= sz.Length;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
