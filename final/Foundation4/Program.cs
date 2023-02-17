using System;

class Program
{
    static void Main(string[] args)
    {
          var activities = new Activity[]
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 4), 45, 25),
            new Swimming(new DateTime(2022, 11, 4), 60, 20)
        };
        foreach (var activity in activities)
    {
        Console.WriteLine(activity.GetSummary());
    }
// Output:
// 03 Nov 2022 Running (30 min) - Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min/mile
// 03 Nov 2022 Running (30 min) - Distance 4.8 miles, Speed 9.6 mph, Pace: 6.3 min/mile
// 04 Nov 2022 Cycling (45 min) - Distance 18.0 km, Speed 25.0 kph, Pace: 2.4 min/km
// 04 Nov 2022 Swimming (60 min) - Distance 1.0 km, Speed 1.0 mph, Pace: 60.0 min/mile
    }
}