using FluentAssertions;
using Xunit;

namespace RomanNumerals;

public class RomanNumeralsTests
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(5, "V")]
    public void ToRomanNumeralsTest(int number, string expected)
    {
        number.ToRomanNumerals().Should().Be(expected);
    }
}