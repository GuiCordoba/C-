using System;
using Exercicio1.Entities;
using Exercicio1.Entities.Enums;
using System.Globalization;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departments's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());  // convertendo valor string para enumerado. O usuario ira inserir um string e a variante level ira ler e converter

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Department dept = new Department(deptName); //Instanciando o object departamento
            Worker worker = new Worker(name, level, baseSalary, dept); //Instanciando o object worker

            Console.Write("How many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM//YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                HourContract contract = new HourContract(date, valuePerHour, hours); //Instanciando o contrato

                worker.AddContract(contract);  //adicionando um contrato ao trabalhador
            }

            Console.WriteLine();

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2)); //dividindo a string monthYear em ano e mes
            int year = int.Parse(monthYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine("Income for " + monthYear + ": " + worker.Income(month, year)); 
        }
    }
}