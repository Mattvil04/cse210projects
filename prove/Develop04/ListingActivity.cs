class ListingActivity : Activity
{
public ListingActivity()
{
Name = "Listing";
Description = "This activity will help you relax by listing things you're grateful for. Take a few minutes to think of as many things as you can.";
}

public override void DoActivity()
{
    for (int i = 0; i < Duration; i++)
    {
        Console.WriteLine("List one thing you are grateful for:");
        var input = Console.ReadLine();
        Console.WriteLine("You listed: " + input);
        Console.WriteLine("Countdown: " + (Duration - i));
        Thread.Sleep(3000);
    }
}
}