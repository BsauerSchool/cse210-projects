using System;

public class Product
{
    private string _productName;
    private int _productID;
    private double _price;
    private int _quantity;

    public double TotalCost()
    {
        double total = _price * _quantity;
        return total;
    }

    public void SetProduct(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }

    public Product()
    {
        _productName = "";
        _productID = 0;
        _price = 0.00;
    }
    
    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductID()
    {
        return _productID;
    }
}