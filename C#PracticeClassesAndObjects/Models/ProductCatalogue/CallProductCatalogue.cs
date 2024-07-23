using System;
using System.Drawing;


namespace C_PracticeClassesAndObjects.Models.ProductCatalogue
{
    public class CallProductCatalogue
    {
        private ProductCatalogue productCatalogue = new ProductCatalogue();

        public void AddInitialProducts()
        {
            Product milk = new Product("Milk", 1.39, 15);
            Product potatoes = new Product("Potatoes", 0.68, 200);
            productCatalogue.AddProduct(milk);
            productCatalogue.AddProduct(potatoes);
        }

        public void RemoveProduct(string productName)
        {
            productCatalogue.RemoveItemByName(productName);
        }

        public void ShowProducts()
        {
            Console.WriteLine(productCatalogue);
        }

        public void showTotalPrice()
        {
            double totalPrice = productCatalogue.TotalPrice();
            Console.WriteLine($"Total price: {totalPrice:C}");
        }

        public void FindProduct(string productName)
        {
            Product product = productCatalogue.FindProduct(productName);
            if (product != null)
            {
                Console.WriteLine($"Found product: {product}");
            } else Console.WriteLine($"Product {productName} not found");
        }
    }
}