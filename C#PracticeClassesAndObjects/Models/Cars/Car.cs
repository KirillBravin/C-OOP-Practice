using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP.Models.Cars
{
    public class Car
    {
        public string Mark { get; set; }
        public string Color { get; set; }


        public Car (string mark, string color)
        {
            Mark = mark;
            Color = color;
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }

        public override string ToString()
        {
            return $"{Mark} {Color}";
        }
    }
}
