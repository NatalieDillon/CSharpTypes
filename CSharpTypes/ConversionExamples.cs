using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpTypes
{
	internal class ConversionExamples
	{
		public static void Conversions()
		{
			int intNum;
			double doubleNum;
			
			// Implicit conversion - int to double
			intNum = 10;
			doubleNum = intNum;
			Console.WriteLine($"{intNum} integer becomes {doubleNum} double.\n");

			// Implicit conversion - char to int
			char letter = 'r';
			intNum = letter;
			Console.WriteLine($"{letter} character becomes {intNum} integer.\n");

			// Explicit conversion - cast - double to int
			doubleNum = 10.25d;
			intNum = (int)doubleNum;
			Console.WriteLine($"{doubleNum} double becomes {intNum} integer.\n");			

			// Explicit conversion - convert method - double to int
			intNum = Convert.ToInt32(doubleNum);
			Console.WriteLine($"{doubleNum} double becomes {intNum} integer.\n");

			// Explicit conversion - convert method - string to int
			string stringNum = "12";
			intNum = Convert.ToInt32(stringNum);			
			Console.WriteLine($"{stringNum} string becomes {intNum} integer.\n");

			// Explicit conversion - convert method - integer to binary string
			string binString = Convert.ToString(intNum, 2);
			Console.WriteLine($"{intNum} integer becomes {binString} string in binary format.\n");

			// Explicit conversion - parse - string to double 
			stringNum = "£12.23";
			doubleNum = double.Parse(stringNum, NumberStyles.Currency); // Gives more conversion options
			Console.WriteLine($"{stringNum} string becomes {doubleNum} double.\n");

		}
	}
}
