using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_PracticeClassesAndObjects.Models.ProductCatalogue
{
    public class ProductCatalogue
    {
        private Product[] products;
        private int lastItem;
        public ProductCatalogue()
        {
            products = new Product[1000];
            lastItem = 0;
        }

        public void AddProduct(Product addProduct)
        {
            if (lastItem < products.Length)
            {
                products[lastItem] = addProduct;
                lastItem++;
            }
            else Console.WriteLine("Product catalogue is full.");
        }

        public void RemoveItemByName(string productName)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == productName)
                {
                    products[i] = products[lastItem - 1];
                    products[lastItem - 1] = null;
                    lastItem--;
                    return;
                }
            }
        }

        public double TotalPrice()
        {
            double totalPrice = 0;

            for (int i = 0; i < lastItem; i++)
            {
                totalPrice += products[i].TotalPrice();
            }

            return totalPrice;
        }

        public Product FindProduct(string productName)
        {
            for (int i = 0; i < lastItem; i++)
            {
                if (productName == products[i].Name)
                {
                    return products[i];
                }
            }
            return null;
        }

        public Product[] GetProducts()
        {
            Product[] currentProducts = new Product[lastItem];
            Array.Copy(products, currentProducts, lastItem);
            return currentProducts;
        }

        // Only did this thanks to chatGPT sadly, didn't know how to implement
        // it otherwise
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lastItem; i++)
            {
                sb.AppendLine(products[i].ToString());
            }
            return sb.ToString();
        }
    }
}
