namespace Book_KeeperV2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book preload1 = new Book();
                preload1.Title = "The Great Gatsby";
                preload1.Author = "F. Scott Fitzgerald";
                preload1.Genre = "Classic Fiction";
                preload1.StarRating = 4;
                preload1.Reccomendation = true;
            Book preload2 = new Book();
                preload2.Title = "To Kill a Mockingbird";
                preload2.Author = "Harper Lee";
                preload2.Genre = "Classic Fiction";
                preload2.StarRating = 54;
                preload2.Reccomendation = true;
            Book preload3 = new Book();
                preload3.Title = "Call of the Wild";
                preload3.Author = "Jack London";
                preload3.Genre = "Adventure Fiction";
                preload3.StarRating = 4;
                preload3.Reccomendation = true; 
            Book preload4 = new Book();
                preload4.Title = "The Chronicles of Nick";  
                preload4.Author = "Sherrilyn Kenyon";
                preload4.Genre = "Fantasy Fiction";
                preload4.StarRating = 5;
                preload4.Reccomendation = true;
            Book preload5 = new Book();
            preload5.Title = "Shadow and Bone";
                preload5.Author = "Leigh Bardugo";
                preload5.Genre = "Fantasy Fiction";
                preload5.StarRating = 3;
                preload5.Reccomendation = false;
            Book.Library.Add(preload1.Title, preload1);
            Book.Library.Add(preload2.Title, preload2);
            Book.Library.Add(preload3.Title, preload3);
            Book.Library.Add(preload4.Title, preload4);
            Book.Library.Add(preload5.Title, preload5);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello, Welcome to BookKeeperV2");
            bool on = true;

            while (on)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--------\nWould you like to \n1. Add a new Book, \n2. Remove a book \n3. View/Sort Book \n4. Search for a Book, \n5. Exit the Application\n--------");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int result) && result >= 1 && result <= 5) // this needs to check if the response is num 1-4
                {
                    

                    switch (result)
                    {
                        case 1:
                            Book.AddBook();
                            break;

                        case 2:
                            Book.RemoveBook();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sort book by \n1. Ascending Star Rating 2.Placeholder sort() by bool? reccomendation?  \n 3. Exit to Main Menu");//not completed Could be descending merge sort on would reccomendation Merge sort
                            int ui = int.Parse(Console.ReadLine());
                            if (ui >= 1 && ui <= 4)
                            {
                                if (ui == 1)
                                {
                                    Book.SortBook();
                                    break;

                                }
                                if (ui == 2)//view all books that are reccomended true/false
                                {
                                    Book.ViewRecommendedBooks();//not completed
                                    break;
                                }
                                if (ui == 3)
                                {
                                    //exit to main menu
                                    return;

                                }
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Invalid Option");
                                continue;
                            }
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Search books by \n1. Title \n 2. Author \n 3. BinarySearch  \n4. Exit ;");
                            string ui2 = Console.ReadLine();

                            if (ui2 == "1")
                            {
                                Console.WriteLine("What title");
                                string ust = Console.ReadLine();
                                Console.WriteLine(Search.LinearSearchTitle(ust));
                                break;
                            }
                            else if (ui2 == "2")
                            {
                                Console.WriteLine("What Author");
                                string usa = Console.ReadLine();
                                Console.WriteLine(Search.LinearSearchAuthor(usa));
                                break;
                            }
                            else if (ui2 == "3")
                            {
                                Console.WriteLine("Heres how many books in your library have 5 stars!");
                                string usb = Console.ReadLine();
                                //Console.WriteLine(Search.BinarySearch(usb));
                                break;
                            }

                            else if (ui2 == "4")
                            {
                                Console.WriteLine(" Quick sort using the Dictionay");
                                Book.SearchBookDictionary(); 
                                break;

                            }
                            return;



                        case 5:
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.ForegroundColor = ConsoleColor.White;
                            on = false;
                            Console.WriteLine("Exiting BookKeeperV2, See you next time!");
                            return; 
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Option please try again. ");

                }
            }
        }
    }
}
