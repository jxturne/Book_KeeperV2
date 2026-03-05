using System;
using System.Collections.Generic;
using System.Text;

namespace Book_KeeperV2
{
    public class Member
    {
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public int Id { get; set; }  

        static List<Member> Userlist = new List<Member>();
        public static Member AddUser()
        {
            Console.WriteLine(" Hello do you have an account with us? yes / no");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Console.WriteLine(" Please enter your first name : ");
                string fName = Console.ReadLine();
                Console.WriteLine(" Please enter your last name : ");
                string lName = Console.ReadLine();
                Console.WriteLine(" Please enter Email : ");
                string email = Console.ReadLine();
                Console.WriteLine(" Please enter your ID # : ");
                int ID  = int.Parse(Console.ReadLine());

                Member newUser = new Member
                {
                    FName = fName,
                    LName = lName,
                    Email = email,
                    Id = ID

                };
                Userlist.Add(newUser);
                return newUser;

            }
            else if (response == "no")
            {
                return null;
            }
            else
                Console.WriteLine(" Invalid response please select yes or no! ");
            return null;
        }

        public static bool RemoveUser()
        {
            Console.WriteLine(" Please enter the ID # of the user you want to remove : ");
            string userremove = Console.ReadLine();

            if (!int.TryParse(userremove, out int userId))
            {
                Console.WriteLine(" Invalid ID format. Please enter a valid number.");
                return false;
            }

            Member memberToRemove = Userlist.Find(m => m.Id == userId);
            if (memberToRemove == null)
            {
                Console.WriteLine(" User with that ID not found.");
                return false;
            }

            Console.WriteLine($" Are you sure you want to remove {memberToRemove.FName} {memberToRemove.LName}? yes / no");
            string confirmation = Console.ReadLine().ToLower();
            
            if (confirmation == "yes")
            {
                Userlist.Remove(memberToRemove);
                Console.WriteLine(" User removed successfully.");
                return true;
            }
            
            Console.WriteLine(" Removal cancelled.");
            return false;
        }

    }
}
