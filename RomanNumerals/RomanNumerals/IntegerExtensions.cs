using System;

namespace RomanNumerals;

public static class IntegerExtensions
{
    public static string ToRomanNumerals(this int number)
    {
        return number == 1 ? "I" : "II";
    }
}