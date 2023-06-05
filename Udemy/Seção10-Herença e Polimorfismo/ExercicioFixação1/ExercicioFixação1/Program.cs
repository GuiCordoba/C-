using ExercicioFixação1.Entities;
using System.Globalization;

namespace ExercicioFixação1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Commom, used or imported (c, u, i): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'c')
                {
                    list.Add(new Products(name, price));
                }
                
                else if (type == 'u')
                {
                    Console.Write("ManufactureDate (DD/MM/YYYY): ");
                    DateOnly manufactureDate = DateOnly.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.Write("Custom fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));

                }
            }

            Console.WriteLine();
            Console.WriteLine("Prices");
            foreach (Products pro in list)
            {
                Console.WriteLine(pro.PriceTag());
            }


        }
    }
}