using System.Globalization;

namespace ExercicioProposto1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a Largura e Altura do Retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r);

        }
    }
}