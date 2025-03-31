using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Address address = new Address("123 Main St", "New York", "NY", "USA");

            // Create a customer
            Customer customer = new Customer("John Doe", address);

            // Create some products
            Product laptop = new Product("Laptop", 101, 1200, 1);
            Product mouse = new Product("Mouse", 102, 25, 2);

            // Create an order
            Order order = new Order(customer);

            // Add products to the order
            order.AddProduct(laptop);
            order.AddProduct(mouse);

            // Display packing label
            Console.WriteLine(order.GeneratePackingLabel());

            // Display shipping label
            Console.WriteLine("\n" + order.GenerateShippingLabel());

            // Display total cost
            Console.WriteLine($"\nTotal Cost: ${order.CalculateTotalCost()}");
        }
    }
}
