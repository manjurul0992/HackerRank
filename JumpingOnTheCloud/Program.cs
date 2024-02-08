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
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        int step = -1;
        int[] c1=c.ToArray();
        int len = c1.Length;

        for (int i = 0; i < len; i++)
        {
            if (c1[i] == 0)
            {
                step++;
                if(i< len - 1 && i< len - 2)
                {
                    if(c1[i+1] == 0 && c1[i+2]== 0)
                    {
                        c1[i + 1] = 1;
                    } 
                }
            }
        }
        return step;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        List<int> c = new List<int> { 0, 0, 1, 0, 0, 1, 0 };




        int result = Result.jumpingOnClouds(c);
        Console.WriteLine("Number of Jumps: " + result);

    }
}
