using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_3.Models;

namespace C_PracticeClassesAndObjects.Lessons.Lesson_8.Exercise_3.Service
{
    public class BookService
    {
        private List<Book> books = new List<Book>();

        public void Initialization()
        {
            Novel novel1 = new Novel("Never-ending Road", "Ronald Weasley", 1939, "romance");
            Novel novel2 = new Novel("The Great Gatsby", "F.Scott Fitzgerald", 1925, "tragedy");
            Novel novel3 = new Novel("To Kill a Mockingbird", "Harper Lee", 1960, "Southern Gothic");

            ScientificBook scientificBook1 = new ScientificBook("Brave New World", "Aldous Huxley", 1932, "science fiction");

            books.Add(novel1);
            books.Add(novel2);
            books.Add(novel3);
            books.Add(scientificBook1);

            CountingAllBooks(books);
        }

        public void CountingAllBooks(List<Book> books)
        {
            int countNovels = 0;
            foreach (Book book in books)
            {
                if (book is Novel) {
                    countNovels++;
                }
            }
            Console.WriteLine($"Number of novels: {countNovels}");
        }
    }
}
