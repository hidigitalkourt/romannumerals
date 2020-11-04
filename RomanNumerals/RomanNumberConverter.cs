using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace RomanNumerals
{
    public class RomanNumberConverter
    {
        private int remainder;
        private string romanNumeral;
        public Dictionary<int, string> RomanLookUp = new Dictionary<int, string>()
        { 
            {0, "" },
            {1, "I" },
            {2, "II" },
            {3, "III" },
            {4, "IV" },
            {5, "V" },
            {6, "VI" },
            {7, "VII" },
            {8, "VIII" },
            {9, "IX"  },
            {10, "X" },
            {20, "XX" },
            {30, "XXX" },
            {40, "XL" },
            {50, "L" },
            {60, "LX" },
            {70, "LXX" },
            {80, "LXXX" },
            {90, "XC" },
            {100, "C" },
            {200, "CC" },
            {300, "CCC" },
            {400, "CD" },
            {500, "D" },
            {600, "DC" },
            {700, "DCC" },
            {800, "DCCC" },
            {900, "CM" },
            {1000, "M" },
            {2000, "MM" },
            {3000, "MMM" },
            {4000, "MMMM"}
        };
        public string ConvertIntoRomans(int number)
        {             
            var numberLength = number.ToString().Length;
        
            if (RomanLookUp.ContainsKey(number))
            {
                romanNumeral += RomanLookUp[(int)number];
            }
            else if (numberLength == 2)
            { 
                remainder = GetRemainder(number, 10);
                romanNumeral += GetRomanNumeral(number, 10);
                ConvertIntoRomans(remainder);
            }
            else if (numberLength == 3)
            {
                remainder = GetRemainder(number, 100);
                romanNumeral += GetRomanNumeral(number, 100);
                ConvertIntoRomans(remainder);
            }
            else
            {
                remainder = GetRemainder(number, 1000);
                romanNumeral += GetRomanNumeral(number, 1000);
                ConvertIntoRomans(remainder);
            }
            return romanNumeral;
        }

        private string GetRomanNumeral(int num, int divisor)
        {
            return RomanLookUp[((int)Math.Floor((double)num/divisor) * divisor)];
        }
        private int GetRemainder(int num, int divisor)
        {
            return num % ((int)Math.Floor((double)num/divisor) * divisor);
        }
    }
}
