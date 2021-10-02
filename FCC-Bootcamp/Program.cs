using System;

// This basically says we're in the "FCC-Bootcamp" project
namespace FCC_Bootcamp
{
    // A container we can store code in
    class Program
    {
        // Method/function
        static void Main(string[] args)
        {
            // Always end code with a semicolon - it's annoying
            Console.WriteLine("Hello World!\n");

            //Variables
            string characterName = "John";
            int characterAge = 35;

            Console.WriteLine("There one was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He liked the name John");
            Console.WriteLine("But he didn't like being 35");

            // Data types
            string phrase = "Hello World";
            // char grade = 'C';
            int wholeNumber = 69; // _Nice_
            // float gpa = 3.2;
            // double money = 56.20;
            // decimal notWholeNum = 123.2M;
            //  bool isWorking = true;

            // String methods
            Console.WriteLine(phrase.Length); // This is an attribute, not a method
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("World"));
 			// Unlike, python, .contains works on strings

            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("World")); // Return index number of given string/
            Console.WriteLine(phrase.IndexOf('W')); // Can also take a char
            Console.WriteLine(phrase.Substring(6)); // Start printing from specified index (start, stop)

            // Working with numbers
            Console.WriteLine(wholeNumber);
            Console.WriteLine(wholeNumber + 1); // Inline maths
            wholeNumber++;
            wholeNumber--; // Shorthand adding and subtracting 1
            Console.WriteLine(5 / 2); // This will return an int, not a float

            Console.WriteLine(Math.Pow(3, 2)); // This'll do 3^2
            Console.WriteLine(Math.Sqrt(6)); // Square root method
            Console.WriteLine(Math.Max(12, 69)); // Which number is higher. Math.Min also exists
            Console.WriteLine(Math.Round(4.3)); // Rounding

            Console.WriteLine("-------------");
            // Working with input
            // Console.Write("Enter name: "); //WriteLine always ends in a \n, Write does not
            // string name = Console.ReadLine();
			// Console.Write("Enter age: ");
			// string age = Console.ReadLine();
            // Console.WriteLine($"Hello {name}. You are {age} years old");

			//String > int conversion
			// Convert has a bunch of methods for different data types
			int newNum = Convert.ToInt32("45");
            Console.WriteLine(newNum);
            System.Type type = newNum.GetType();
            Console.WriteLine(type);

            // Addition calculator via input
            // Console.Write("Enter a number: ");
            // double num1 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Enter a second number: ");
            // double num2 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine($"Your answer is: {num1+num2}");

            // Arrays
            int[] luckyNumbers = {4, 1, 65, 23, 43};
            //Easy way to print out a whole array in one line
            Console.WriteLine(string.Join(',', luckyNumbers)); 
            Console.WriteLine(luckyNumbers[0]);
            luckyNumbers[0] = 900;
            Console.WriteLine(luckyNumbers[0]);

            // An empty string array. It still needs to be told how big the array should be though
            // 0-2 is 3 items, so I've told the array to make 3 spaces. `new string[2]` would give
            // a IndexOutOfRangeException error on `friends[2] = "Joe"` too.
            string[] friends = new string[3];
            friends[0] = "Isla";
            friends[1] = "Connor";
            friends[2] = "Joe";
            //friends[3] = "Rowan"; System.IndexOutOfRangeException because too many items in array

            // Calling methods
            SayHi("Liliana");
            SayHi("Elle");
            SayHi("Linus");
        }

        // Creating new methods
        static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
