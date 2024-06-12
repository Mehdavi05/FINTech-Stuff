using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSumCalculator
{
    internal class Luhn
    {
        // Calculate the Luhn checksum of a given code
        public static int LuhnChecksum(string code)
        {
            int len = code.Length;
            int parity = len % 2;
            int sum = 0;

            for (int i = len - 1; i >= 0; i--)
            {
                int d = int.Parse(code[i].ToString());
                if (i % 2 == parity)
                {
                    d *= 2;
                }
                if (d > 9)
                {
                    d -= 9;
                }
                sum += d;
            }

            return sum % 10;
        }

        // Calculate the check digit for a given partial code
        public static int LuhnCalculate(string partCode)
        {
            int checksum = LuhnChecksum(partCode + "0");
            return checksum == 0 ? 0 : 10 - checksum;
        }

        // Validate the full code using the Luhn algorithm
        public static bool LuhnValidate(string fullCode)
        {
            return LuhnChecksum(fullCode) == 0;
        }

        public static (int, string, bool) CalculateCodeWithCheckSum(string partialCode)
        {
            int checkDigit = LuhnCalculate(partialCode);

            string fullCode = partialCode + checkDigit;

            bool isValid = LuhnValidate(fullCode);

            return (checkDigit, fullCode, isValid);
        }
    }
}
