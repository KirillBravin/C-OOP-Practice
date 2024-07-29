using C_PracticeClassesAndObjects.Lessons.Lesson_9.Employee_Manager.Models;


namespace C_PracticeClassesAndObjects.Lessons.Lesson_9.Employee_Manager.Interface;

public interface IEmployee
{
    void WriteData(string filePath, Employee content);
    void ReadData(string filePath);
}
