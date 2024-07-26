using C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_1.Service;
using C_PracticeClassesAndObjects.Models.Exercises.Exercise_5;
using C_PracticeClassesAndObjects.Models.Lesson6.Banking_System;
using C_PracticeClassesAndObjects.Models.Lesson6.Exercises_with_lists;
using C_PracticeClassesAndObjects.Models.Lesson6.Exercises_with_lists.Order_System;
using C_PracticeClassesAndObjects.Models.Lesson6.Extra_Exercises.Exercise_1;
using C_PracticeClassesAndObjects.Models.Lesson6.Extra_Exercises.Exercise_2;
using C_PracticeClassesAndObjects.Models.Lesson6.Extra_Exercises.Exercise_3;
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
            Service service = new Service();
            service.Initialization();
            service.ShowAllCars();
            service.ShowAllMotorcycles();
        }
    }
}