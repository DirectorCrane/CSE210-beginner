using System;

class Product
{

private string _name;
private string _productId;
private decimal _price;
private int _quantity;

public Product(string name, string productid, decimal price, int quantity)
{
_name = name;

_productId = productid;

_price = price;

_quantity = quantity;

}

public decimal GetTotalCost()
{
    return _price * _quantity;

}

public string GetProductLabel()
{
    return $"{_name}({_productId})";
}






















}





