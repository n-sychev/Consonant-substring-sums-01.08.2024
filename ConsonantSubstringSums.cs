using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Function;

internal class ConsonantSubstringSums
{
    public static int FindMaxConsonantSubstring(string input)
    {
        int maxSum = 0;

        int currentSum = 0;


        foreach (char symbol in input.ToLower())
        {
            if ("aeiou".Contains(symbol))
            {
                maxSum = Math.Max(maxSum, currentSum);
                currentSum = 0;
            }
            else
            {
                currentSum += symbol % 32;
            }
        }

        return Math.Max(maxSum, currentSum);
    } 
}