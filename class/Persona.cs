using System;
using System.Collections.Generic;
using System.Text;

namespace fundamentos.Models {
    class Persona {
        String nombre;
        public Persona(String nombre) {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}