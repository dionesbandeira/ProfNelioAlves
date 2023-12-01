using ProfNelioAlves.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProfNelioAlves.Services;

namespace ProfNelioAlves
{
    internal class Program38ExercFixacaoInterface
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter Constract Date");
            Console.Write("\nNumber Comtract:");
            int NumberContract = int.Parse(Console.ReadLine());

            Console.Write("\nDate Constract:");
            DateTime DateContract = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);

            Console.Write("\nValue Constract:");
            double ValueContract = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments:");
            int Months = int.Parse(Console.ReadLine());


            Contract myContract = new Contract(NumberContract, DateContract, ValueContract);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, Months);

            Console.WriteLine("Installment: ");
            foreach (Installment installment in myContract.Installments) 
            {
                Console.WriteLine(installment);
            }



        }

    }

}
