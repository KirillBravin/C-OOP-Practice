using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_1.Models
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }

        public Vehicle(string brand, string model, int maxSpeed)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, MaxSpeed: {MaxSpeed} km/h";
        }
    }
}
