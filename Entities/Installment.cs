using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Entities
{
    internal class Installment
    {
        public DateTime DateIntallment { get; set; }

        public double AmountInstallment { get; set; }

        public Installment(DateTime dateIntallment, double amountInstallment)
        {
            DateIntallment = dateIntallment;
            AmountInstallment = amountInstallment;
        }

        public override string ToString()
        {
            return DateIntallment.ToString("dd/MM/yyyy") +
                " - "
                + AmountInstallment.ToString("F2", CultureInfo.InvariantCulture);
        }


    }

}
