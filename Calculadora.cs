using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class Calculadora {

        public static int soma(params int[] numeros) {
            int sum = 0;

            for (int i = 0; i < numeros.Length; i++) {
                sum += numeros[i];
            }
            return sum;
        }


        public static void Triplo (ref int x){
            x = x * 3;
        }

        public static void triplo(int origem, out int result) {
            result = origem * 3;
        }




    }
}
