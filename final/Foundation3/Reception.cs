// Reception class, derived from Event
public class Reception : Event {
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail)
        : base(title, description, date, time, address) {
        this.rsvpEmail = rsvpEmail;
    }

    // Method to return full details message for Reception
    public override string GetFullDetails() {
        return base.GetFullDetails() + $"\nRSVP email: {rsvpEmail}";
    }
}