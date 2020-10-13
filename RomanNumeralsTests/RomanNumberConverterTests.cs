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
            
            var acutal = RomanNumberConverter.ConvertIntoRomans(input);     
            acutal.Should().Be(expected);
        }
    }
}
