using System;
using MyCalcLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyCalcLib
{
    public class MyCalc
    {
        public bool Sum(string x, char[] w, string q7)
        {
            string letter = "ABEKMHOPCTYXАВЕКМНОРСТУХ";

            if (letter.Contains(w[0]) && Char.IsDigit(w[1]) && Char.IsDigit(w[2]) && Char.IsDigit(w[3]) && letter.Contains(w[4]) && letter.Contains(w[5]) && (q7 == "11" || q7 == "22" || q7 == "33" || q7 == "44" || q7 == "55" || q7 == "111"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
