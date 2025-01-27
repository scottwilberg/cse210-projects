public class Customer
{
    private string _custName;
    private Address _address;
    // get customer information
    public Customer(string custName, Address address)
    {
        _custName = custName;
        _address = address;
    }
    // returns if the customer lives in the usa
    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }
    // get the name and address into a string
    public string NameAddress()
    {
        return $"{_custName}\n{_address}";
    }

}