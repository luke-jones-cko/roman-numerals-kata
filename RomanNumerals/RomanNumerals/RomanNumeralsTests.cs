namespace RomanNumerals;

using FluentAssertions;
using Xunit;

public class RomanNumeralsTests
{
    [Theory]
    [InlineData(1, "I")]
    public void ToRomanNumerals(int number, string expected)
    {
        number.ToRomanNumerals().Should().Be(expected);
    }
}