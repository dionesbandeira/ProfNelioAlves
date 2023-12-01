using ProfNelioAlves.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Services
{
    internal class RentalService
    {
        //So pode receber o valores e nao altera-los por isso private

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //A dependencia ja instanciada. 
        private ITaxService _taxService;


        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay  = pricePerDay;
            _taxService = taxService;
        }


        //Este é responsavel em pegar o CarRental e processar a nota de pagamento "Invoice" 
        public void ProcessInvoice(CarRental carRental) 
        {
            //Sera criado uma dependencia para BrazilTaxService
            
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else 
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            //Calculando imposto 
            double tax = _taxService.Tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment, tax);

        }

    }

}
