using ExercicioProposto.Entitties;
using System.Globalization;
using System;
using ExercicioProposto.Entitties.Exceptions;

namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, initialBalance, withdrawLimit);

            Console.WriteLine("");

            Console.Write("Enter the amount of withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                account.Withdraw(amount);
                Console.WriteLine("-> New balance: " + account.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in withdraw: " + e.Message);
            }

        }
    }
}