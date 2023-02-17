class Running : Activity
{
    private double distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / length * 60 / 1.609; // speed in mph
    }

    public override double GetPace()
    {
        return length / distance * 1.609; // pace in min/mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance {distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min/mile";
    }
}