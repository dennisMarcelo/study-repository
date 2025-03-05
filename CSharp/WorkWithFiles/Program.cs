using System.IO;

namespace WorkWithFiles 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listar todos os 'diretórios' dentro da pasta stores:");
            IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");
            foreach (var dir in listOfDirectories) {
                Console.WriteLine(dir);
            }

            Console.WriteLine(""); // ---------------------------------------------------------------

            Console.WriteLine("Listar todos os 'arquivos' dentro da pasta stores:");
            IEnumerable<string> files = Directory.EnumerateFiles("stores");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine(""); // ---------------------------------------------------------------

            Console.WriteLine("Listar todo o conteúdo de um diretório e todos os subdiretórios");
            IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("stores", "*", SearchOption.AllDirectories);
            foreach (var file in allFilesInAllFolders)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine(""); // ---------------------------------------------------------------

            Console.Write("Diretório atual: ");
            Console.WriteLine(Directory.GetCurrentDirectory());

            Console.WriteLine(""); // ---------------------------------------------------------------

            Console.WriteLine("Retorna a PÁGINA INICIAL do usuário para todos os sistemas operacionaise ");
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine(docPath);

            Console.WriteLine(""); // ---------------------------------------------------------------

            Console.WriteLine("Juntando diretório de acordo com o sistema operaciona com o 'Path.Combine()'");
            Console.WriteLine(Path.Combine("stores","201"));

            Console.WriteLine(""); // ---------------------------------------------------------------

            Console.WriteLine("pegar a extenção do arquivo com o 'Path.GetExtension()'");
            Console.WriteLine(Path.GetExtension("sales.json"));

            Console.WriteLine(""); // ---------------------------------------------------------------


            string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";
            FileInfo info = new FileInfo(fileName);
            Console.WriteLine(
                $"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"
            );
        }
    }
}