using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            int targetNumber = GenerateRandomNumber();
            bool guessed = false;

            Console.WriteLine("Welcome to the Guess Number game!");
            Console.WriteLine("I have chosen a number between 0 and 100 (inclusive).");
            Console.WriteLine("Try to guess the number!");

            while (!guessed)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                if (guess < targetNumber)
                {
                    Console.WriteLine("My number is bigger. Try again!");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("My number is smaller. Try again!");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                    guessed = true;
                }
            }

            Console.Write("Do you want to play again? (y/n): ");
            string playAgainInput = Console.ReadLine().ToLower();

            playAgain = (playAgainInput == "y" || playAgainInput == "yes");
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for playing the Guess Number game. Goodbye!");
    }

    static int GenerateRandomNumber()
    {
        Random random = new Random();
        return random.Next(0, 101);
    }
}
