using C_PracticeClassesAndObjects.Lessons.Lesson_9.Employee_Manager.Interface;
using C_PracticeClassesAndObjects.Lessons.Lesson_9.Employee_Manager.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_9.Employee_Manager.Service
{
    public class EmployeeManagerService
    {
        List<IEmployee> employees = new List<IEmployee>();
        string filePathEmployees = @"D:\\Projects coding\\c#\\Objects and Classes\\C#PracticeClassesAndObjects\\C#PracticeClassesAndObjects\\Lessons\\Lesson 9\\Employee Manager\\Output\\Employees.txt";

        public void Initialization()
        {
            ShowConsole();
        }

        public void ShowConsole()
        {
            while (true)
            {
                Console.WriteLine("1. Show all employees.");
                Console.WriteLine("2. Add a new employee.");
                Console.WriteLine("3. Add a new manager.");
                Console.WriteLine("0. Exit.");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Displaying all employees:");
                        foreach(Employee employee in employees)
                        {
                            employee.ReadData(filePathEmployees);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Insert a name: ");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine("Insert age: ");
                        int employeeAge = int.Parse(Console.ReadLine());
                        Employee newEmployee = new Employee(employeeName, employeeAge);
                        employees.Add(newEmployee);
                        newEmployee.WriteData(filePathEmployees, newEmployee);
                        break;
                    case "3":
                        Console.WriteLine("Insert a name: ");
                        string managerName = Console.ReadLine();
                        Console.WriteLine("Insert age: ");
                        int managerAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("Number of employees this manager has: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());
                        Manager newManager = new Manager(managerName, managerAge, numberOfEmployees);
                        employees.Add(newManager);
                        newManager.WriteData(filePathEmployees, newManager);
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
