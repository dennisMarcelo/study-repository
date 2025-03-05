using Product.Order.Entities.Enums;
using System.Globalization;

namespace Product.Order
{
    using Product.Order.Entities;
    
    class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);

            Console.WriteLine("How many items to this order?");
            int qttOrders = int.Parse(Console.ReadLine());

            for(int i = 0; i < qttOrders; i += 1)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qttProducts = int.Parse(Console.ReadLine());
                
                Product product = new Product(nameProduct, price);
                OrderItem orderItem = new OrderItem(qttProducts, price, product);

                order.addItem(orderItem);
            }

            Console.WriteLine(order);
        }
    }
}
