// Base Event class
public class Event {
    private string title;
    private string description;
    private DateTime date;
    private DateTime time;
    private Address address;

    public Event(string title, string description, DateTime date, DateTime time, Address address) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    // Method to return standard details message
    public virtual string GetStandardDetails() {
        return $"{title}\n{description}\n{date.ToShortDateString()} {time.ToShortTimeString()}\n{address.GetAddressString()}";
    }

    // Method to return full details message
    public virtual string GetFullDetails() {
        return $"{title}\n{description}\n{date.ToShortDateString()} {time.ToShortTimeString()}\n{address.GetAddressString()}";
    }

    // Method to return short description message
    public virtual string GetShortDescription() {
        return $"{GetType().Name}: {title} - {date.ToShortDateString()}";
    }
}
