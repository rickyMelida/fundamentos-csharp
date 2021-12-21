using System;
using System.Collections.Generic;

namespace fundamentos.Models
{
    class StructAndEnum
    {
        enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 };
        public void Main()
        {
            this.ExampleEnum();

        }

        public void ExampleEnum()
        {

            Bonus Antonio = Bonus.bajo;
            double salarioAntonio = (double)Antonio;
            Console.WriteLine(salarioAntonio);
        }
    }
}