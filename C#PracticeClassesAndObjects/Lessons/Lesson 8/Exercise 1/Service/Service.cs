using C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_1.Service
{
    public class Service
    {
        private List<Car> cars = new List<Car>();
        private List<Motorcycle> motorcycles = new List<Motorcycle>();

        public void Initialization()
        {
            Car bmw = new Car("BMW", "X1 SUV", 220, 4);
            Car audi = new Car("Audi", "Audi Q4", 232, 4);
            Car toyota = new Car("GR Supra", "X1 SUV", 270, 2);

            Motorcycle harleyDavidson = new Motorcycle(false, "Harley Davidson", "Road Glide", 230);

            cars.Add(bmw);
            cars.Add(audi);
            cars.Add(toyota);
            motorcycles.Add(harleyDavidson);
        }

        public void ShowAllCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public void ShowAllMotorcycles()
        {
            foreach (Motorcycle motorcycle in motorcycles)
            {
                Console.WriteLine(motorcycle);
            }
        }
    }
}
