using System;
using Exemplo1.Entities;

namespace Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "BOb", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100.0);

                //BusinessAccount acc5 = (BusinessAccount) acc3; // ira dar erro, SavingAccount não é compativel com BusinessAcount, segue a solução abaixo:

            if (acc3 is BusinessAccount)
                {
                    //BusinessAccount acc5 = (BusinessAccount) acc3;
                    BusinessAccount acc5 =  acc3 as BusinessAccount; //Sintaxe Alternativa
                }
        }
    }
}