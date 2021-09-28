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
        }
    }
}
