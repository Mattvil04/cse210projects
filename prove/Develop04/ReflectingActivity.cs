
class ReflectionActivity : Activity
{
    private string[] prompts = { "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};

    private string[] questions = { "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?"};
    public ReflectionActivity()
{
    Name = "Reflection";
    Description = "This activity will help you reflect on past experiences and learn from them. Take a few minutes to think about each prompt and answer the related questions.";
}

public override void DoActivity()
{
    for (int i = 0; i < Duration; i++)
    {
        Console.WriteLine("Prompt: " + prompts[i % prompts.Length]);
        for (int j = 0; j < questions.Length; j++)
        {
            Console.WriteLine(questions[j]);
            Thread.Sleep(3000);
        }
        Console.WriteLine("Countdown: " + (Duration - i));
        Thread.Sleep(3000);
    }
}
}
