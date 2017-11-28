using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Hex
    {
        public static string Amount(string a, string b)
        {
            return (Convert.ToInt16(a, 16) + Convert.ToInt16(b, 16)).ToString("X");
        }
        public static string Substration(string a, string b)
        {
            return (Convert.ToInt16(a, 16) - Convert.ToInt16(b, 16)).ToString("X");
        }
        public static string Multiplication(string a, string b)
        {
            return (Convert.ToInt16(a, 16) * Convert.ToInt16(b, 16)).ToString("X");
        }
        public static string Division(string a, string b)
        {
            return (Convert.ToInt16(a, 16) / Convert.ToInt16(b, 16)).ToString("X");
        }
        public static string Mod(string a, string b)
        {
            return (Convert.ToInt16(a, 16) % Convert.ToInt16(b, 16)).ToString("X");
        }
    }
}
