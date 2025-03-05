    using System;
    using System.IO;
namespace Teset
{

    class Program
    {
        static void Main(string[] args)
        {
            TextLog("teste 1");
            TextLog("teste 2");

        }

        public static void TextLog(string text)
        {
            string sourcePath = @"c:/temp/file1.txt";
            try
            {
                using (StreamWriter sw = File.AppendText(sourcePath))
                {
                    sw.WriteLine(text);
                }
            }
            catch (
            IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        } 
    }

}