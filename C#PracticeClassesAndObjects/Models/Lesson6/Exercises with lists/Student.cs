using C_PracticeClassesAndObjects.Models.Exercises.Exercise_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Exercises_with_lists
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

    public class StudentList
    {
        public List<Student> Students { get; set; }

        public StudentList()
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student) 
        {
            Students.Add(student);
        }

        public void ShowStudents()
        {
            foreach (Student student in Students) 
            {
                if (student.Grade < 50)
                {
                    Console.WriteLine($"{student.Name} with grade: {student.Grade}");
                }
            }
        }
    }

    public class CallStudentList()
    {
        StudentList studentList = new StudentList();

        public void AddingStudents()
        {
            studentList.AddStudent(new Student("LaraCroft", 78));
            studentList.AddStudent(new Student("TimBert", 22));
            studentList.AddStudent(new Student("SamuelJackson", 99));
            studentList.AddStudent(new Student("IndianaJones", 55));
            studentList.AddStudent(new Student("LukeSkywalker", 14));
        }

        public void ShowStudentsWithBadGrades()
        {
            studentList.ShowStudents();
        }
    }
}
