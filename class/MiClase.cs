using System;
using System.Collections.Generic;
using System.Text;

namespace fundamentos.Models {
    class MiClase : IPrueba{
        public int valor;
        public MiClase() {
            valor = 0;
        }

        public MiClase(int valor) {
            this.valor = valor;
        }

        private int descuento;
        public int Descuento {
            get { return descuento; }
            set { 
                if(value > 0) {
                    descuento = value;
                }else {
                    descuento = 0;
                }
            }

        }
    
        public double calculo(double x) {
            return Math.Pow(x, 3);
        }
    }
}