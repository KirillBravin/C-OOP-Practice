using C_PracticeClassesAndObjects.Lessons.Lesson_9.Employee_Manager.Interface;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_9.Employee_Manager.Models
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void WriteData(string filePath, Employee employee)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Name {employee.Name} Age: {employee.Age}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadData(string filePath)
        {
            try
            {
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
