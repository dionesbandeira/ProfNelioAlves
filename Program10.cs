/*


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class Program10 {
        private static void Main(string[] args) {

            //int cal1 = Calculadora.soma(new int[] {2, 6, 3 });
            //int cal2 = Calculadora.soma(new int[] { 2, 6, });
            int cal1 = Calculadora.soma( 2, 6, 3 );
            int cal2 = Calculadora.soma( 2, 6 );

            Console.Write("Soma 1: "+ cal1);
            Console.Write("\nSoma 2: "+ cal2);


            //Modificadores de parametros Ref
            int a = 10;
            Calculadora.Triplo(ref a);
            Console.Write("\n"+ a);


            //Modificadores de parametros Out
            int b = 5;
            int triplo;
            Calculadora.triplo(b, out triplo);
            Console.Write("\n" + triplo);

        }

    }
}





*/