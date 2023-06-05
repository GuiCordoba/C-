using System;
using Exercicio1.Entities.Enums;


namespace Exercicio1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkLevel Lavel { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // como um funcionario pode ter varios contratos, usamos uma lista


        //----------------------------------------------------------------------------------------------------------------------------------------------
        public Worker() 
        { 
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------
        public Worker(string name, WorkLevel lavel, double baseSalary, Department department)
        {
            Name = name;
            Lavel = lavel;
            BaseSalary = baseSalary;
            Department = department;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------
        // Métodos
        public void AddContract(HourContract contract) 
        {
            Contracts.Add(contract);  // Add o contrato na lista Contracts
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);  // Remove o contrato na lista Contracts
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------

        public double Income(int year, int month) 
        {
            double sum = BaseSalary; //O trabalhador ja ganha esse dinheiro fora os contratos

            foreach (HourContract contract in Contracts)    //para cada contrato na lista de contratos
            {
                if (contract.Date.Year == year && contract.Date.Month == month)   //se o ano e mes  do contrato for igual ao ano e mes passad
                {
                    sum =+ contract.TotalValue();
                }    
                    
            }

            return sum;
        //----------------------------------------------------------------------------------------------------------------------------------------------  

        }
    }
}
