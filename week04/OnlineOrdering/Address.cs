public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    // get address info
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    // determine if they are from usa
    public bool IsUSA()
    {
        return _country.ToLower() == "usa";
    }
    // puts address in proer format and displays it
    public string AddressString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
    // converts address to a sting
    public override string ToString()
    {
        return AddressString();
    }

}