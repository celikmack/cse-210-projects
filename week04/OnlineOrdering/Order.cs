using System;
using System.Runtime.InteropServices.Marshalling;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateCustOrder()
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            subtotal += product.Subtotal();
        }

        if (_customer.IsUSA())
        {
            subtotal += 5;
        }

        else
        {
            subtotal += 35;
        }
        return subtotal;
    }

    public string GetPackingLabel()
    {
        string packingString = "";
        foreach (Product product in _products)
        {
            packingString += product.GetPackingInfo() + "\n";
        }
        return packingString;
    }
    public string GetShippingLabel()
    {
        return _customer.GetDisplayText();
    }
}