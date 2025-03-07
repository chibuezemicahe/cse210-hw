using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        int userNumber = -1;
       
        while (userNumber != 0)
        {     
            Console.Write("Please enter a number ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
               numberList.Add(userNumber);
            }
            
        }
        int sum = 0;
        foreach(int number in numberList){
            sum += number;
        }
         Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / (float)numberList.Count;
        Console.WriteLine($"The average is: {average}");


        int max = 0;

        foreach (int number in numberList){
            if (number > max){
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}