using System;
using FluentAssertions;
using Xunit;

namespace RomanNumeralsTests
{
    public class RomanNumeralsTests
    {
        [Fact]
        public void ReturnZeroFortheNoLetters()
        {
            var input = "";
            var expected = 0;
            
            var acutal = RomanNumerals.RomanLetters.ConvertIntoNumbers(input);     
            acutal.Should().Be(expected);
                
        }
    }
}
