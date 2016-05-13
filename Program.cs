using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_Sstorage
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Check();
            Console.ReadKey();
        }
    }
}
