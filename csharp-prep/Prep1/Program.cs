using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        String firstname = Console.ReadLine();
        
        Console.Write("What is your lastname?");
        String lastname = Console.ReadLine();
        
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}