using Exercicio_3.Entities.Enums;
using System.Globalization;

using System.Text;

namespace Exercicio_3.Entities
{
    internal class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { 
        }

        public Order(DateTime momment, OrderStatus status, Client client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem) {
            Items.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem) {
            Items.Remove(orderItem);
        }

        public double Total() {
            double sum = 0.0;
            foreach (OrderItem items in Items)
            {              
                sum =+ items.SubTotal();
            }
            return sum;  
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMARY: ");
            sb.AppendLine("Order Moment: " + Momment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Ordem status: " + Status);
            sb.AppendLine("Client: " + Client.NameClient + ", " + Client.DateOfBirth + ", " + Client.Email);
            sb.AppendLine("ORDER ITEM:");

            foreach(OrderItem items in Items)
            {
                sb.AppendLine(items.ToString());
            }

            sb.AppendLine("Total Price: " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
