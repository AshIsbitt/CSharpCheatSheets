using System;

namespace CSharpCheatSheets
{
    class Program
    {
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
            int a = 18;
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

        }
    }
}
