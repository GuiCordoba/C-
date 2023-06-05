using System.Globalization;
namespace ExercicioProposto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Insira as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(a);

        }
    }
}