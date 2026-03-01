using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        
        Boolean guessed = false;

        while (guessed == false)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int theGuess = int.Parse(guess);

            if (theGuess == number)
            {
            Console.WriteLine("You guessed it! "); 
            guessed = true;
            }    
            else if (theGuess < number)
            {
                Console.WriteLine("Higher ");
            }
            else
            {
                Console.WriteLine("Lower ");
            }
        }
    }

    
}