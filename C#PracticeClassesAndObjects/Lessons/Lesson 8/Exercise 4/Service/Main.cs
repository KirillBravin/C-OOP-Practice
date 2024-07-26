using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_4.Service
{
    public class Main
    {
        NumberProcessor numberProcessor = new NumberProcessor();
        NumberPrinter numberPrinter = new NumberPrinter();
        EvenOddChecker evenOddChecker = new EvenOddChecker();
        public void Initialization()
        {
            Console.WriteLine("Number processor:");
            numberProcessor.DivisableNumbers();
            Console.WriteLine("\n");
            Console.WriteLine("Number printer:");
            numberPrinter.PrintingNumbers();
            Console.WriteLine("\n");
            Console.WriteLine("Even or odd checker:");
            evenOddChecker.EvenOrOdd();
        }
    }
}
