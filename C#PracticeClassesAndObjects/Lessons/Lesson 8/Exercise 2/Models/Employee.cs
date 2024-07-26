using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_2.Models
{
    public class Employee
    {
        private string FirstName { get; set; }
        protected string LastName { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName, double salary) 
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public override string ToString()
        {
            {
                return $"First name: {FirstName}, last name: {LastName}, salary: {Salary}";
            }
        }
    }
}
