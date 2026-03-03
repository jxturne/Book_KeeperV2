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

        //Book newbook = new Book();
         static Dictionary<string, Book> Library = new Dictionary<string, Book>();

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
            Book newbook = new Book
            {
                Title = title,
                Genre=genre,
                StarRating= starrating,
                Author = author


            };
            Library.Add(newbook.Title, newbook);
            return newbook;



        }
        public static void RemoveBook()
        {
            Console.WriteLine("Enter the name of the Book you want to remove: ");
            string BookToRemove = Console.ReadLine();
            if(!Library.ContainsKey(BookToRemove))
            {
                Console.WriteLine("Book doesnt exist");
                return;
            }
            else
            {
                Library.Remove(BookToRemove);
            }
               
        }
        public static void SortBook() //ascending order based on starrating
        {
            Console.WriteLine(" Sort in ascending order");
            var ascendingsort = Library.OrderBy(book =>book.Value.StarRating);

            foreach(var book in ascendingsort)
            {
                Console.WriteLine($"Title: {book.Value.Title}, Author: {book.Value.Author}, Genre: {book.Value.Genre}, Star Rating {book.Value.StarRating});
            }
        }
    } 
}

