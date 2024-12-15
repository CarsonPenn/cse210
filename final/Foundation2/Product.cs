using System;
// product strings
public class Product {
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity =  quantity;
    }
// p * q
    public double CalculatePrice(){
        return _price * _quantity;
    }
    // get name
    public string GetName() {
        return _name;
    } 
    // get product name
    public string GetProductId(){
        return _productId;
    }
    // gettin the price
    public double GetPrice(){
        return _price;
    }
    // quantity
    public int GetQuantity() {
        return _quantity;
    }


}