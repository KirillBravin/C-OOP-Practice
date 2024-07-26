using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Exercises_with_lists.Order_System
{
    public class Order
    {
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }

        int totalPrice = 0;

        public Order()
        {
            Customers = new List<Customer>();
            Products = new List<Product>();
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void AddProduct(Product product) 
        {
            Products.Add(product);
        }

        public void TakingOrder(Customer customer, Product product)
        {
            Console.WriteLine($"How many orders would you like to take?");
            int orderCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < orderCount; i++)
            {
                sum += product.Price;
                totalPrice += product.Price;
            }

            Console.WriteLine($"The price of this order is: {sum}");
        }

        public void ShowPriceOfAllOrders()
        {
            Console.WriteLine($"Total price is: {totalPrice}");
        }
    }
}
