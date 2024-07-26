using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_2.Models
{
    public class Tester : Employee
    {
        public bool HasAutomationExperience { get; set; }

        public Tester(string firstName, string lastName, double salary, bool hasAutomationExperience) : base (firstName, lastName, salary)
        {
            HasAutomationExperience = hasAutomationExperience;
        }

        public void GainExperience()
        {
            if (HasAutomationExperience == false)
            {
                HasAutomationExperience = true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", automation experience: {HasAutomationExperience}";
        }
    }
}
