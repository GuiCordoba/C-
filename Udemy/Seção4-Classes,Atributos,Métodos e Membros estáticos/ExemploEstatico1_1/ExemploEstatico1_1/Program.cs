using System.Globalization;
namespace ExemploEstatico1_1
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {


            Console.Write("Insira o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi);
        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}