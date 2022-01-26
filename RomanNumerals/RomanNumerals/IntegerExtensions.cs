using System;
using System.Text;

namespace RomanNumerals;

public static class IntegerExtensions
{
    public static string ToRomanNumerals(this int number)
    {
        var remainingAmount = number;
        var romanNumeral = new StringBuilder();

        if (remainingAmount >= 5)
        {
            remainingAmount -= 5;
            romanNumeral.Append('V');
        }

        while (remainingAmount > 0)
        {
            romanNumeral.Append('I');
            remainingAmount -= 1;
        }

        return romanNumeral.ToString();
    }
}