using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_9.Employee_Manager.Models
{
    public class Manager : Employee
    {
        public int NumberOfEmployees { get; set; }

        public Manager (string name, int age, int numberOfEmployees) : base (name, age)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public void WriteData(string filePath, Manager manager)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Name: {manager.Name} Age: {manager.Age} Number of Employees: {manager.NumberOfEmployees}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
