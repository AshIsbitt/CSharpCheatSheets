// "using" is importing libraries - system is a default because it's the standard library
using System;
using System.Collections.Generic;

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
			for (int index = 0; index < 10; index++) {
				Console.WriteLine($"Index is {index}");
			}

			//Loops and conditionals combined
			int sum = 0;

			for (int m = 1; m <= 20; m++) {
				if (m % 3 == 0) {
					sum += m;
				}
			}

			Console.WriteLine($"The sum is {sum}");

			// Arrays, Lists, Collections
			// Needs System.Collections.Generic;

			// "var" is a generic varaible initialisation type, it's better to be explicit though
			var names = new List<string> {"Faye", "Connor"};
			names.Add("Tom");
			names.Add("Renee");
			names.Remove("Connor");

			// foreach takes each item in a list and iterates through them automatically
			foreach (var name in names) {
				Console.WriteLine($"Hello {name.ToUpper()}!");
			}

			Console.WriteLine(names[0]);

			// List manipulation
			// If an item doesn't exist, IndexOf returns -1
			Console.WriteLine($"Found Faye at {names.IndexOf("Faye")}");

			Console.WriteLine(string.Join(", ", names));
			names.Sort();
			Console.WriteLine(string.Join(", ", names));

			// List of other Types
			var fibNums = new List<int> {1, 1};

			while (fibNums.Count < 20) {
				var prev = fibNums[fibNums.Count - 1];
				var prev2 = fibNums[fibNums.Count - 2];

				fibNums.Add(prev + prev2);
			}

			foreach (var item in fibNums) {
				Console.WriteLine(item);
			}
        }
    }
}
