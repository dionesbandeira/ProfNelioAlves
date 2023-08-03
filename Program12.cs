/*


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProfNelioAlves {
    internal class Program12 {
        private static void Main(string[] args) {

            //Criei uma lista do tipo Funcionario vazia
            List<Funcionario> list = new List<Funcionario>();
            
            Console.Write("Quantos funcionarios serao registrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i<=n; i++) {

                Console.Write("Funcionarios: "+i);
                Console.Write("\nInforme o ID do funcionarios: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write(" Informe o nome do funcionario: ");
                string nome = Console.ReadLine();
                Console.Write(" Informe o salario do funcionario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                //Após coletar as informações do usuario, adciona à lista criada 
                list.Add(new Funcionario(id, nome, salario)); ;
            }

            Console.Write("Informe o ID do funcionarios para aumento do salario: ");
            int buscaId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x=> x.Id == buscaId);
            if (func != null) {
                Console.Write("Enforme a porcentagem do aumento: ");
                double porc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                func.AumentarSalario(porc);
            }
            else {
                Console.Write("\nO ID do funcionario não existe!");
            }

            Console.Write("Lista Atualizada: ");
            foreach (Funcionario obj in list) {
                Console.Write("\n:" + obj);
            }

        }
            
    }
}



*/