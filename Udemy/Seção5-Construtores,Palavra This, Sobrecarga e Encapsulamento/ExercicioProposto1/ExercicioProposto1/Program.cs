using System.Globalization;
namespace ExercicioProposto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta  c;

            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial: ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c = new Conta(conta, titular, saldo);
            }
            else
            {
                c = new Conta(conta, titular);
            }


            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Insira o valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(quantia);

            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Insira o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(quantia);

            Console.WriteLine(c);
        }
    }
}