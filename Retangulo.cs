using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;


        public double Area(){
            double Area = Largura * Altura;
            return Area;
        }
        public double Perimetro() {
            double Perimetro = 2 * (Largura + Altura);       
            return Perimetro;
        }
        public double Diagonal() {
            double Diagonal = Math.Sqrt((Largura * Largura) + (Altura * Altura));
            return Diagonal;
        }


    }
}
