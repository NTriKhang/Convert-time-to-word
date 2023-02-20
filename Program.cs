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
     * Complete the 'timeInWords' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER h
     *  2. INTEGER m
     */

	public static string timeInWords(int h, int m)
	{
		string s = "";
		string[] wordArray = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten",
				"eleven", "twelve", "thirteen", "fourteen", "quarter", "sixteen", "seventeen","eighteen", "nineteen","twenty",
				"twenty one","twenty two","twenty three","twenty four","twenty five","twenty six","twenty seven","twenty eight","twenty nine","half" };
		s = (m > 1 && m < 30 && m != 15) ? wordArray[m - 1] + " minutes past " + wordArray[h - 1]
			: (m == 1) ? wordArray[m - 1] + " minute past " + wordArray[h - 1]
			: (m == 15 || m == 30) ? wordArray[m - 1] + " past " + wordArray[h - 1]
			: (m > 30 && (60 - (m + 1)) > 0 && m != 45) ? wordArray[60 - (m + 1)] + " minutes to " + wordArray[h]
			: (m > 30 && (60 - (m + 1)) == 0) ? wordArray[60 - (m + 1)] + " minute to " + wordArray[h]
			: (m == 45) ? wordArray[60 - (m + 1)] + " to " + wordArray[h]
			: wordArray[h - 1] + " o' clock";
		return s;
	}

}

class Solution
{
	public static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int h = Convert.ToInt32(Console.ReadLine().Trim());

		int m = Convert.ToInt32(Console.ReadLine().Trim());

		string result = Result.timeInWords(h, m);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}
