using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some example events
        Lecture lecture = new Lecture(
            "Intro to C# Programming",
            "Learn the basics of C# programming language.",
            new DateTime(2023, 3, 15),
            new DateTime(2023, 3, 15, 18, 0, 0),
            new Address("123 Main St", "Anytown", "CA", "USA", "12345"),
            "John Doe",
            50);
            Reception reception = new Reception(
            "Company Networking Event",
            "Meet and network with other professionals in your industry.",
            new DateTime(2023, 4, 1),
            new DateTime(2023, 4, 1, 17, 0, 0),
            new Address("456 Oak Ave", "Anytown", "CA", "USA", "12345"),
            "rsvp@company.com"
             );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Community Picnic",
            "Enjoy a fun-filled day with family and friends.",
            new DateTime(2023, 6, 1),
            new DateTime(2023, 6, 1, 12, 0, 0),
            new Address("789 Maple St", "Anytown", "CA", "USA", "12345"),
            "Rain or shine, the picnic will go on!"
            );

    // Generate marketing messages for each event
    Console.WriteLine("Standard details:");
    Console.WriteLine(lecture.GetStandardDetails());
    Console.WriteLine(reception.GetStandardDetails());
    Console.WriteLine(outdoorGathering.GetStandardDetails());

    Console.WriteLine("\nFull details:");
    Console.WriteLine(lecture.GetFullDetails());
    Console.WriteLine(reception.GetFullDetails());
    Console.WriteLine(outdoorGathering.GetFullDetails());

    Console.WriteLine("\nShort description:");
    Console.WriteLine(lecture.GetShortDescription());
    Console.WriteLine(reception.GetShortDescription());
    Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}