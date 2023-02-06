
class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }

    public virtual void RecordGoal()
    {
        Points += 10;
    }
}

