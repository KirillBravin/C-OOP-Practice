using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_2.Models
{
    public class Programmer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Programmer(string firstName, string lastName, double salary, string programmingLanguage) : base (firstName, lastName, salary) 
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public void ChangeLanguage(string language)
        {
            ProgrammingLanguage = language;
        }

        public override string ToString() 
        {
            return base.ToString() + $", Programming language: {ProgrammingLanguage}";
        }
    }
}
