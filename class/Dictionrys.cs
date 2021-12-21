using System;
using System.Collections.Generic;

class Diccionarios {
    public void Main() {
      var people = new Dictionary<string, int>
      {
        {"Jhon",30}, {"Mary", 28}, {"Jose", 35}
      };

      Console.WriteLine(people["Jhon"]);
    }
}
