using System;



class Customer
{

    private string _customerName;

    private Address _address;

    public Customer (string customername, Address address) // please see the address class
    {

        _customerName = customername;
         _address = address; 


    }

    public bool isInUSA()
    {
        return _address.isInUSA(); // please see the address class
    }

    public string GetName()
    {
        return _customerName;

    }
    public string GetShippingAddress()
    {
        return _address.GetFullAddress(); // please see the address class
    }




















}