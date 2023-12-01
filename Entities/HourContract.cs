using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Entities
{
    internal class HourContract
    {

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        public HourContract()
        {

        }

        public HourContract(DateTime Date, double ValuePerHour, int Hours) 
        {
            this.Date = Date;
            this.ValuePerHour = ValuePerHour;
            this.Hours = Hours;  
        
        }

        public double TotalValue() 
        {
            return Hours * ValuePerHour;
        }



    }
}
