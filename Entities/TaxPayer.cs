using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Entities
{
    internal abstract class TaxPayer
    {
        //Contribuinte 

        public string Name { get; set; }
        public double RendaAnual { get; set; }

        public TaxPayer(){

        }
        protected TaxPayer(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }


        public abstract double Imposto();


    }
}
