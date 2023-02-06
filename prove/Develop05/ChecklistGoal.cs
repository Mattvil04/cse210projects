class ChecklistGoal : Goal
{
    public int TimesCompleted { get; set; }
    public int TotalTimes { get; set; }

    public override void RecordGoal()
    {
        Points += 50;
        TimesCompleted++;
        if (TimesCompleted == TotalTimes)
        {
            Points += 500;
            Completed = true;
        }
    }
}
