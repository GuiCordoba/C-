using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Xml.Schema;
using ExercicioFixação2.Entities;

namespace ExercicioFixação2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Imcome: ");
                double anualImcome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualImcome, healthExpenditures));
                }
                else
                {
                    Console.Write("Numbers of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualImcome, numberOfEmployees));
                }

            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + " - $" + tp.Tax().ToString("F2", CultureInfo.InvariantCulture) );
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine("Total Taxes - $" + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}