using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f = new Fraction();
        f.SetNumerator(4);
        f.SetDenominator(5);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimal());
    }
}