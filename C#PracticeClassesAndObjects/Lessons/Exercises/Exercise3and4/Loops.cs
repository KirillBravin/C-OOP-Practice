using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Exercises.Exercise3and4
{
    public class Loops
    {
        public void ForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }

        public void WhileLoop()
        {
            int counter = 0;
            while (counter <= 5)
            {
                Console.Write($"{counter} ");
                counter++;
            }
        }
    }
}
