using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
            int secretNumber = random.Next(1, 11);
            int guess = 0;
            int lives = 1;
            Console.WriteLine(secretNumber);

            Console.WriteLine("Welcome to guess a number game!\nYou get 5 lives to guess a random number between 1 and 10...\n");

            do
            {
                Console.Write("Enter your guess number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lives remaining: {0}", 5 - lives);
                lives++;
                
                if (guess == secretNumber)
                {
                    Console.WriteLine("You guessed it right, it was {0}. HURRAY!!!", secretNumber);
                    break;
                }
                else if (lives > 5)
                {
                    Console.WriteLine("You are out of lives...\nGAME OVER!");
                    break;
                }

            } while (guess != secretNumber);
			
		}
	}
}