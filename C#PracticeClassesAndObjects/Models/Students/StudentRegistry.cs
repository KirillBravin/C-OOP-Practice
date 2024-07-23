using System;

namespace OOP.Models.Students
{
    public class StudentRegistry
    {
        private StudentMethods studentMethods = new StudentMethods();

        public void AddingInitialStudents()
        {

            studentMethods.AddStudent("Mark", "Zuckerberg", new int[] { 6, 4, 2 });
            studentMethods.AddStudent("Willem", "Dafoe", new int[] { 9, 6, 10, 7 });
            studentMethods.AddStudent("Albert", "Einstein", new int[] { 10, 10, 9, 8, 10 });
            
        }

        public void ShowAllStudents()
        {
            Console.WriteLine(studentMethods);
        }

        public void RemoveStudent(string name, string lastName)
        {
            studentMethods.RemoveStudentByName(name, lastName);
        }

        public void AddStudent(string name, string lastName, int[] grades)
        {
            studentMethods.AddStudent(name, lastName, grades);
        }

        public void FindStudent(string name)
        {
            Console.WriteLine(studentMethods.FindStudent(name));
        }

        public void GradeAverage()
        {
            studentMethods.CalculateTotalGradeAverage();
        }

        public void AddGrade(string name, int grade)
        {
            for (int i = 0; i < studentMethods.students.Length; i++)
            {
                if (name == studentMethods.students[i].Name)
                {
                    // A little bit of google-foo here to assign new elements to existing
                    // array and not using Lists
                    int[] currentGrades = studentMethods.students[i].Grades;
                    int[] newGrades = new int[currentGrades.Length + 1];
                    Array.Copy(currentGrades, newGrades, currentGrades.Length);
                    newGrades[newGrades.Length - 1] = grade;
                    studentMethods.students[i].Grades = newGrades;
                    break;
                }
            }
        }

        public void TotalAverageGrade()
        {
            double average = Math.Round(studentMethods.CalculateTotalGradeAverage(), 2);
            Console.WriteLine($"Total average: {average}");
        }

        public void CallingAverageGrade(string name, string lastName)
        {
            double average = Math.Round(AverageGrade(name, lastName), 2);
            Console.WriteLine($"Average for student {name} {lastName}: {average}");
        }

        public double AverageGrade(string name, string lastName)
        {
            double arrSum = 0;
            double counter = 0;
            for (int i = 0; i < studentMethods.students.Length; i++)
            {
                if (studentMethods.students[i] != null)
                {
                    if (name == studentMethods.students[i].Name && lastName == studentMethods.students[i].LastName)
                    {
                        for (int j = 0; j < studentMethods.students[i].Grades.Length; j++)
                        {
                            arrSum += studentMethods.students[i].Grades[j];
                            counter++;
                        }
                    }
                }
            }
            return counter > 0 ? arrSum / counter : 0;
        }
    }
}
