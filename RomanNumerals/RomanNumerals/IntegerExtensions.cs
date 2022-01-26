using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RomanNumerals;

public static class IntegerExtensions
{

    private static readonly Dictionary<int, string> numeralSymbols;
    private static bool shouldBeReversed = false;

    static IntegerExtensions()
    {
        numeralSymbols = new Dictionary<int, string>()
        {
            {1, "I"},
            {5, "V"},
            {10, "X"}
        };
    }


    public static string ToRomanNumerals(this int number)
    {
        // 1, 5, 10
        if (numeralSymbols.ContainsKey(number))
        {
            return numeralSymbols[number];
        }
        
        var sb = new StringBuilder();

        for (int i = 0; i <= number; i++)
        {
            if (number != 0)
            {
                var hv = GetHighestValue(number);
                
                if (hv == 0) break;
                
                sb.Append(numeralSymbols[hv]);
                number = number - hv;
                if (number is < 0 or 1)
                {
                    sb.Append(numeralSymbols[1]);
                    i = 0;
                }
            }
        }
        
        return shouldBeReversed ? ReverseString(sb.ToString()) : sb.ToString();
    }

    private static string ReverseString(string s)
    {
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    private static int GetHighestValue(int number)
    {
        
        foreach (var symbol in numeralSymbols.Keys.Reverse())
        {
            if (number + 1 == symbol)
            {
                shouldBeReversed = true;
                return symbol;
            }

            if (number > symbol)
            {
                return symbol;
            }
        }

        return 0;
    }
}