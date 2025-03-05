/* 
    A classe File pode ser usada para ler e gravar dados em arquivos
    o Pacote Newtonsoft.Json

    foi utilizado o pacote 'Newtonsoft.Json'
*/

using Newtonsoft.Json;

namespace CreateFilesAndFolds
{
    class SalesTotal
    {
        public double Total { get; set; }
        public int Products {get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string directoryFile = Path.Combine("store", "sales.json");

            // Lê todo arquivo em formato de texto
            string salesJson = File.ReadAllText(directoryFile);
            Console.WriteLine(salesJson);

            // O JsonConvert é usado para converter a string para json 
            var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);
            Console.WriteLine(salesData.Total);
            Console.WriteLine(salesData.Products);
            
            // Gravar dados em arquivo sobrescrevendo anterior
            File.WriteAllText($"store{Path.DirectorySeparatorChar}totals.txt", $"{salesData.Total.ToString()} \n");

            // Grava novos dados e manter os antigos
            // Environment.NewLine solicita ao .NET para colocar o valor em uma linha própria.
            File.AppendAllText($"store{Path.DirectorySeparatorChar}totals.txt", $"relatório 2{Environment.NewLine}");
        }
    }
}



