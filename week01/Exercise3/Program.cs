using System;

class Program
{
    static void Main(string[] args)
    {
      Random randomNumber = new Random();

      int magicNumber = randomNumber.Next(1,200);

      
      int guess = -1;

     

       while (guess != magicNumber)
       {
            Console.Write("Guess a Number? ");
            guess = int.Parse(Console.ReadLine());

             if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
       }
    }
}