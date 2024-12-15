using System;
using System.Collections.Generic;


class Program {
    static void Main(string[] args) {
        Console.Clear();
        Console.WriteLine("--**----**----**----**----**----**----**----**----**--");

        // Order 1 Luke Skywalker usa example
        // address
        Address address1 = new Address("5858 Lucas Valley Rd", "Nicasio", "California", 94946, "USA");
        Customer customer1 = new Customer("Luke Skywalker", address1);
        // products and addinf them to order
        Product order1Product1 = new Product("Robot hand", "132", 230.0, 1);
        Product order1Product2 = new Product("Lightsaber hilt", "32415", 4000.00, 3);
        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        // getting the labels
        double order1ShippingCost = order1.CalculateShipping();
        double order1Subtotal = order1.CalculateSubTotal();
        double order1Total = order1.CalculateSubTotal();

        // print 1
        order1.DisplayShippingLabel();
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal, order1ShippingCost, order1Total);

        Console.WriteLine("--**----**----**----**----**----**----**----**----**----**----**----**----**----**----**--");
        Console.WriteLine();

        // Order 2 Darth Vader intergalactic example
        // customer address and name
        Address address2 = new Address("1 Death Star Apt#1", "Death Star", "Sector 7", 299284, "Skyriver galaxy");
        Customer customer2 = new Customer("Darth Vader", address2);
        // darth Vader's product order
        Product order2Product1 = new Product("Pringles", "8675445", 2.00, 6);
        Product order2Product2 = new Product("Black Gloves", "62263", 25.00, 2);
        Product order2Product3 = new Product("Cough Drops", "992", 5.00, 100);
        // adding the prodcucts
        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        // getting teh needed labels
        double order2ShippingCost = order2.CalculateShipping();
        double order2Subtotal = order2.CalculateSubTotal();
        double order2Total = order2.CalculateSubTotal();

        // print 2
        order2.DisplayShippingLabel();
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
    }
}

// thanks againg to stackoverflow, and w3schools. 
// ran my code through chatgpt to validate, it helped me fix a problem with my address.cs and gave suggestions on how to streamline the shipping and packaging label\
