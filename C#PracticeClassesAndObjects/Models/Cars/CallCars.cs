using System;

namespace OOP.Models.Cars
{
    public class CallCars
    {
        Car car1 = new Car("Audi", "Red");
        Car car2 = new Car("BMW", "Black");

        Car[] cars;

        public CallCars() 
        { 
            cars = new Car[2];
            cars[0] = car1;
            cars[1] = car2;
        }

        public void PrintCars()
        {
            foreach(var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
