using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalScore = 0;

        while (true)
        {
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. Record a goal");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show total score");
            Console.WriteLine("5. Exit");

            Console.Write("Enter option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("1. Simple goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Checklist goal");
                Console.Write("Enter goal type: ");
                int goalType = int.Parse(Console.ReadLine());

                Console.Write("Enter goal name: ");
                string goalName = Console.ReadLine();

                if (goalType == 1)
                {
                    SimpleGoal goal = new SimpleGoal();
                    goal.Name = goalName;
                    goals.Add(goal);
                }
                else if (goalType == 2)
                {
                    EternalGoal goal = new EternalGoal();
                    goal.Name = goalName;
                    goals.Add(goal);
                }
                else if (goalType == 3)
                {
                    ChecklistGoal goal = new ChecklistGoal();
                    goal.Name = goalName;
                    Console.Write("Enter total times: ");
                    goal.TotalTimes = int.Parse(Console.ReadLine());
                    goals.Add(goal);
                }
            }
            else if (option == 2)
            {
                Console.Write("Enter goal name: ");
                string goalName = Console.ReadLine();

                bool found = false;
                foreach (Goal goal in goals)
                {
                    if (goal.Name == goalName)
                    {
                        found = true;
                        goal.RecordGoal();
                        totalScore += goal.Points;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Goal not found");
                }
            }
            else if (option == 3)
                {
                    Console.WriteLine("Goals:");
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine(goal.ToString());
                    }
                }
            else if (option == 4)
            {
                Console.WriteLine("Total score: " + totalScore);
            }
            else if (option == 5)
            {
            break;
            }
        }
    }
}
    

