using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Entities
{
    internal class UsedProduct : Product
    {
        DateTime ManufactureDate{ get; set; }


        public UsedProduct()
        {
            
        }
        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }


        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "( Manufacture date: " + ManufactureDate.ToString("dd/mm/yyyy") + ")";
        }

    }
}
