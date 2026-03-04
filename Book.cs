using System;
using System.Collections.Generic;
using System.Text;

namespace Book_KeeperV2
{
    public class Book
    {
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public int StarRating { get; set; }
        public string? Title { get; set; }
        public bool Reccomendation { get; set; }

        //Book newbook = new Book();
        public static Dictionary<string, Book> Library = new Dictionary<string, Book>();

        public static Book AddBook()
        {
            Console.WriteLine("Enter the name of the Book you want to add: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the Author's name: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter the genre of the Book you want to add: ");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter the number of stars you want to add: ");
            int starrating = int.Parse(Console.ReadLine());
            Console.WriteLine("Would you reccomend this book true/false: ");
            string reccomend = Console.ReadLine();
            bool userreccomend = bool.Parse(reccomend);

            Book newbook = new Book
            {
                Title = title,
                Genre = genre,
                StarRating = starrating,
                Author = author,
                Reccomendation = userreccomend

            };
            Library.Add(newbook.Title, newbook);
            return newbook;



        }
        public static void RemoveBook()//Using Dictionary
        {
            Console.WriteLine("Enter the name of the book you want to remove: ");
            string BookToRemove = Console.ReadLine();
            if (!Library.ContainsKey(BookToRemove))
            {
                Console.WriteLine("Book not found, try another Title");
                return;
            }
            else
            {
                Library.Remove(BookToRemove);
            }

        }
        public static void SortBook() //ascending order based on starrating
        {
            Console.WriteLine(" Sort in ascending order based on Star Rating");
            var ascendingsort = Library.OrderBy(book => book.Value.StarRating);

            foreach (var book in ascendingsort)
            {
                Console.WriteLine($"Title: {book.Value.Title}, Author: {book.Value.Author}, Genre: {book.Value.Genre}, Star Rating {book.Value.StarRating}, Would reccomend {book.Value.Reccomendation}");
            }
        }
        public static void SearchBookDictionary()
        {
            Console.WriteLine(" Enter the Title of the book ");
            string titlesearch = Console.ReadLine();
            if (!Library.ContainsKey(titlesearch))
            {
                Console.WriteLine($"{titlesearch} not found");
            }
            else
            {
                Book foundbook = Library[titlesearch];
                Console.WriteLine($"Title: {foundbook.Title}, Author: {foundbook.Author}, Genre: {foundbook.Genre}, Star Rating {foundbook.StarRating}, Would reccomend {foundbook.Reccomendation}");//hmm not quite
            }

        }
        public static void ViewReccomendedBooks()
        {
            Console.WriteLine("Here are the books that are reccomended: ");
            var reccomendedbooks = Library.Where(book => book.Value.Reccomendation == true);
            foreach (var book in reccomendedbooks)
            {
                Console.WriteLine($"Title: {book.Value.Title}, Author: {book.Value.Author}, Genre: {book.Value.Genre}, Star Rating {book.Value.StarRating}, Would reccomend {book.Value.Reccomendation}");
            }
        }
    }
}

