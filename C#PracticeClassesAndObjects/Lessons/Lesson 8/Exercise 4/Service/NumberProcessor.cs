using C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_4.Service
{
    public class NumberProcessor : INumberProcessor
    {
        public void DivisableNumbers()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} is divisible by 3 and 5");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} is divisible by 3");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} is divisible by 5");
                } else Console.WriteLine($"{i} is not divisible by 3 or 5”");
            }
        }
    }
}
