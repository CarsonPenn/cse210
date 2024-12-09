using System;

public class Customer {
    private string _name;
    private Address _address;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public bool isFromUSA() {
        return _address.isUSA();
    }

    public string GetName() {
        return _name;
    }

    public string GenerateAddress() {
        return _address.GenerateAddress();
    }

    public double GetShippingCost() {
        return isFromUSA() ? 5 : 2000000;
    }
}
