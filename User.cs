using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace File_Sstorage
{
    class User
    {
        public void Check()
        {
            mark:
            Console.WriteLine("Enter Login:");
            string login = Console.ReadLine();
            if (login == "user")
            {
                Console.WriteLine("Welcome user!");
                UserPanel();
            }
            else if (login == "admin")
            {
                mark1:
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();
                if (password == "password")
                {
                    Console.WriteLine("Welcome admin!");
                    AdminPanel();
                }
                else
                {
                    Console.WriteLine("Wrong password! Try again!");
                    goto mark1;
                }
            }
            else
            {
                Console.WriteLine("Wrong Login! Try Again!");
                goto mark;
            }


        }
        static void AdminPanel()
        {
            mark:
            Console.WriteLine("To create file write 'create'\nTo delete file write 'delete'\nTo change file write 'change'\nTo read file write 'open'");
            string word = Console.ReadLine();
            Data data = new Data();
            if (word == "create")
                data.CreateNewFile();
            else if (word == "delete")
                data.DeleteFile();
            else if (word == "change")
                data.ChangeFile();
            else if (word == "open")
                data.ReadFile();
            else
                Console.WriteLine("You wrote something wrong! Try again!");
            goto mark;

        }
        static void UserPanel()
        {
            mark1:
            Console.WriteLine("To read file write 'open'");
            string word = Console.ReadLine();
            Data data = new Data();
            if (word == "open")
                data.ReadFile();
            else
                Console.WriteLine("You wrote something wrong! Try again!");
            goto mark1;
        }
    }
}
