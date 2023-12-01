/*Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar
do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo
-> Enter department's name: Design
Enter worker data:
Name: Alex
Level (Junior/MidLevel/Senior): MidLevel
Base salary: 1200.00
How many contracts to this worker? 3
Enter #1 contract data:
Date (DD/MM/YYYY): 20/08/2018
Value per hour: 50.00
Duration (hours): 20
Enter #2 contract data:
Date (DD/MM/YYYY): 13/06/2018
Value per hour: 30.00
Duration (hours): 18
Enter #3 contract data:
Date (DD/MM/YYYY): 25/08/2018
Value per hour: 80.00
Duration (hours): 10
Enter month and year to calculate income (MM/YYYY): 08/2018
Name: Alex
Department: Design
Income for 08/2018: 3000.00
 */

/*
using ProfNelioAlves.Entities.Enums;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfNelioAlves.Entities;

namespace ProfNelioAlves
{
    internal class Program20ExecEnums
    {
        public static void Main(string[] args) {




            Console.Write("Informe o nome do departamento: ");
            string deptName = Console.ReadLine()
;
            Console.WriteLine("Inserir dados do trabalhador");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível do trabalhador: (Junior/MidLeve/Senior)");
            //Converter uma string para um enum
            Workerlevel level = Enum.Parse<Workerlevel>(Console.ReadLine());

            Console.Write("Informe o salario base do trabalhador: ");
            double salaryBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName); // informar uma sobrecarga ao construtor da entidade
            Worker worker = new Worker(nome, level, salaryBase, dept);


            Console.WriteLine("Quantos contratos para este trabalhador: ");
            int nContratos = int.Parse(Console.ReadLine());

            for (int i=1; i <= nContratos; i++) 
            {
                Console.WriteLine($"Insira os dados do contrato: {i}");

                Console.Write("Date: (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
                
                Console.Write("Quantidade em horas: ");
                int quantHoras = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valorPorHora, quantHoras);

                worker.addContract(contract);

            }

            Console.WriteLine();
            Console.WriteLine("Enre com o mês e ano 'MM/YYYY' para calcular o ganho: ");
            string monthAndYear = Console.ReadLine();

            //recorte através da função do substring
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name + "\nDepartment: " + worker.Department.Name + "\nSeu ganho para: " + monthAndYear + "\nFoi de: " + worker.income(year, month).ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}



*/
