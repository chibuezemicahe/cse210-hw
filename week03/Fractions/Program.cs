using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction newFraction = new Fraction();

        Console.WriteLine(newFraction.GetFractionString());
        Console.WriteLine(newFraction.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}