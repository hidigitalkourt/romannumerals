using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace RomanNumerals
{
    public class RomanNumberConverter
    {
        private int remainder;
        private List<string> romanNumeralList = new List<string>();
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
        public string ConvertIntoRomans(int numbers)
        {             
            var numberLength = numbers.ToString().Length;
            var thousandsPlaceRounding = Math.Floor((double)numbers/1000) * 1000;
        
            if (RomanLookUp.ContainsKey(numbers))
            {
                romanNumeralList.Add(RomanLookUp[(int)numbers]);
            }
            else if (numberLength == 2)
            { 
                remainder = numbers % (placeRounding(numbers, 10) * 10);
                romanNumeralList.Add(RomanLookUp[(placeRounding(numbers, 10) * 10)]);
                ConvertIntoRomans(remainder);
            }
            else if (numberLength == 3)
            {
                remainder = numbers % (placeRounding(numbers, 100) * 100);
                romanNumeralList.Add(RomanLookUp[(placeRounding(numbers, 100) * 100)]);
                ConvertIntoRomans(remainder);
            }
            else
            {
                remainder = numbers % (placeRounding(numbers, 1000) * 1000);
                romanNumeralList.Add(RomanLookUp[(placeRounding(numbers, 1000) * 1000)]);
                ConvertIntoRomans(remainder);
            }
            return string.Join("", romanNumeralList);
        }

        private int placeRounding(int num, int divisor)
        {
            return (int)Math.Floor((double)num/divisor);
        }
    }
}
