using System;

namespace cSharpCourseByDerekBanas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Before");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Intermediate");
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.WriteLine("After");

            //Console.Write("What is your name? ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}");

            /*
            bool canITalk = true;
            Console.WriteLine("Biggest integer: {0}", int.MaxValue);
            Console.WriteLine("Smallest integer: {0}", int.MinValue);

            Console.WriteLine("Biggest long: {0}", long.MaxValue);
            Console.WriteLine("Smallest long: {0}", long.MinValue);

            Console.WriteLine("Biggest decimal: {0}", decimal.MaxValue);
            Console.WriteLine("Smallest decimal: {0}", decimal.MinValue);

            Console.WriteLine("Biggest double: {0}", double.MaxValue);
            Console.WriteLine("Smallest double: {0}", double.MinValue);

            Console.WriteLine("Biggest float: {0}", float.MaxValue);
            Console.WriteLine("Smallest float: {0}", float.MinValue);
            */

            // Explicit conversion (may lose data)

            //bool boolFromStr = bool.Parse("true");
            //int intFromStr = int.Parse("100");
            //double dblFromStr = double.Parse("1.234");

            //string myString = 100.ToString();
            //Console.WriteLine($"Data type: {myString.GetType()}");

            //double dblNum = 10.3567;
            //Console.WriteLine($"Integer: {(int)dblNum}");


            //// Implicit conversion

            //int intNum = 10;
            //long longNum = intNum;
            //decimal decimalNum = intNum;
            //Console.WriteLine($"longNum: {longNum}");
            //Console.WriteLine($"decimalNum: {decimalNum}");

            //Console.WriteLine("Currency: {0:c}", 20.206);
            //Console.WriteLine("Pad with 0s: {0:d5}", 20);
            //Console.WriteLine("4 decimals: {0:f4}", 20.2067282);
            //Console.WriteLine("Commas: {0:n0}", 202067282);

            //string randString = "My random string";
            //Console.WriteLine($"String length is: {randString.Length}");
            //Console.WriteLine("String Contains 'random': {0}", randString.Contains("random"));
            //Console.WriteLine("Index of 'random' within string: {0}", randString.IndexOf("random"));
            //Console.WriteLine("Removing 'random' from string: {0}", randString.Remove(3, 7));
            //Console.WriteLine("Inserting 'new' into string: {0}", randString.Insert(3, "new "));
            //Console.WriteLine("Replacing 'random' with 'new random' in string: {0}", randString.Replace("random", "new random"));
            //Console.WriteLine("Compare Two to Three: {0}", String.Compare("Two", "Three", StringComparison.OrdinalIgnoreCase));

            //Console.WriteLine("Comparing Z and z: {0}", String.Equals("Z", "z", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("Pad left: {0}", randString.PadLeft(20));
            //Console.WriteLine("Pad right: {0}", randString.PadRight(20, ';'));
            //Console.WriteLine("Trim whitespace: {0}", randString.Trim());
            //Console.WriteLine("Uppercase: {0}", randString.ToUpper());
            //Console.WriteLine("Lowercase: {0}", randString.ToLower());
            //string newString = String.Format("A {0} fox {1} over the {2} brown dog.", "quick", "jumped", "lazy");
            //Console.Write("Console.write and special new line character" + "\n");
            //Console.Write(newString + "\n");

            // Escape characters: \' \" \\ \t \a \n ...
            //Console.WriteLine(@"Escaping escape characters \n \t \\");

            // Arrays:
            //string[] youTubeLikes = new string[3];
            //youTubeLikes[0] = "5.5K";

            //Console.WriteLine("First index of youTubeLikes: {0}", youTubeLikes[0]);

            //int[] firstTenDigits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var weekends = new[] { "Friday", "Saturday", "Sunday" };
            //object[] random = { "Sunday", 1, "Funday", 0.45 };

            //Console.WriteLine("Array type of random: {0}", random.GetType());
            //Console.WriteLine("Array length of random: {0}", random.Length);

            //for ( int i = 0; i < random.Length; i++ )
            //{
            //    Console.WriteLine("At index {0} of random array, the value is: {1}", i, random[i]);
            //}

            // Multi-dimensional arrays:

            //string[,] multiDimentionalArray = new string[2,2]{ { "Ram", "Ramayan" }, { "Lakshman", "Ramayan" } };

            //Console.WriteLine("Array index 1 and row 0 is: {0}", multiDimentionalArray[1,0]);

            //for (int i = 0; i < multiDimentionalArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < multiDimentionalArray.GetLength(0); j++)
            //    {
            //        Console.WriteLine("Array index {0} and row {1} is: {2} ", i, j, multiDimentionalArray[i,j]);
            //    }
            //}

            // Methods to print elements of an array:

            //string[] ramayanCharacters = { "Ram", "Sita", "Lakshman", "Hanuman" };

            //PrintArrays(ramayanCharacters, "Print completed!");

            //Array.Sort(ramayanCharacters);

            //Array.Reverse(ramayanCharacters);

            //Console.WriteLine("Index of Lakshman: {0}", Array.IndexOf(ramayanCharacters, 1));

            // if else condition

            //int age = 15;

            //if (age < 12)
            //{
            //    Console.WriteLine("You are a child.");
            //}
            //else if (age >= 12 && age < 18)
            //{
            //    Console.WriteLine("You are a teenager.");
            //}
            //else if (age >= 18 && age < 65)
            //{
            //    Console.WriteLine("You are an adult.");
            //}
            //else
            //{
            //    Console.WriteLine("You are an old person");
            //}



            //bool isLegalToDrink = age >= 21 ? true : false;
            //Console.WriteLine(isLegalToDrink);

            //string choice = "Batman";
            //string favoriteSuperHero = choice == "Batman" ? "Cool" : "Okay";

            //Console.WriteLine(favoriteSuperHero);

            // Switch statements
            //int age = 20;

            //switch (age)
            //{
            //    case <= 10:
            //    case 11:
            //    case 12:
            //        Console.WriteLine("You are a child.");
            //        break;
            //    case < 18:
            //        Console.WriteLine("You are a teenager.");
            //        break;
            //    case < 65:
            //        Console.WriteLine("You are an adult.");
            //        break;
            //    default:
            //        Console.WriteLine("You are an old person");
            //        break;
            //}


            // While loop

            // Do while loop:

            // Exception Handling:

            //Divide(0, 0);

            // Continue from 1:31




        }

        //static void PrintArrays(string[] array, string message)
        //{
        //    int i = 0;
        //    foreach (string k in array)
        //    {
        //        Console.WriteLine("Printing element at index {0}: {1}", i, k);
        //        i++;
        //    }
        //    Console.WriteLine(message);
        //}

        //private static void Divide(double firstNumber, double secondNumber)
        //{
        //    try
        //    {
        //        double result = firstNumber / secondNumber;
        //        Console.WriteLine("Answer is {0}", result);
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        Console.WriteLine("Attempting to divide by zero.");
        //        Console.WriteLine(ex.GetType().Name);
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.GetType().Name);
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Cleaning up / Closing DB Connections (Always executes)");
        //    }
        //}


    }
}