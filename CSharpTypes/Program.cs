namespace CSharpTypes
{
	internal class Program
	{
		static void Main()
		{
			//TypeExamples.DeclaringCommonNumericTypes();	
			//TypeExamples.DeclaringOtherTypes();
			ConversionExamples.Conversions();
			//UserInputExample();
		}

		static void UserInputExample()
		{
			Console.WriteLine("Please enter your age:");
			string? userAge = Console.ReadLine();  // The ? signifies that the value can be null (unspecified)
			Console.WriteLine($"Your age is {userAge}");
			int age = int.Parse(userAge ?? string.Empty);
			Console.WriteLine($"Your age doubled is {age*2}");
		}
	

	}
}