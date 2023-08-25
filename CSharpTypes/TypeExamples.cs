using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypes
{
	public class TypeExamples
	{
		public static void DeclaringCommonNumericTypes()
		{
			double doubleNum = 10.1d;
			Console.WriteLine($"{doubleNum} is of type {doubleNum.GetType()}.\n");

			decimal decimalNum = 10.1m;
			Console.WriteLine($"{decimalNum} is of type {decimalNum.GetType()}.\n");

			int intNum = 10;
			Console.WriteLine($"{intNum} is of type {intNum.GetType()}. Min value is {int.MinValue}. Max value is {int.MaxValue}.\n");
		}

		public static void DeclaringOtherTypes()
		{
			bool boolVar = false;
			Console.WriteLine($"{boolVar} is of type {boolVar.GetType()}.\n");

			char letter = 'p';
			Console.WriteLine($"{letter} is of type {letter.GetType()}.\n");

			DateTime dateTime = DateTime.Now;
			Console.WriteLine($"{dateTime} is of type {dateTime.GetType()}\n");

			// Strings are immutable reference types
			string str = "Computing";
			Console.WriteLine($"{str} is of type {str.GetType()}\n");

			// We can use var instead of explicitly naming the type and the compiler will infer the type
			var test = true;
			Console.WriteLine($"{test} is of type {test.GetType()}.\n");
		}
	}
}
