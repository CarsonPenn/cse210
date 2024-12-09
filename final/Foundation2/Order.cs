using System;
using System.Collections.Generic;


public class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer) {
        _customer = customer;
    }

    public void AddProduct(Product product) {
        _products.Add(product);
    }

    public double CalculateShipping() {
        return _customer.GetShippingCost();
    }

    public double CalculateSubTotal() {
        double totalprice = 0;

        foreach (Product p in _products) {
            totalprice += p.CalculatePrice();
        }

        return totalprice + CalculateShipping();
    }

    public string GeneratePackingLabel() {
        string packingLabel = "Packing Label:\n";
        foreach (Product p in _products) {
            packingLabel += $"{p.GetName()} - {p.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel() {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GenerateAddress()}";
    }

    public void DisplayCosts(double subtotal, double shippingCost, double total) {
        Console.WriteLine($"Subtotal: ${subtotal}");
        Console.WriteLine($"Shipping: ${shippingCost}");
        Console.WriteLine($"Total: ${total}");
    }

    public void DisplayShippingLabel() {
        Console.WriteLine(GenerateShippingLabel());
    }

    public void DisplayPackingLabel() {
        Console.WriteLine(GeneratePackingLabel());
    }
}
