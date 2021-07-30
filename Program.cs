using LibraryExerciseProject_OOP.BooksClasses;
using System;
using System.Collections.Generic;

namespace LibraryExerciseProject_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();
            var goldenBooks = new List<GoldenEditionBook>();

            // valid books
            var book1 = new Book("Jerusalem", "Bobby 2Brown", 21.5666);
            var goldenBook1 = new GoldenEditionBook("Jam", "Con 4Bing", 31.88);

            books.Add(book1);
            goldenBooks.Add(goldenBook1);

            // invalid books
            //var book2 = new Book("Forest", "Bear 2Grillz", -1);   //Invalid Price
            //var book3 = new Book("Forest1", "Feear 2Trillz", 0);   //Invalid Price
            //var goldenBook2 = new Book("Cartoon", "Johny Bravo", 41.88);   //Invalid Author
            //var goldenBook3 = new Book("Boogie", "Bob &Jimson", 61.499);   //Invalid Author
            

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            foreach (var goldenBook in goldenBooks)
            {
                Console.WriteLine(goldenBook);
            }
        }
    }
}
