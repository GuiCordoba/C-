using System.Globalization;


namespace ExercicioProposto1
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        private string Titular { get; set; }
        public double Saldo { get; private set; }
        


        public Conta(int conta, string titular)
        {
            NumeroConta = conta;
            Titular = titular;
            
            
        }
        public Conta(int conta, string titular, double depositoInicial) : this (conta, titular) 
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }


        public override string ToString()
        {
            return "Conta: "
            + NumeroConta + ", "
            + "Titular: "
            + Titular + ", "
            + "Saldo: R$"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
            
        }
    }
}
