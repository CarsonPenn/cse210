using System;
// address 
// public class to get all the elements needed for the address, street, city, state and country (zip code?)
// set the public cariables 
// generate behavior

public class Address {
    private string _street;
    private string _city;
    private string _state;
    private int _zipCode;
    private string _country;

    public Address(string street, string city, string state, int zipCode, string country) {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public string GenerateCompleteAddress() {
        string address = _street + ", " + _city + ", " + _state + ", " + _zipCode + ", " + _country;
        return address;
    }
}