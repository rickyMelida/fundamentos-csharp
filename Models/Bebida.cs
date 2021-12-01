using System;
using System.Collections.Generic;
using System.Text;

namespace fundamentos.Models {
    class Bebida {
        public Bebida(string Nombre, int Cantidad) {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        //Modificadores de acceso
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public void Beberse(int cuantoBebio) {
            this.Cantidad -= cuantoBebio;
        }
    }
}