using System;
using Exemplo1.Entities;

namespace Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(0210, "Guilherme Cordoba", 350.00, 2000.00);

            Console.WriteLine(account.Holder);
        }
    }
}