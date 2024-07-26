using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Extra_Exercises.Exercise_2
{
    public class UserArray
    {
        public void CreateUserArray()
        {

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Please enter a number for array element of index [i]:");
                array[i] = int.Parse(Console.ReadLine());
            }
            int smallestNumber = array[0],
                largestNumber = array[0];

            for (int i = 0;i < array.Length; i++)
            {
                if (smallestNumber > array[i])
                {
                    smallestNumber = array[i];
                }

                if (largestNumber < array[i])
                {
                    largestNumber = array[i];
                }
            }

            Console.WriteLine($"The largest number is: {largestNumber}");
            Console.WriteLine($"The smallest number is: {smallestNumber}");
        }
    }
}
