

using System.Globalization;

namespace ExercicioProposto1
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;
        

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro() { 
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }

        public override string ToString()
        {
            return "Area: " 
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                +", Perimetro: "
                + Perimetro().ToString("F2",CultureInfo.InvariantCulture)
                + ", Diaginal: "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
