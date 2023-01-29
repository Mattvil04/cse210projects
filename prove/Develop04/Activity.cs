abstract class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public void Start()
    {
        // Print starting message
        Console.WriteLine($"Starting {Name} activity");
        Console.WriteLine(Description);
        Console.WriteLine("Enter duration (in seconds):");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin.");
        Thread.Sleep(3000);

        // Call abstract method to be implemented in child classes
        DoActivity();

        // Print ending message
        Console.WriteLine("Good job! You have completed the " + Name + " activity for " + Duration + " seconds.");
        Thread.Sleep(3000);
    }

    public abstract void DoActivity();
}
