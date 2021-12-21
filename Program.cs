using System;
using fundamentos.Models;

namespace fundamentos
{
    public enum DayOfWeek {
      Lunes = 0,
      Martes = 1,
      Miercoles = 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Bebida bebida = new Bebida("Coca Cola", 10000);
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);*/

            /*Cerveza cerveza = new Cerveza(50);
            cerveza.Beberse(10);
            Console.WriteLine(cerveza.Cantidad);*/

            /*ArreglosYListas arr = new ArreglosYListas();
            arr.listas();

            int[] a = { 0,1,2,3 };
            Funciones miFuncion = new Funciones();*/
            /*miFuncion.PasoDeParametros(a);*/

            int[] b = { 0,1,2,3 };
            /*miFuncion.PasoDeParametrosPorReferencia(ref b);
            Console.WriteLine(b[0]);*/

            MiClase c = new MiClase();
            c.Descuento = -10;
        /*
            MiClase obj1, obj2;
            obj1 = new MiClase();
            obj2 = new MiClase(50); */

            Persona p = new Persona("Ricardo");
            //Console.WriteLine(p);

            /*var bebidaAlcoholica = new Vino(100);
            MostrarRecomendacion(bebidaAlcoholica);*/



            //DayOfWeek day = new DayOfWeek.Lunes;
            //Console.WriteLine(day);
            Diccionarios myDictionary = new Diccionarios();
            //myDictionary.Main();

            StructAndEnum myEnum = new StructAndEnum();
            myEnum.Main();

        }

        static void MostrarRecomendacion(IBebidaAlcoholica bebida) {
            bebida.MaxRecomendado();
        }
    }
}
