using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários seram cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(" Empregado: #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
            }
            Console.WriteLine();

            Console.Write("Insira o id do funcionario que ira receber aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario s1 = list.Find(x => x.Id == idAumento);
            if (s1 != null)
            {
                Console.Write("Insira a porcentagem de aumento para o funcionario: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                s1.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Funcionario não existente!");
            }

            Console.Write("Deseja remover algum funcionario [s/n]? ");
            string remove = Console.ReadLine();
            if (remove == "s")
            {
                Console.Write("Insira o Id do funcionario: ");
                int idRemover = int.Parse(Console.ReadLine());
                list.RemoveAll(x => x.Id == idRemover);
            }
            else
            {
                Console.WriteLine("Quantidade não alterada.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos funcionarios: ");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}