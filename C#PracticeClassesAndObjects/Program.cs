using C_PracticeClassesAndObjects.Models.ProductCatalogue;
using OOP.Models;
using OOP.Models.Cars;
using OOP.Models.Students;
using System;

namespace C_PracticeClassesAndObjects
{
    public class MainProgram
    {
        public static void Main()
        {
            //CallCars cars = new CallCars();
            //cars.PrintCars();

            //Product Catalogue
            CallProductCatalogue catalogueManager = new CallProductCatalogue();
            catalogueManager.AddInitialProducts();
            catalogueManager.ShowProducts();
            catalogueManager.RemoveProduct("Milk");
            catalogueManager.ShowProducts();
            catalogueManager.showTotalPrice();
            catalogueManager.FindProduct("Potatoes");

            // Students
            StudentRegistry studentManager = new StudentRegistry();
            studentManager.AddingInitialStudents();
            studentManager.ShowAllStudents();
            studentManager.RemoveStudent("Mark", "Zuckerberg");
            studentManager.AddStudent("Lisa", "Kudrow", [4, 6, 5]);
            studentManager.ShowAllStudents();
            studentManager.FindStudent("Albert");
            studentManager.TotalAverageGrade();
            studentManager.CallingAverageGrade("Lisa", "Kudrow");
        }
    }
}