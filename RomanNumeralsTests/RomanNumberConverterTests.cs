using System;
using FluentAssertions;
using RomanNumerals;
using Xunit;

namespace RomanNumeralsTests
{
    public class RomanNumberConverterTests
    {
        [Fact]
        public void ReturnZeroFortheNoLetters()
        {
            var input = 0;
            var expected = "";
            
            var acutal = new RomanNumberConverter().ConvertIntoRomans(input);     
                acutal.Should().Be(expected);
        }
    

        [Theory]
        [InlineData("I", 1)]
        [InlineData("XLVII", 47)]
        [InlineData("CXCIX", 199)]
        [InlineData("MCMXC", 1990)]
        [InlineData("MMVIII", 2008)]

        public void ReturnCorrertNumberForLetters(
            string letters, 
            int number
        )
        {
            var acutal = new RomanNumberConverter().ConvertIntoRomans(number);     
            acutal.Should().Be(letters);
        }
    }
}
