using System;
using System.Collections.Generic;
using System.Text;

namespace fundamentos.Models {
    class Cerveza:Bebida, IBebidaAlcoholica {
        //base hace referencia al constructor del padre

        public int Alcohol { get; set; }

        public void MaxRecomendado() {
            Console.WriteLine("El maximo permitido de una cerveza es 10");
        }
        public Cerveza(int Cantidad, string Nombre="Cerveza")
            : base(Nombre, Cantidad) {

        }
    }
}