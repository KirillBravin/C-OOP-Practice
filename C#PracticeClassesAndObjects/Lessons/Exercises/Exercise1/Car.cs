using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Exercises.Exercise1
{
    public class Car
    {
        public string Mark { get; set; }
        public int Year { get; set; }

        public Car(string mark, int year)
        {
            Mark = mark;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Mark} {Year}";
        }
    }


    public class CallAutos
    {
        Car car1 = new Car("BMW", 2002);
        Car car2 = new Car("Audi", 2016);

        Car[] cars;

        public CallAutos()
        {
            cars = new Car[2];
            cars[0] = car1;
            cars[1] = car2;
        }

        public void ShowAutos()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
