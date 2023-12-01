/*Uma empresa possui funcionários próprios e terceirizados.
Para cada funcionário, deseja-se registrar nome, horas
trabalhadas e valor por hora. Funcionários terceirizados
possuem ainda uma despesa adicional.
O pagamento dos funcionários corresponde ao valor da hora
multiplicado pelas horas trabalhadas, sendo que os
funcionários terceirizados ainda recebem um bônus
correspondente a 110% de sua despesa adicional.
Fazer um programa para ler os dados de N funcionários (N
fornecido pelo usuário) e armazená-los em uma lista. Depois
de ler todos os dados, mostrar nome e pagamento de cada
funcionário na mesma ordem em que foram digitados.
Construa o programa conforme projeto ao lado. Veja
exemplo na próxima página.*/

/*
using ProfNelioAlves.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Program25ExerResolSecao10
    {
        public static void Main(string[] args) 
        {
            //Intanciando objeto do tipo lista de funcionarios
            List<Employee> Employees = new List<Employee>();

            Console.Write("Informe a quantidade de funcionarios: ");
            int n = int.Parse(Console.ReadLine());


            for (int i=1; i<=n; i++) 
            {
                Console.WriteLine($"Employee #{i} data:");

                Console.WriteLine("Informe se o funcionario é terceriazado (y/n): ");
                char tpFunc = char.Parse(Console.ReadLine());

                Console.Write("Informe o Nome do funcionario: ");
                string name = Console.ReadLine();

                Console.Write("Informe a quantidade de horas tabalhadas: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Informe o valor da hora tabalhada: ");
                double valueHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tpFunc ==  'y')
                {
                    Console.WriteLine("Informe o valor de despesa do funcionaio tercerizado: ");
                    double ValueDespAdic = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Employees.Add(new OutSourceEmployee(name, hours, valueHours, ValueDespAdic));
                }
                else 
                {
                    Employees.Add(new Employee(name, hours, valueHours));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");

            foreach (Employee emp in Employees) 
            {
                Console.WriteLine(emp.Name
                                        +" - $ "
                                        +emp.Payment().ToString("F2",CultureInfo.InvariantCulture) );
            }

            

        }

    }
}



*/