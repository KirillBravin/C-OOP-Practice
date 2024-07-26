using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Exercises_with_lists.Order_System
{
    public class CallOrders
    {
        private Order orders;

        public CallOrders()
        {
            orders = new Order();
        }

        public void Initialize()
        {
            AddCustomers();
            AddProducts();
        }


        public void AddCustomers()
        {
            orders.AddCustomer(new Customer("Harry"));
            orders.AddCustomer(new Customer("Leona"));
            orders.AddCustomer(new Customer("Aura"));
        }

        public void AddProducts()
        {
            orders.AddProduct(new Product("Pizza", 12));
            orders.AddProduct(new Product("Soup", 12));
            orders.AddProduct(new Product("Salad", 12));
        }

        public void OrderProducts(string customerName, string productName)
        {
            Customer customer = orders.Customers.Find(x => x.Name == customerName);
            Product product = orders.Products.Find(x => x.Name == productName);

            if (customer != null && product != null)
            {
                orders.TakingOrder(customer, product);
            }
            else Console.WriteLine("Customer of product is not found.");
        }

        public void ShowTotalPrice()
        {
            orders.ShowPriceOfAllOrders();
        }
    }
}
