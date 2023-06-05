using System.Globalization;
namespace ExemploEstatico1_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Circunferencia c = new Circunferencia();

            Console.Write("Insira o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = c.Circun(raio);
            double volume = c.Volume(raio);


            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + c.Pi.ToString("F", CultureInfo.InvariantCulture));
        }

     
    }
}