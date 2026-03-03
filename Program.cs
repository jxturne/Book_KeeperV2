namespace Book_KeeperV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to BookKeeperV2");

            Console.WriteLine("Would you like to 1. Add a new Book, 2. Remove a book, 3. Rate a Book, or 4. Search for a Book, 5 exit the Application ?");
            string input = Console.ReadLine();
            if( int.TryParse(input, out int result) && result>=1 && result<=5) // this needs to check if the response is num 1-4
            {
                Console.WriteLine($" Valid Selection.");
            }
            else
            {
                Console.WriteLine("Invalid Option please try again. ");
                return;
            }

            switch(input)
            {
                case "1":
                    Book.AddBook();
                    break;

                case "2":
                    Book.RemoveBook();
                    break;
                case "3":
                    Book.SortBook();
                    break;
                case "4":
                    Book.SearchBook(); // not created
                    break;
                case "5":
                    return; //how to shut it down again?


            }


            //Book newbook = new Book();
            //Dictionary<string, Book> Library = new Dictionary<string, Book>();


            //newbook.Title = "Call of the Wild"; newbook.Author = "whoever"; newbook.StarRating = 4; newbook.Genre = "Fiction"; //testing 

            //Library.Add(newbook.Title, newbook);// okay so that part works now i need to add user input and seee about spectreConsole

        }
    }
}
