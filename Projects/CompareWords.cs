using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two words and I will compare them for you.\n");
            Console.Write("Enter first word: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word: ");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\nYou entered:\nFirst word: {word1},\nSecond word: {word2}");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nThey are same.");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else 
            {
                Console.WriteLine($"\nYou entered:\nFirst word: {word1},\nSecond word: {word2}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThey are different.");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    
    }
    
}