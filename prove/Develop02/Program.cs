using System;

class Program
{
    static Journal _journal = new Journal();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal Program");
    while (true)
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            _journal.WriteNewEntry();
        }
        else if (choice == 2)
        {
            _journal.DisplayJournal();
        }
        else if (choice == 3)
        {
            Console.WriteLine("Enter a filename: ");
            string filename = Console.ReadLine();
            _journal.SaveJournal(filename);
        }
        else if (choice == 4)
        {
            Console.WriteLine("Enter a filename: ");
            string filename = Console.ReadLine();
            _journal.LoadJournal(filename);
        }
        else if (choice == 5)
        {
            break;
        }
    }
}
}