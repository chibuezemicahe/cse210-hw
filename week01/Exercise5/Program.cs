using System;

class Program
{
    static void Main(string[] args)
    {
        
        static void DisplayWelcomeMessage(){
             Console.WriteLine("Hello My Friend! Welcome To the Program");
        }

        static string DisplayName(){
            Console.Write("Please enter your name: ");
            string userName  =  Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber; 
        }

        static int SquareNumber(int userNumber)
        {
            return userNumber * userNumber; // More efficient
        }



        static void DisplayResult(string name, int square){

            Console.WriteLine($"{name}, the square of your number is {square}");

        }

         DisplayWelcomeMessage();

        string userName = DisplayName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
}