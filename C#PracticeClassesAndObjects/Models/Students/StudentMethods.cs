using System;
using System.Text;

namespace OOP.Models.Students
{
    public class StudentMethods
    {
        public Student[] students;
        private int lastItem;

        public StudentMethods()
        {
            students = new Student[1000];
            lastItem = 0;
        }

        public void AddStudent(string name, string lastName, int[] grades)
        {
            if (lastItem < students.Length)
            {
                students[lastItem] = new Student(name, lastName, grades);
                lastItem++;
            }
            else Console.WriteLine("Student catalogue is full.");
        }

        public void RemoveStudentByName(string name, string lastName)
        {
            for (int i = 0; i < lastItem; i++)
            {
                if (students[i] != null && students[i].Name == name && students[i].LastName == lastName)
                {
                    students[i] = students[lastItem - 1];
                    students[lastItem - 1] = null;
                    lastItem--;
                    return;
                }
            }
        }

        public Student FindStudent(string studentName)
        {
            for (int i = 0; i < lastItem; i++)
            {
                if (studentName == students[i].Name)
                {
                    return students[i];
                }
            }
            return null;
        }

        public double CalculateTotalGradeAverage()
        {
            double sum = 0;
            int counter = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    for (int j = 0; j < students[i].Grades.Length; j++)
                    {
                        sum += students[i].Grades[j];
                        counter++;
                    }
                }
            }
            return counter > 0 ? sum / counter : 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lastItem; i++)
            {
                sb.AppendLine(students[i].ToString());
            }
            return sb.ToString();
        }
    }
}