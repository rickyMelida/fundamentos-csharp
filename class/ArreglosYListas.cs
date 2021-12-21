using System;
using System.Collections.Generic;
using System.Text;

namespace fundamentos.Models {
    class ArreglosYListas {

    public void arreglos() {
        int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,0};

        for(int i=0;i < numeros.Length;i++) {
            //Console.WriteLine(numeros[i]);
        }

        foreach(int numero in numeros) {
            Console.WriteLine(numero);
        }
    }

    public void listas() {
        List<int> lista = new List<int>() {1,2,3,4,5,6,7,8};
        lista.Add(0);
        lista.Add(9);

        foreach(int numero in lista) {
            Console.WriteLine(numero);
        }

        List<Cerveza> cerveza = new List<Cerveza>{ new Cerveza(10) };
        cerveza.Add(new Cerveza(50, "Otra cerveza"));
        Cerveza corona = new Cerveza(400, "Cerveza de Trigo");
        cerveza.Add(corona);

        foreach(var cer in cerveza) {
            //Console.WriteLine(cer.Nombre);
        }
    }

    }
}
