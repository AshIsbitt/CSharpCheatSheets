// "using" is importing libraries - system is a default because it's the standard library
using System;

// Used for organisation, a grouping thing for multiple classes. Basically creating your own
// libraries?
namespace CSharpCheatSheets
{
    class Program
    {
    	// Static - the main method isn't going to change dynamically as the program runs
    	// void - what the method returns
    	// string[] args - a string array of arguments that the method is being passed.
        static void Main(string[] args)
        {
        	//  Variable initialisation and inline strings (f-strings)
        	string aFriend = "Liliana";
            Console.WriteLine($"Hello {aFriend}!");
			// String attributes
            Console.WriteLine($"{aFriend} is {aFriend.Length} letters long");
			// String methods
			string aFriend2 = "   Liliana   ";
			Console.WriteLine($"{aFriend2.TrimStart()}");
			Console.WriteLine($"{aFriend2.TrimEnd()}");
			Console.WriteLine($"{aFriend2.Trim()}");
			Console.WriteLine($"{aFriend2.ToUpper()}");
			Console.WriteLine($"{aFriend2.ToLower()}");

            aFriend2 = aFriend2.Replace("   ", "_");
            Console.WriteLine(aFriend2);

            // String searching
            Console.WriteLine(aFriend.Contains('L'));

            // Integer maths
            // C# uses standard BIDMAS order of operations
            int a = 10;
            int b = 6;
            int c = a+b;
            Console.WriteLine(c);

            int d = 19 + 23;
            int e = 8;
            int f = d / e;
            Console.WriteLine(f);

            // int length
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            //Double
            // long and short are both also numeric data types
            double g = 14000605;
            Console.WriteLine(g);

			double i = 19+23;
			double j = 8;
            double h = i / j;
            Console.WriteLine(h);

            // Decimals
            //The 'M' tells C# to treat it like a decimal. Otherwise, it gets seen as a double,
            //even with the 'decimal' variable type
            decimal k = 1.1M;
            decimal l = 3.3M;
            Console.WriteLine(k/l);

			//pi
            Console.WriteLine(Math.PI);

			// IF Statements
			// If there's more than one line indented under an IF/ELSE, you'll need braces
			// while a single line doesn't need them (but it's better to include them anyway)
            if (a + b  > 20) {
            	Console.WriteLine("Greater than 20");
			}
           else {
           		Console.WriteLine("Less than 20");
       		}

       		// && is AND || is OR

       		// WHILE loops
       		int counter = 0;
       		while (counter < 10) {
				Console.WriteLine($"Counter is {counter}");
				counter++;
       		}

			do {
				Console.WriteLine($"Counter is {counter}");
				counter++;
			} while (counter < 10);

			// FOR loop
			
			
        }
    }
}
