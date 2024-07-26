using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_3.Models
{
    public class ScientificBook : Book
    {
        public string Subject { get; set; }

        public ScientificBook(string title, string author, int year, string subject) : base(title, author, year)
        {
            Subject = subject;
        }

        public override string ToString()
        {
            return base.ToString() + $", subject: {Subject}";
        }
    }
}
