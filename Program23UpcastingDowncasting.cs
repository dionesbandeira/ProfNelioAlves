/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfNelioAlves.Entities;

namespace ProfNelioAlves
{
    internal class Program23UpcastingDowncasting
    {
        public static void Main(string[] args)
        {

            //instancias de objetos   -- Herança é uma relação é um

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;   //É uma atribuição de Subclasse para uma classe "superclasse", ou seja a subclasse é uma classe 
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING é uma operação insegura

            //BusinessAccount acc4 = acc2; // não é possivel
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount) // testanto se a instancia é do mesmo tipo
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                //Uma outra sintaxe de casting -- onde digo que a instancia acc3 COMO BusinessAccount
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }


        }
    }
}




*/