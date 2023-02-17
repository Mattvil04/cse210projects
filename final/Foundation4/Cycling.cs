class Cycling : Activity
{
    private double speed;
    private double lenght;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed / 60 * length * 1.609; // distance in km
    }

    public override double GetSpeed()
    {
        return speed; // speed in kph
    }

    public override double GetPace()
    {
        return 60 / speed * 1.609; // pace in min/km
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance {GetDistance():F1} km, Speed {speed:F1} kph, Pace: {GetPace():F1} min/km";
    }
}
