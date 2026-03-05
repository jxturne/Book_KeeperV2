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
        private int ID { get; set; }
            public int id
        {
            get { return ID;  }
            set { ID = value; }  // ✅ Correct - sets the backing field
        }

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
                    id = ID

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

        public static void RemoveUser()
        {
            Console.WriteLine(" Please enter the ID # of the user you want to remove : ");
            string userremove = Console.ReadLine();

        }

    }
}
