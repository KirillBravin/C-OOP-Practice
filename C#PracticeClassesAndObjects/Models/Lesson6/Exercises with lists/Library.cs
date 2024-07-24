using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeClassesAndObjects.Models.Lesson6.Exercises_with_lists
{
    public class Book
    {
        public string Title { get; set; }
        public bool ForRent { get; set; }

        public Book(string title, bool forRent)
        {
            Title = title;
            ForRent = forRent;
        }
    }

    public class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void ShowBooksForRent()
        {
            foreach (Book book in Books)
            {
                if (book.ForRent) 
                {
                    Console.WriteLine($"{book.Title} is available for rent.");
                }
            }
        }
    }

    public class CallLibrary()
    {
        Library library = new Library();

        public void AddingBooks()
        {
            library.AddBook(new Book("Martin Eden", true));
            library.AddBook(new Book("War&Peace", false));
            library.AddBook(new Book("The Girl with the Dragon Tattoo", false));
            library.AddBook(new Book("The Little Prince", true));
            library.AddBook(new Book("Meditations", true));
        }

        public void ShowBooksForRent()
        {
            library.ShowBooksForRent();
        }
    }
}
