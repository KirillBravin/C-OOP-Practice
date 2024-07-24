using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Exercises_with_lists
{
    public class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }

        public Product(string productName, int price)
        {
            ProductName = productName;
            Price = price;
        }
    }

    public class AllProducts
    {
        public List<Product> Products { get; set; }
        
        public AllProducts() 
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product) 
        {
            Products.Add(product);
        }

        public void ProductSum()
        {
            int sum = 0;
            foreach (Product product in Products)
            {
                sum += product.Price;
            }

            Console.WriteLine($"Sum of all products is: {sum}");
        }
    }

    public class CallProducts()
    {
        AllProducts products = new AllProducts();

        public void AddingProducts()
        {
            products.AddProduct(new Product("Cheese" , 15));
            products.AddProduct(new Product("Milk" , 22));
            products.AddProduct(new Product("Donuts" , 55));
            products.AddProduct(new Product("Bread" , 77));
            products.AddProduct(new Product("Apples" , 12));
        }

        public void CalculateProductSum()
        {
            products.ProductSum();
        }
    }
}
