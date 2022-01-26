using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RomanNumerals;

public static class IntegerExtensions
{

    private static readonly Dictionary<int, string> NumeralSymbols;
    private static bool _shouldBeReversed;

    static IntegerExtensions()
    {
        NumeralSymbols = new Dictionary<int, string>()
        {
            {1, "I"},
            {5, "V"},
            {10, "X"},
            {50, "L"}
        };
    }


    public static string ToRomanNumerals(this int number)
    {
        _shouldBeReversed = false;
        // 1, 5, 10
        if (NumeralSymbols.ContainsKey(number))
        {
            return NumeralSymbols[number];
        }
        
        var sb = new StringBuilder();

        for (int i = 0; i <= number; i++)
        {
            if (number != 0)
            {
                var hv = GetHighestValue(number);
                
                if (hv == 0) break;
                
                sb.Append(NumeralSymbols[hv]);
                number = number - hv;
                if (number is < 0 or 1)
                {
                    sb.Append(NumeralSymbols[1]);
                    i = 0;
                }
            }
        }
        
        return _shouldBeReversed ? ReverseString(sb.ToString()) : sb.ToString();
    }

    private static string ReverseString(string s)
    {
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    private static int GetHighestValue(int number)
    {
        
        foreach (var symbol in NumeralSymbols.Keys.Reverse())
        {
            if (number + 1 == symbol)
            {
                _shouldBeReversed = true;
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