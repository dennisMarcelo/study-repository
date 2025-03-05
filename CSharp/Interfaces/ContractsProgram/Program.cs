using ContractsProgram.Entities;
using ContractsProgram.Services;
using System.Globalization;
namespace ContractsProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/mm/yyyy):");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            ContractsService contractsService = new ContractsService(new PaypalService());

            contractsService.ProcessContract(contract, months);

            Console.WriteLine("");
            Console.WriteLine("Installments:");

            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}