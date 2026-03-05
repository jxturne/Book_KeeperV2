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
                    Console.WriteLine(book);
                    return book;

                }
            }
            return null;
        }
           
        

        public static Book LinearFirstSearchAuthor(string author)
        {
            foreach (var book in Book.Library.Values)
            {
                if (string.Equals(book.Author, author, StringComparison.OrdinalIgnoreCase))

                {
                    Console.WriteLine(book);
                    return book;
                }
            }
            return null;
        }


        //public static Book BinarySearch(string reccomendations)// maybe show each time a book received 5 stars.
        //{
        //    // need sorted list  

        //    int left = 0;
        //    int right = sortedlist - 1;

        //    while( left >= right)
        //    {
        //        int mid = (left + right) / 2;
        //        if (sortedlist[mid].Reccomendation == reccomendations)
        //            return sortedlist[mid];

        //        if (sortedlist[mid].reccomendation < 0)
        //        { left = mid + 1; }
        //        else
        //            right = mid - 1;
        //    }
        //    return null;
        //}
    }
}
