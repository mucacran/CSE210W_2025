using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        var f1 = new Fraction();
        Console.WriteLine(f1.getFractionString());
        Console.WriteLine(f1.getDecimalValue());

        var f2 = new Fraction(5);
        Console.WriteLine(f2.getFractionString());
        Console.WriteLine(f2.getDecimalValue());

        var f3 = new Fraction(3, 4);
        Console.WriteLine(f3.getFractionString());
        Console.WriteLine(f3.getDecimalValue());

        var f4 = new Fraction(1, 3);
        Console.WriteLine(f4.getFractionString());
        Console.WriteLine(f4.getDecimalValue());
    }


}