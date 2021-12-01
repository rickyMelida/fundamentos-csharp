using System;

namespace fundamentos.Models {
    class Vino: Bebida, IBebidaAlcoholica {
        public Vino(int Cantidad, string Nombre="Vino") 
            :base(Nombre, Cantidad){
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public int Alcohol { get; set; }

        public void MaxRecomendado() {
            Console.WriteLine("El maximo permitido son 3 copas");
        }   


    }
}