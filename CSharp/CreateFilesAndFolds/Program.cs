/* 
    É possivel usar a classe Directory para criar, excluir, copiar, mover e
    manipular de alguma outra forma os diretórios de um sistema.

    É possível usar uma classe análoga, File, para fazer o mesmo com os arquivos.
*/

namespace CreateFilesAndFolds
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria novo diretório
            Console.WriteLine(Directory.GetCurrentDirectory());
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores","201","newDir"));

            // verifica se o diretório existe
            bool doesDirectoryExist = Directory.Exists("stores");
            Console.WriteLine(doesDirectoryExist);

            // Cria e edita novo arquivo
            // ele sobre escreve o arquivo e o 'hello word' some.
            string directoryOfSalesReporte = Path.Combine(Directory.GetCurrentDirectory(), "stores", "report.txt");
            File.WriteAllText(directoryOfSalesReporte, "Hello Word!");
            File.WriteAllText(directoryOfSalesReporte, "Report 2");
        }
    }
}