using System;

class Fundamentos{
    

            public void variables() {
                byte numero = 255;
                sbyte numeroNegativo = -127;
                int numeroEntero = 256;
                uint numeroPositivo = 122;
                long largo = 255555;
                float flotante = 2.5f;
                double flotanteDouble = 2.555d;
                DateTime date = DateTime.Now;

                //Creamos un objeto anonimo
                //object persona = new { nombre="Ricardo", apellido="Melida" };
                var persona = new { nombre="Ricardo", apellido="Melida" };

                Console.WriteLine(persona.nombre);
            }
}