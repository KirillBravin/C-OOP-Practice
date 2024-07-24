using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Models.Exercises.Exercise_5
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{Name} {Grade}";
        }
    }

    public class CallStudent
    {
        Student[] students;

        public CallStudent()
        {
            students = new Student[2];

            students[0] = new Student("Andrew", 9);
            students[1] = new Student("Tom", 4);

        }
        public void CheckGrade()
        {
            for (int i = 0; i < students.Length; i++) 
            {
                if (students[i].Grade >= 5)
                {
                    Console.WriteLine($"{students[i].Name} has passed with grade: {students[i].Grade}");
                } else Console.WriteLine($"{students[i].Name} didn't pass with grade: {students[i].Grade}");
            }
        }
    }
}
