using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_1.Models
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public Motorcycle(bool hasSideCart, string brand, string model, int maxSpeed) : base(brand, model, maxSpeed)
        {
            HasSideCart = hasSideCart;
        }

        public override string ToString()
        {
            return base.ToString() + $", HasSideCart: {HasSideCart}";
        }
    }
}
