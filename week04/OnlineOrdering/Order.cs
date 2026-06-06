using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _totalOrderCost;
     
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double TotalOrder()
    {
        foreach(Product product in _products)
        {
            _totalOrderCost += product.TotalCost();
        }

        if(_customer.USA(_customer.GetAddress()) == true)
        {
            return _totalOrderCost += 5;
        }
        else{
            return _totalOrderCost += 35;
        }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public List<string> PackingLabel()
    {
        List<string> name = new List<string>();
        
        foreach(Product product in _products)
        {
            string line = $"{product.GetProductName()} : {product.GetProductID()}";
            name.Add(line);
        }
        return name;
    }

    public string ShippingLabel()
    {
        string label = $"{_customer.GetName()} \n{_customer.GetAddress().FullAddress()}";
        return label;
    }
}