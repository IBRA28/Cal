using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Hex
    {
        private static string Amount(string a, string b)
        {
            return (Convert.ToInt16(a, 16) + Convert.ToInt16(b, 16)).ToString("X");
        }
        private static string Substration(string a, string b)
        {
            return (Convert.ToInt16(a, 16) - Convert.ToInt16(b, 16)).ToString("X");
        }
        private static string Multiplication(string a, string b)
        {
            return (Convert.ToInt16(a, 16) * Convert.ToInt16(b, 16)).ToString("X");
        }
        private static string Division(string a, string b)
        {
            return (Convert.ToInt16(a, 16) / Convert.ToInt16(b, 16)).ToString("X");
        }
        private static string Mod(string a, string b)
        {
            return (Convert.ToInt16(a, 16) % Convert.ToInt16(b, 16)).ToString("X");
        }
        public static string Equal(string source)
        {
            var couple = source.Split('+', '*', '/', '-', '%');
            couple = couple.Select(a => a.Trim()).ToArray();
            if (source.Contains("+")) return Amount(couple[0], couple[1]);
            else if (source.Contains("-")) return Substration(couple[0], couple[1]);
            else if (source.Contains("*")) return Multiplication(couple[0], couple[1]);
            else if (source.Contains("/")) return Division(couple[0], couple[1]);
            return Mod(couple[0], couple[1]);
        }
    }
}
