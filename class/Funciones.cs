using System;
using System.Collections.Generic;
using System.Text;

namespace fundamentos.Models {
    class Funciones {
        public void PasoDeParametros(int[] param) {
            param[0] = 5;
            param = new int[4] {-1,-2,-3,-4};

            foreach(int nu in  param) {
                Console.WriteLine(nu);
            }
        }

        public void PasoDeParametrosPorReferencia(ref int[] param) {
            param[0] = 5;
            param = new int[4] { -1,-2,-3,-4 };
        }
    }
}