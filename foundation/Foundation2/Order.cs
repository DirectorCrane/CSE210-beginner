using System;



class Order
{
    private List<Product>_products;
    private Customer _customer;
    private decimal USAShippinCost = 5.00m;
    private decimal InternationalShippingCost = 35.00m;

    public Order (Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;

    }
    public decimal CalculateTotalPrice()
    {
        decimal totalProductCost = 0 ;
        foreach(Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        decimal shippingCost = _customer.isInUSA() ? USAShippinCost : InternationalShippingCost;
        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach(Product product in _products)
        {
            label += product.GetProductLabel() + "\n";
        }
        return label ;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetShippingAddress}";

    }




















}





