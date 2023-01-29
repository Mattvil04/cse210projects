using System;

class Program
{
    static void Main(string[] args)
    
{
        // Create a list of activities
        List<Activity> activities = new List<Activity>()
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };

        // Print menu options
        Console.WriteLine("Welcome to the Relaxation Station!");
        Console.WriteLine("Please select an activity:");
        for (int i = 0; i < activities.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {activities[i].Name}");
        }

        // Get user input for activity selection
        int choice = int.Parse(Console.ReadLine());

        // Start selected activity
        activities[choice - 1].Start();
    }
}





