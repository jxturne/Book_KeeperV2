using System;
using System.Collections.Generic;
using System.Text;

namespace Book_KeeperV2
{
    public class Search
    {

        public static Book LinearSearchTitle(string title)
        {
            foreach (var book in Book.Library.Values)
            {
                if (string.Equals(book.Title, title, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found book: {book.Title} by {book.Author}");
                    return(book);
                }
            }
            Console.WriteLine("No book found with that title.");
            return null;
        }
           
        

        public static  List<Book> LinearSearchAllAuthor(string author)
        {
            List<Book> foundBooks = new List<Book>();

            foreach (var book in Book.Library.Values)
            {
                if (string.Equals(book.Author, author, StringComparison.OrdinalIgnoreCase))

                {
                    foundBooks.Add(book);
                }
            }
            if (foundBooks.Count > 0)
            {
                Console.WriteLine($"Found {foundBooks.Count} book(s) by {author}:");
                foreach(var books in foundBooks)
                {
                    Console.WriteLine($" {books.Title}");
                }
            }
            else
            {
                Console.WriteLine("No books found by that author.");
            }

            return foundBooks;
        }
    }
}
