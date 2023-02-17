// Address class to store event address information
public class Address {
    private string street;
    private string city;
    private string state;
    private string country;
    private string zip;

    public Address(string street, string city, string state, string country, string zip) {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
        this.zip = zip;
    }

    // Method to return address as a string
    public string GetAddressString() {
        return $"{street}, {city}, {state}, {country}, {zip}";
    }
}
