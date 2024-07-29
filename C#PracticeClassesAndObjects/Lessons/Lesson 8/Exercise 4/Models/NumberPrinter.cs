using C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_4.Service
{
    public class NumberPrinter : INumberPrinter
    {
        public void PrintingNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
