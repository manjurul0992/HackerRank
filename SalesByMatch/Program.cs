using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        int pair = 0;
        int max = ar.Max() + 1;
        for (int i = 0; i < n; i++)
        {
            if (ar[i] == max)
                continue;
            for (int j = i + 1; j < n; j++)
            {
                if (ar[i] == ar[j])
                {
                    ar[i] = max;
                    ar[j] = max;
                    pair++;
                    break;
                }
            }
        }
        return pair;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // Example usage
        List<int> socks = new List<int> { 1, 2, 1, 2, 1, 3, 2 };
        int n = socks.Count;

        // Call the sockMerchant method
        int result = Result.sockMerchant(n, socks);

        // Print the result
        Console.WriteLine("Number of pairs: " + result);
    }
}

