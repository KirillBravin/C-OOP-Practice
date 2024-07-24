using C_PracticeClassesAndObjects.Models.Exercises.Exercise_5;
using C_PracticeClassesAndObjects.Models.Exercises.Exercise1;
using C_PracticeClassesAndObjects.Models.Exercises.Exercise2;
using C_PracticeClassesAndObjects.Models.Exercises.Exercise3and4;
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
            //Product Catalogue

            //CallProductCatalogue catalogueManager = new CallProductCatalogue();
            //catalogueManager.AddInitialProducts();
            //catalogueManager.ShowProducts();
            //catalogueManager.RemoveProduct("Milk");
            //catalogueManager.ShowProducts();
            //catalogueManager.showTotalPrice();
            //catalogueManager.FindProduct("Potatoes");

            // Students

            //StudentRegistry studentManager = new StudentRegistry();
            //studentManager.AddingInitialStudents();
            //studentManager.ShowAllStudents();
            //studentManager.RemoveStudent("Mark", "Zuckerberg");
            //studentManager.AddStudent("Lisa", "Kudrow", [4, 6, 5]);
            //studentManager.ShowAllStudents();
            //studentManager.FindStudent("Albert");
            //studentManager.TotalAverageGrade();
            //studentManager.CallingAverageGrade("Lisa", "Kudrow");

            // Exercises
            // Exercise 1

            CallAutos cars = new CallAutos();
            cars.ShowAutos();

            // Exercise 2

            Exercise2 user = new Exercise2();
            user.UserAge();

            // Exercise 3 and 4

            Loops loops = new Loops();
            loops.ForLoop();
            loops.WhileLoop();

            // Exercise 5

            CallStudent student = new CallStudent();
            student.CheckGrade();
        }
    }
}