using System;

namespace OOP.Models.Students
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int[] Grades { get; set; }

        private int lastItem = 0;
        public Student (string name, string lastName, int[] grades) 
        {
            Name = name;
            LastName = lastName;
            Grades = grades;
        }

        public void AddGrade(int grade)
        {
            if (lastItem < Grades.Length)
            {
                Grades[lastItem] = grade;
                lastItem++;
            }
        }

        public double AverageGrade(Student student)
        {
            double sum = 0;
            for (int i = 0; i < student.Grades.Length; i++)
            {
                sum+= student.Grades[i];
            }
            return sum = sum / student.Grades.Length;
        }

        public override string ToString()
        {
            return $"{Name} {LastName} {string.Join(", ", Grades)}";
        }
    }
}
