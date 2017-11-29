using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class dec
    {
        private static string addition(string a, string b)

        {

            return (Convert.ToDouble(a) + Convert.ToDouble(b).ToString("X");

        }

        private static string substration(string a, string b)

        {

            return (Convert.ToDouble(a) - Convert.ToDouble(b)).ToString("X");

        }

        private static string multiplication(string a, string b)

        {

            return (Convert.ToDouble(a) * Convert.ToDouble(b)).ToString("X");

        }

        private static string divide(string a, string b)

        {

            return (Convert.ToDouble(a) / Convert.ToDouble(b)).ToString("X");

        }

        private static string Mod(string a, string b)

        {

            return (Convert.ToDouble(a) % Convert.ToDouble(b)).ToString("X");

        }

        public static string Equal(string source)

        {

            var couple = source.Split('+', '*', '/', '-', '%');

            couple = couple.Select(a => a.Trim()).ToArray();

            if (source.Contains("+")) return addition(couple[0], couple[1]);

            else if (source.Contains("-")) return substration(couple[0], couple[1]);

            else if (source.Contains("*")) return multiplication(couple[0], couple[1]);

            else if (source.Contains("/")) return divide(couple[0], couple[1]);

            return Mod(couple[0], couple[1]);



        }
    }
}
