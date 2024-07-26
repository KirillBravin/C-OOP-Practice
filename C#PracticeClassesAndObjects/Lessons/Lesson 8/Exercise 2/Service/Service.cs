using C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_2.Service
{
    public class Service
    {
        private List<Programmer> programmers = new List<Programmer>();
        private List<Tester> testers = new List<Tester>();

        public void Initialization()
        {
            Programmer johnSteven = new Programmer("John", "Steven", 3400.33, "C++");
            Programmer hermioneGranger = new Programmer("Hermione", "Granger", 5400.33, "C++");
            Programmer noraValletta = new Programmer("Nora", "Valletta", 2400.33, "JavaScript");

            Tester maxCrow = new Tester("Max", "Crow", 1500.44, false);

            programmers.Add(johnSteven);
            programmers.Add(hermioneGranger);
            programmers.Add(noraValletta);

            testers.Add(maxCrow);

            AddExperience(maxCrow);
        }

        public void AddExperience(Tester tester)
        {
            tester.GainExperience();
        }

        public void ShowAllEmployees(List<Programmer> programmers, List<Tester> testers)
        {
            foreach (Programmer programmer in programmers)
            {
                Console.WriteLine(programmer);
            }

            foreach (Tester tester in testers)
            {
                Console.WriteLine(tester);
            }
        }

        public void ShowingAllEmployees()
        {
            ShowAllEmployees(programmers, testers);
        }
    }
}
