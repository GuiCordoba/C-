using System;
using System.Globalization;

namespace ExemploVetores1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect= new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe as alturas: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i =0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("A média das alturas é: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}