using System;
using System.Security.Cryptography;

class Program

{
    static void Main(string[] args)
    {
       
        {
            Console.WriteLine("What is your magic number? ");
            int magicnumber = int.Parse(Console.ReadLine());

            int guess = 0;

            while (magicnumber > guess)
            {
                  Console.Write("What is your guess? ");
             guess = int.Parse(Console.ReadLine());
            if(guess < magicnumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicnumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it right!! ");
            }
           }
        }
    }
}

    