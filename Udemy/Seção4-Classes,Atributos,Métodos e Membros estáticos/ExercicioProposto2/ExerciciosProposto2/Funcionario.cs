using System.Globalization;


namespace ExerciciosProposto2
{
    internal class Funcionario
    {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100); 
        }


        public override string ToString()
        {
            return "Funcionario: " + Nome + ", $" + SalarioLiquido().ToString(CultureInfo.InvariantCulture);
        }
    }
}
