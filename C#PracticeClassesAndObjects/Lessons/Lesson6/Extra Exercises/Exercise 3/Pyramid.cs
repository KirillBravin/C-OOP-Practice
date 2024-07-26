using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Extra_Exercises.Exercise_3
{
    // In progress..
    public class Pyramid
    {
        public void ConstructingPyramid()
        {
            Console.WriteLine("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());
            int area = input - 1;

            for (int i = 0; i < input; i++)
            {
                for (double j = 0; j < input*2-1; j++)
                {
                    //Console.Write("*");
                    //if ()
                    //{
                    //    Console.Write("*");
                    //}
                }

                Console.WriteLine();
            }
        }
    }
}
