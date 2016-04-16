using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File_Sstorage
{
    class Data
    {
        List<FileStream> Files = new List<FileStream>();
        FileStream file;
        public void CreateNewFile()
        {
                file = File.Create("1.txt");
                Files.Add(file);
        }
        public void DeleteFile()
        {
                Files.Remove(file);
        }
        public void ChangeFile()
        {
            using (FileStream file = File.OpenWrite("1.txt"))

            {
               string value = Console.ReadLine();
                Byte[] info =
                  new UTF8Encoding(true).GetBytes(value);

                
                file.Write(info, 0, info.Length);
            }
        }
        public void ReadFile()
        {
                using (FileStream file = File.OpenRead("1.txt"))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (file.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine(temp.GetString(b));
                    }
            }
        }

    }
}
