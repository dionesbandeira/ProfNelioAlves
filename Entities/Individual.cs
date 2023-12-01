using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Entities
{
    internal class Individual : TaxPayer
    {
        public double DespSaude { get; set; }

        public Individual()
        {

        }
        public Individual(double despSaude, string name, double rendaAnual) : base(name, rendaAnual)
        {
            DespSaude = despSaude;
        }


        public override double Imposto()
        {
            if (RendaAnual < 20000.0)
            {
                return (RendaAnual * 0.15) - (DespSaude * 0.5);
            }
            else 
            {
                return (RendaAnual * 0.25) - (DespSaude * 0.5);
            }

        }




    }
}
