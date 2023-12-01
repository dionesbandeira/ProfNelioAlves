using ProfNelioAlves.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfNelioAlves.Services;

/*

namespace ProfNelioAlves
{
    class Program37SoluctionSemInterface
    {
        public static void Main(string[] args) 
        {

            Console.WriteLine("Enter Rental Data");
            Console.Write("Car model  : ");
            string carModel = (Console.ReadLine());

            Console.Write("Pickup (dd/mm/yyyy hh:mm)  : ");
            DateTime dataStart = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/mm/yyyy hh:mm) : ");
            DateTime dataFinish = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);

            Console.Write("Enter per price hour: ");
            double priceHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Intsnaciando e informa do os valores para o objeto CarRental
            CarRental carRental = new CarRental(dataStart, dataFinish, new Vehicle(carModel));

            //Instanciou o serviço
            RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService());

            //Gera o objeto Invoice e associar ele ao aluguel
            rentalService.ProcessInvoice(carRental);


            Console.Write("INVOICE: ");
            Console.WriteLine(carRental.invoice);



        }

    }
}

*/