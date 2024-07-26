using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Extra_Exercises.Exercise_1
{
    public class Fizz
    {
        public void FindFizz()
        {
            for (double i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    Console.WriteLine(i);
                } else Console.WriteLine("Fizz");
            }
        }
    }
}
