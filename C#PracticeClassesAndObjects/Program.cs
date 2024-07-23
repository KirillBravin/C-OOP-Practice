using C_PracticeClassesAndObjects.Models.ProductCatalogue;
using OOP.Models;
using OOP.Models.Cars;
using System;

namespace C_PracticeClassesAndObjects
{
    public class MainProgram
    {
        public static void Main()
        {
            //CallCars cars = new CallCars();
            //cars.PrintCars();

            CallProductCatalogue catalogueManager = new CallProductCatalogue();
            catalogueManager.AddInitialProducts();
            catalogueManager.ShowProducts();
            catalogueManager.RemoveProduct("Milk");
            catalogueManager.ShowProducts();
            catalogueManager.showTotalPrice();
            catalogueManager.FindProduct("Potatoes");
        }
    }
}