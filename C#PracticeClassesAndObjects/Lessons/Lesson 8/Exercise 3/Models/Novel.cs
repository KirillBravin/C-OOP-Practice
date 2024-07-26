using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_3.Models
{
    public class Novel : Book
    {
        public string Genre { get; set; }

        public Novel (string title, string author, int year, string genre) : base (title, author, year) 
        {
            Genre = genre;
        }

        public override string ToString()
        {
            return base.ToString() + $", genre: {Genre}";
        }
    }
}
