using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_1.Models
{
    public class Car : Vehicle
    {
        public int PassangerCount { get; set; }

        public Car(string brand, string model, int maxSpeed, int passangerCount ) : base (brand, model, maxSpeed)
        {
            PassangerCount = passangerCount;
        }

        public override string ToString()
        {
            return base.ToString() + $", PassengerCount: {PassangerCount}";
        }
    }
}
