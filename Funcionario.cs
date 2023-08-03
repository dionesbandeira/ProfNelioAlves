using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double SalarioBruto { get; private set; }
        public double Imposto { get; set; }

        public Funcionario() { 
        
        }
        public Funcionario(int id, string nome, double salarioBruto) {
            Id = id;
            Nome = nome;
            SalarioBruto = salarioBruto;
        }
        public Funcionario(int id, string nome, string cargo, double salarioBruto, double imposto) {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }


        public double salarioLiq()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem) / 100.0;
        }



        /*public override string ToString()
        {
            return Nome
                + "\nR$: "
                + salarioLiq().ToString("F2", CultureInfo.InvariantCulture);
        }*/

        public override string ToString() {

            return "ID: " + Id
                + " Nome: " + Nome
                + " Salario: " + SalarioBruto.ToString("F2",CultureInfo.InvariantCulture);
        }




    }

}
