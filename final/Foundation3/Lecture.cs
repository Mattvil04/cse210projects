// Lecture class, derived from Event
public class Lecture : Event {
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address) {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    // Method to return full details message for Lecture
    public override string GetFullDetails() {
        return base.GetFullDetails() + $"\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}