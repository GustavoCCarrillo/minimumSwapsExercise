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

class Solution
{

    // HACKERRANK CHALLENGE - minimumSwap exercise 
    static int minimumSwaps(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int currentVal = arr[i];
            while (currentVal != i + 1)
            {
                int temp = arr[currentVal - 1];
                arr[currentVal - 1] = currentVal;
                currentVal = temp;
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}