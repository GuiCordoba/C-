using System.Globalization;


namespace ExercicioProposto3
{
    internal class ConversordeMoedas
    {   

        

        public static double ValorPagoReais(double dolar, int qtd)
        {
            return dolar * qtd + dolar * qtd * 0.06;
        }

    }
}
