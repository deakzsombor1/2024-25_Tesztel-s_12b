using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_09_TovabbiUnitTesztek
{
    internal class AdatOsztaly
    {
        public int Osszegez1tolNig(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += i;
            }
            return sum;
        }

        /*A szöveg hossza [1,255]*/
        public bool IsValidString(string input)
        {
            if(input == null) return false;
            if(input.Length < 1 || input.Length > 255) 
                return false;
            return true;
        }
    }
}
