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
            Console.WriteLine(phrase.Contains("World")); // Unlike, python, .contains works on strings
            
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("World")); // Return index number of given string/
            Console.WriteLine(phrase.IndexOf('W')); // Can also take a char
            Console.WriteLine(phrase.Substring(6, 9)); // Start printing from specified index (start, stop)

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

        }
    }
}
