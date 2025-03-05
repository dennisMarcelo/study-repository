namespace FIle.FileInfo.IOExeptions
{
    using System.IO;
    using System.Reflection;
    using static System.Net.Mime.MediaTypeNames;

    class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = Path.GetFullPath(@"..\..\..\temp\file1.txt");
            string targetPath = Path.GetFullPath(@"..\..\..\temp\file2.txt");

            Console.WriteLine(sourcePath);
            try
            {
                // parte 1
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                // parte 2
                string[] lines = File.ReadAllLines(sourcePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

                // parte 3
                fileInfo.Delete();
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}