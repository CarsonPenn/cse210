using System;

public class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer) {
        _customer = customer;
    }
// add the products
    public void AddProduct(Product product) {
        _products.Add(product);
    }
// grab the customer and determine what the shipping costs will be
    public double CalculateShipping() {
        return _customer.GetShippingCost();
    }
// subtotal is p * q + shipping(if in usa or !=)
    public double CalculateSubTotal() {
        double totalprice = 0;

        foreach (Product p in _products) {
            totalprice += p.CalculatePrice();
        }

        return totalprice + CalculateShipping();
    }
// Generate Packing Label, with the prodcuts name and id
    public string GeneratePackingLabel() {
        string packingLabel = "Packing Label:\n";

        foreach (Product p in _products) {
            packingLabel += $"{p.GetName()} - {p.GetProductId()}\n";
        }
        return packingLabel;
    }
// this will have customers name and address
    public string GenerateShippingLabel() {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GenerateAddress()}";
    }
// display total costs.
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
