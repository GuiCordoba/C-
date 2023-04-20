using System.Runtime.CompilerServices;
using System.Globalization;
using System.Numerics;
using System.Net.Http.Headers;
using System.Diagnostics.CodeAnalysis;

namespace ExemploVetores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produtos[] vect = new Produtos[n]; 


            for (int i = 0; i < n; i++)
            {
                Console.Write("Insira o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Insira o preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produtos {Nome = nome, Preco = preco};
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Preco;
            }
            double avg = sum / n;
            Console.WriteLine("A média de preços dos produtos é: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}