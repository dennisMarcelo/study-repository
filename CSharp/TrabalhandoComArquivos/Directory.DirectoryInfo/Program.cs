using System;
using System.IO;

namespace Course 
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\denni\Documents";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.TopDirectoryOnly);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
     }    
}