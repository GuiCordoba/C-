using System.Globalization;


namespace ExemploEstatico1_1
{
    internal class Circunferencia
    {
        public double Pi = 3.14;
        public double raio;

        public double Circun(double r)
        {
            return 2.0 * Pi * r;
        }
        public double Volume(double r)
        {
            return 4 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}
