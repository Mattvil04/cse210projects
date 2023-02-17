class Swimming : Activity
{
    private int laps;
    private double lenght;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000; // distance in km
    }

    public override double GetSpeed()
    {
        return GetDistance() / length * 60 / 1.609; // speed in mph
    }

    public override double GetPace()
    {
        return length / GetDistance() * 1.609; // pace in min/mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance {GetDistance():F1} km, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min/mile";
    }
}