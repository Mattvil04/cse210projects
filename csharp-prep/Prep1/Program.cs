using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name: ");
        string color = Console.ReadLine();
        Console.Write("What is your surname: ");
        string surname = Console.ReadLine();
        Console.WriteLine(color);
        Console.WriteLine(surname);
        Console.Write($"Your name is {surname}, {color} {surname} ");
       
    }
}
