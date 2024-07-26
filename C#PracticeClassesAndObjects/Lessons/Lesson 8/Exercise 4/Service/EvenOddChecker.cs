using C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_4.Service
{
    public class EvenOddChecker : IEvenOddChecker
    {
        public void EvenOrOdd()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even");
                } else Console.WriteLine("Odd");
            }
        }
    }
}
