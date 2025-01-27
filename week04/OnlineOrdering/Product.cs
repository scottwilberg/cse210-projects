public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    // get the product information
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    // method to get the cost of each product time the numbe of products
    public double GetProductCost()
    {
        double cost = _price * _quantity;
        return cost;
    }
    // method to convert the name, Id, and quantity to a string in the proper format
    public string GetNameId()
    {
        return $"{_name.PadRight(20)} {_productId.PadLeft(5)} {_quantity, 5}";
    }
}