namespace Book_KeeperV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Myqueue<Member> Waitlist = new Myqueue<Member>(10); // Example usage of the waitlist with a capacity of 10 members, maybe a book club 

            Waitlist.Enqueue(new Member { FName = "John", LName = "Doe", Email = "whatever@mail.com", Id = 1 });
            Waitlist.Enqueue(new Member { FName = "Jane", LName = "Smith", Email = "whatever@mail.com", Id = 2 });
            Waitlist.Enqueue(new Member { FName = "Bob", LName = "Johnson", Email = "whatever@mail.com", Id = 3 });
            Console.WriteLine($"Waitlist count: {Waitlist.Count()}");




            Book preload1 = new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Genre = "Classic Fiction",
                StarRating = 4,
                Reccomendation = true

            };

            Book preload2 = new Book {
                Title = "To Kill a Mockingbird",
               Author = "Harper Lee",
                Genre = "Classic Fiction",
                StarRating = 3,
                Reccomendation = true
            };

            Book preload3 = new Book { 
               Title = "Call of the Wild",
                Author = "Jack London",
                Genre = "Adventure Fiction",
               StarRating = 4,
                Reccomendation = true
                };

            Book preload4 = new Book { 
                Title = "The Chronicles of Nick",  
                Author = "Sherrilyn Kenyon",
                Genre = "Fantasy Fiction",
                StarRating = 5,
                Reccomendation = true
            };

            Book preload5 = new Book { 
                Title = "Shadow and Bone",
                Author = "Leigh Bardugo",
                Genre = "Fantasy Fiction",
                StarRating = 3,
                Reccomendation = false
            };

            Book preload6 = new Book { 
                Title = "Harry Potter and the Sorcerer's Stone",
                Author = "J.K. Rowling",
                Genre = "Fantasy Fiction",
                StarRating = 4,
                Reccomendation = true
            };

            Book preload7 = new Book { 
                Title = "Harry Potter and the Chamber of Secrets",
                Author = "J.K. Rowling",
                Genre = "Fantasy Fiction",
                StarRating = 3,
                Reccomendation = true
            };
            Book preload8 = new Book { 
                Title = "Harry Potter and the Prisoner of Azkaban",
                Author = "J.K. Rowling",
                Genre = "Fantasy Fiction",
                StarRating = 4,
                Reccomendation = true
            };

            Book.Library.Add(preload1.Title, preload1);
            Book.Library.Add(preload2.Title, preload2);
            Book.Library.Add(preload3.Title, preload3);
            Book.Library.Add(preload4.Title, preload4);
            Book.Library.Add(preload5.Title, preload5);
            Book.Library.Add(preload6.Title, preload6);
            Book.Library.Add(preload7.Title, preload7);
            Book.Library.Add(preload8.Title, preload8);
    


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello, Welcome to BookKeeperV2");
            bool on = true;

            while (on)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--------\nWould you like to \n1. Add a new Book, \n2. Remove a book \n3. View/Sort Book \n4. Search for a Book \n5. Edit Book Information \n6. Exit the Application\n--------");

                string? input = Console.ReadLine();
                if (int.TryParse(input, out int result) && result >= 1 && result <= 6) // this needs to check if the response is num 1-6
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
                            Console.WriteLine("--------\nSort book by \n1. Ascending Star Rating \n2. Sort by reccomendation  \n3. Exit to Main Menu\n--------");//not completed Could be descending merge sort on would reccomendation Merge sort
                            int ui = int.Parse(Console.ReadLine());
                            if (ui >= 1 && ui <= 3)
                            {
                                if (ui == 1)
                                {
                                    Book.SortBook();
                                    break;

                                }

                                if (ui == 2)//view all books that are reccomended true/false
                                {
                                    Book.ViewReccomendedBooks();
                                    break;
                                }

                                if (ui == 3)
                                {
                                    Console.WriteLine("Exiting to Main Menu");
                                    break;

                                }

                                else 
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Invalid Option");
                                break;
                            }

                        case 4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("--------\nSearch books by \n1. By Title \n2. All books by Author \n3. BinarySearch(Development)  \n4.Dictionary search  \n5. Exit to main menu\n--------");
                            int ui2 = int.Parse(Console.ReadLine());

                            if (ui2 == 1)
                            {
                                Console.WriteLine("Enter Title");
                                string ust = Console.ReadLine();
                                Console.WriteLine(Search.LinearSearchTitle(ust).ToString());
                                break;
                            }

                            else if (ui2 == 2)
                            {
                                Console.WriteLine("Enter Author");
                                string usa = Console.ReadLine();
                                Console.WriteLine(Search.LinearSearchAllAuthor(usa).ToString());
                                break;
                            }

                            else if (ui2 == 3) // still under development, need to create sorted list and then implement binary search on that list.`
                            {
                                Console.WriteLine("Search still Under Development");
                                //string usb = Console.ReadLine();
                                //Console.WriteLine(Search.BinarySearch(usb));
                                break;
                            }

                            else if (ui2 == 4)
                            {
                                Console.WriteLine(" Quick search using the Dictionay");
                                Book.SearchBookDictionary(); 
                                break;

                            }

                            else if (ui2 == 5)
                            {
                                Console.WriteLine("Exiting to Main Menu");
                                break;
                            }

                            break;

                        case 5:
                            Console.ForegroundColor= ConsoleColor.DarkGreen;
                            Book.EditBookInformation(); 
                            break;


                        case 6:

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
