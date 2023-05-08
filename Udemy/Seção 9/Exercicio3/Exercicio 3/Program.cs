using Exercicio_3.Entities;
using Exercicio_3.Entities.Enums;
using System;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER CLIENT DATA: ");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Date of bith (DD/MM/YYYY): ");
            DateOnly dateOfBirth = DateOnly.Parse(Console.ReadLine());


            Console.WriteLine("ENTER ORDER DATA: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());


            Client client = new Client(nameClient, email, dateOfBirth); //Estancionado o cliente
            Order order = new Order(DateTime.Now,orderStatus, client);


            Console.Write("How many items to this oerder: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1;i <= n;i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(name, price);

                Console.Write("Quantity: ");
                int quantityProd = int.Parse(Console.ReadLine());

                
                OrderItem Items = new OrderItem(quantityProd, price, product);

                order.AddItem(Items);
            }

            Console.WriteLine();
            Console.WriteLine(order);

            

        }
    }
}