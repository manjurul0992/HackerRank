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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int count = 0;
        int level = 0;
        for (int i = 0; i < steps; i++)
        {
            if (path[i] == 'D' && level == 0)
            {
                count++;
                level--;
                continue;
            }
            if (path[i] == 'D')
                level--;
            else if (path[i] == 'U')
                level++;
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // Example usage
        //List<string> paths = new List<string> { "U","U","D","D","D","D","U","U"};
        //int steps = paths.Count;

        // Call the sockMerchant method
        int result = Result.countingValleys(8,"UUDDDDUU");

        // Print the result
        Console.WriteLine("Number of pairs: " + result);
    }
}
