using Product.Order.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Product.Order.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order( OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            string specifier;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(Client.BirhDate.ToString("dd/MM/yyyy") + " - ");
            sb.AppendLine(Client.Email);

            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {

                sb.Append(item.Product.Name + ", ");
                sb.Append("$" + item.Product.Price.ToString("N2", CultureInfo.InvariantCulture) + ", ");
                sb.Append("Quantity: ");
                sb.Append(item.Quantity + ", ");
                sb.Append("Subtotal: ");
                sb.AppendLine("$" + item.SubTotal().ToString("N2", CultureInfo.InvariantCulture));
            }

            sb.Append("Total price: ");
            sb.AppendLine("$" + Total().ToString("N2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
