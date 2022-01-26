namespace RomanNumerals;

using FluentAssertions;
using Xunit;

public class RomanNumeralsTests
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    [InlineData(10, "X")]
    [InlineData(11, "XI")]
    public void ToRomanNumerals(int number, string expected)
    {
        number.ToRomanNumerals().Should().Be(expected);
    }
}