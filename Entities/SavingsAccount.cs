using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfNelioAlves.Entities;

namespace ProfNelioAlves.Entities
{
    // A palavra "ealed" evita que a classe seja herdada -- Esta ação é para segurança 
    internal  class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //A palavra Override é para que o metodo possa ser Sobreposto ou Subescrito
        //Quando é reimplementada na subclasse a operação que ja exixstia na SurpeClasse
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }


    }
}
