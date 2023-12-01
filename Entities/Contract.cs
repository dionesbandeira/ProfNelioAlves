
using System;
using System.Collections.Generic;


namespace ProfNelioAlves.Entities
{
    public class Contract
    {
        public int NumberContract { get; set; }

        public DateTime DateContract { get; set; }

        public double ValueTotalConstract { get; set; }

        public List<Installment> Installments { get; set; }

        public Contract(int numberContract, DateTime dateContract, double valueTotalConstract)
        {
            NumberContract = numberContract;
            DateContract = dateContract;
            ValueTotalConstract = valueTotalConstract;
            Installments = new List<Installment>();  //valor null 
        }


        //Método na qual adciono parcelas a minha lista atual
        public void AddInstallent(Installment installment) 
        {
            Installments.Add(installment);
        }


    }

}
