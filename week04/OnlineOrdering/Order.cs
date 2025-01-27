using System.Collections.Generic;
public class Order
{
    private List<Product> _products;
    private Customer _customer;
    // get order information and set up list for product
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    // add product to list
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    // calculate the price of the order
    public double TotalPriceOrder()
    {   
        // create a total object
        double total = 0;
        // foreach statement to go through each product and add cost to total
        foreach (var product in _products)
        {
            total += product.GetProductCost();
        }
        // initialize object to trak shipping cost
        double shippingCost;
        // if statement to determine if the customer lives in the usa or not to get the proper shipping cost
        if (_customer.LivesInUSA() == true)
        {
            shippingCost = 5;
        }
        else 
        {
            shippingCost = 35;
        }
        // add the total to the shipping cost
        return total + shippingCost;
    }
    // set up the packing label
    public string PackingLabel()
    {
        string label = $"Products:\n" + "  Name".PadRight(23) + "ID".PadRight(8) + "Quantity".PadLeft(2) + "\n";
        foreach (var product in _products)
        {
            label +=  $"- {product.GetNameId()}\n";
        }
        return label;
    }
    // set up the shipping label
    public string ShippingLabel()
    {
        return $"{_customer.NameAddress()}";
    }
    // string of the total price of the order.
    public override string ToString()
    {
        return $"\n\nTotal Cost: ${TotalPriceOrder():F2}";
    } 
}