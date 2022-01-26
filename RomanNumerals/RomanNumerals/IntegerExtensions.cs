using System;

namespace RomanNumerals;

public static class IntegerExtensions
{
    public static string ToRomanNumerals(this int number)
    {
        var romanNumber = "I";

        if (number == 1)
        {
            return romanNumber;
        }

        return string.Empty;
    }
}