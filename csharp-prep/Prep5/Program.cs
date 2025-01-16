using System;

class Program
{

    static void Main(string[] args)
    {
        welcome();
        
        string name = yourName();
        int number = yourNumber();

        display(name, number);

    }

    static void welcome(){
        Console.WriteLine("Welcome to the program!");
    }
    
    static string yourName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int yourNumber(){
        Console.Write("Please enter your favorite number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        return number * number;
    }

    static void display(string name, int number){
        Console.WriteLine($"{name}, the square of your number is: {number}.");
    }
        
}