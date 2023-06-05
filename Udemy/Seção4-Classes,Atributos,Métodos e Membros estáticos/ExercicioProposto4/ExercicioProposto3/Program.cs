using System.Globalization;
namespace ExercicioProposto3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual a cotação do dolar: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares deseja comprar: ");
            int quantidade = int.Parse(Console.ReadLine());

            double valorTotal = ConversordeMoedas.ValorPagoReais(dolar, quantidade);

            Console.WriteLine("Valor a ser pago em reais: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}