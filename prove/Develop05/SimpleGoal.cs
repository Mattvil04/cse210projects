class SimpleGoal : Goal
{
    public override void RecordGoal()
    {
        Points += 1000;
        Completed = true;
    }
}