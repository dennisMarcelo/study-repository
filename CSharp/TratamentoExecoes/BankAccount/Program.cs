using BankAccount.Entities;
using BankAccount.Entities.Exceptions;
using System.Globalization;

namespace BankAccount
{
    class Program
    {
        public static void Main(string[] args)
        {
            // parte 1 
            Console.WriteLine("Enter account data: \n");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n");


            // parte 2 
            Account account = new Account(number, holder, balance, limit);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.WithDraw(amount);
                Console.WriteLine(account.ToString());
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}