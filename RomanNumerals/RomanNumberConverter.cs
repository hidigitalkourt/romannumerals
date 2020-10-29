using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace RomanNumerals
{
    public class RomanNumberConverter
    {
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
            var romanNumeralList = new List<string>();
            if (numbers.ToString().Length == 1)
            {
                return RomanLookUp[numbers];
            }
            else if (numbers.ToString().Length == 2)
            { 
                var firstNum = Math.Floor((double)numbers/10) * 10;  
                var remainder = numbers % firstNum;
                romanNumeralList.Add(RomanLookUp[(int)firstNum]);
                romanNumeralList.Add(RomanLookUp[(int)remainder]);
            }
            else if (numbers.ToString().Length == 3)
            {
                var first = Math.Floor((double)numbers/100) * 100;
                var second = Math.Floor((double)(numbers % first)/10) * 10;
                var third = numbers % (first + second);
                romanNumeralList.Add(RomanLookUp[(int)first]);
                romanNumeralList.Add(RomanLookUp[(int)second]);
                romanNumeralList.Add(RomanLookUp[(int)third]);
            }
            else
            {
                var first = Math.Floor((double)numbers/1000) * 1000;
                var second = Math.Floor((double)(numbers % first)/100) * 100;
                var third = Math.Floor((double)(numbers % (first + second))/10) * 10;
                var fourth = numbers % (first + second + third);
                romanNumeralList.Add(RomanLookUp[(int)first]);
                romanNumeralList.Add(RomanLookUp[(int)second]);
                romanNumeralList.Add(RomanLookUp[(int)third]);
                romanNumeralList.Add(RomanLookUp[(int)fourth]);
            }
            Console.WriteLine(JsonConvert.SerializeObject(romanNumeralList));

            return string.Join("", romanNumeralList);

        }
    }
}
