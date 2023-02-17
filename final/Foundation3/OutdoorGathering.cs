// OutdoorGathering class, derived from Event
public class OutdoorGathering : Event {
    private string weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weatherStatement)
        : base(title, description, date, time, address) {
        this.weatherStatement = weatherStatement;
    }

    // Method to return full details message for OutdoorGathering
    public override string GetFullDetails() {
        return base.GetFullDetails() + $"\nWeather statement: {weatherStatement}";
    }
}
