using System;
// address variables
public class Address {
    private string _street;
    private string _city;
    private string _stateOrRegion;
    private int _postalCode;
    private string _country;

    public Address(string street, string city, string stateOrRegion, int postalCode, string country) {
        _street = street;
        _city = city;
        _stateOrRegion = stateOrRegion;
        _postalCode = postalCode;
        _country = country;
    }
// check if in usa
    public bool isUSA() {
        return _country.ToLower() == "usa";
    }
// generate the address
    public string GenerateAddress() {
        return $"{_street}, {_city}, {_stateOrRegion}, {_postalCode}, {_country}";
    }
}
