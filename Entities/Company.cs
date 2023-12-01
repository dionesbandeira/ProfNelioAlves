using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Entities
{
    internal class Company : TaxPayer
    {
        int NumFuncionarios { get; set; }

        public Company()
        {

        }
        public Company(int numFuncionarios, string name, double rendaAnual) : base(name, rendaAnual) 
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double Imposto()
        {
            if (NumFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else 
            {
                return RendaAnual * 0.16;
            }
        }

    }
}


/*Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10
funcionários, ela paga 14% de imposto.
Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
400000 * 14% = 56000.00*/