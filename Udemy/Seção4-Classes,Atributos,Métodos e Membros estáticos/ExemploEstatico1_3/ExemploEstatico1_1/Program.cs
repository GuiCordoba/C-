using System.Globalization;
namespace ExemploEstatico1_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            

            Console.Write("Insira o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia.Circun(raio);
            double volume = Circunferencia.Volume(raio);


            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Circunferencia.Pi.ToString("F", CultureInfo.InvariantCulture));
        }

     
    }
}