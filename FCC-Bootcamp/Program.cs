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

            int cubedNum = Cube(5);
            Console.WriteLine(cubedNum);

            // IF statements
            bool isMale = true;
            bool isTall = true;
            
            if (isMale && isTall) // This is AND
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale || isTall) // This is OR
            {
                Console.WriteLine("You are male or tall");
            } else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }

            // Switch statement
            Console.WriteLine($"Day: {GetDay(3)}");

            // While Loops
            int index = 6;
            while (index <= 5)
            {
                 Console.WriteLine(index);
                 index++;
            }

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

            //FOR loop
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.WriteLine($"Power is: {getPower(3,2)}");

            // 2D arrays
            // Note the comma in the square brackets `int[,]`
            // You can add more dimensions with more commas
            int[,] numberGrid = {
                {1,2}, 
                {3,4}, 
                {5,6}
            };

            Console.WriteLine(numberGrid[0, 0]);

            // Exception handling with try/catch
            try {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Your answer is: {num1 / num2}");
            } catch (DivideByZeroException e){
                Console.WriteLine($"Error: {e.Message}");
            } finally {
                Console.WriteLine("This prints at the end of a TRY/EXCEPT");
            }

            // Creating objects and assigning attributes
            Book myBook = new Book("Way of Kings", "Brandon Sanderson", 1001);
            // myBook.title = "Way of Kings";
            // myBook.author = "Brandon Sanderson";
            // myBook.pageCount = 1001;

            // Printing out object attributes
            Console.WriteLine(myBook.title);
            Console.WriteLine(myBook.author);

            // Changing attributes
            myBook.title = "Words of Radiance";
            Console.WriteLine(myBook.title);

            // Working with object methods
            Student Student1 = new Student("Harry Potter", "Science", 3.8);
            Student Student2 = new Student("Ellie Winchester", "Music", 2.8);

            Console.WriteLine(Student1.HasHonors());
            Console.WriteLine(Student2.HasHonors());

            // manipulating static attributes
            Console.WriteLine(Student.studentCount);

            // Static methods - methods that are on the class, not on the object
            UsefulTools.sayHi("Jayden");

            // Inherintance
            SpecFicBook cosmere = new SpecFicBook("Mistborn", "Brandon Sanderson", 780);
            Console.WriteLine(cosmere.author);
        }

        // kCreating new methods
        static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        // Using switch statements
        static string GetDay(int dayNum) 
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid";
                    break;
            }

            return dayName;
        }
        
        static int getPower(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;   
            }

            return result;
        }
    }
}

