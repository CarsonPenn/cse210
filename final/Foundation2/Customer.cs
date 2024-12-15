using System;

public class Customer {
    private string _name;
    private Address _address;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }
// identify if from usa
    public bool isFromUSA() {
        return _address.isUSA();
    }
// get name
    public string GetName() {
        return _name;
    }
// add the address and customer together
    public string GenerateAddress() {
        return _address.GenerateAddress();
    }
// get shipping cost, 5 if from usa and 2000000 if not
    public double GetShippingCost() {
        return isFromUSA() ? 5 : 2000000;
    }
}
