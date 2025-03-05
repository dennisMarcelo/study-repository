using Contract.Calculator.Entities;
using Contract.Calculator.Entities.Enums;
using System.Globalization;

namespace Contract.Calculator
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter departament's name: ");
            string depName = Console.ReadLine();
 
            // data Worker
            Console.WriteLine("------------ Enter worker data ------------");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(depName);

            Worker worker = new Worker(name, level, baseSalary, dept);

            // Contracts
            Console.WriteLine("------------ Contracts ------------");
            Console.Write("How many contracts to this worker? ");
            int n  = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 1)
            {
                Console.WriteLine($"Enter #{i} contract");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourCrontract contract = new HourCrontract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] monthAndYear = Console.ReadLine().Split("/");
            int mouth = int.Parse(monthAndYear[0]);
            int year = int.Parse(monthAndYear[1]);

            Console.WriteLine("");
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for: {string.Join("/", monthAndYear)} : {worker.Income(year, mouth).ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
