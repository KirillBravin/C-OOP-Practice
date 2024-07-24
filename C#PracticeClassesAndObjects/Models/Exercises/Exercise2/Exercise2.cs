using System;

namespace C_PracticeClassesAndObjects.Models.Exercises.Exercise2
{
    public class Exercise2
    {
        public void UserAge()
        {
            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 0)
            {
                if (age >= 18 && age < 75)
                {
                    Console.WriteLine("You are of legal age.");
                }
                else if (age >= 75)
                {
                    Console.WriteLine("You are a senior.");
                }
                else Console.WriteLine("You are not of legal age.");
            }
            else Console.WriteLine("Age can't be less than 0.");
        }
    }
}
