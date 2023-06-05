using System.Globalization;


namespace ExercicioProposto3
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() { 
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public double PontosRestantes()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
        public override string ToString()
        {

            if (Aprovado())
            {
                return "Nota final: " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) 
                    + ". Aprovado!";
            }
            else
            {
                return "Reprovado! " 
                    + "Faltaram: "
                    + PontosRestantes().ToString("F2", CultureInfo.InvariantCulture)
                    + " pontos.";
            }
        }
    }
}
