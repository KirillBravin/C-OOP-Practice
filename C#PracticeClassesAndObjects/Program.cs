﻿using C_PracticeClassesAndObjects.Models.Exercises.Exercise_5;
using C_PracticeClassesAndObjects.Models.Exercises.Exercise1;
using C_PracticeClassesAndObjects.Models.Exercises.Exercise2;
using C_PracticeClassesAndObjects.Models.Exercises.Exercise3and4;
using C_PracticeClassesAndObjects.Models.Lesson6.Exercises_with_lists;
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
            // Exercise 1

            //CallStudentList studentList = new CallStudentList();
            //studentList.AddingStudents();
            //studentList.ShowStudentsWithBadGrades();

            // Exercise 2

            //CallLibrary library = new CallLibrary();
            //library.AddingBooks();
            //library.ShowBooksForRent();

            // Exercise 3

            CallProducts products = new CallProducts();
            products.AddingProducts();
            products.CalculateProductSum();
        }
    }
}