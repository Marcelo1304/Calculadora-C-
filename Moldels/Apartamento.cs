using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplosFundamentos.Apartamento       
{
    public class Apartamento
    {
        public string? Cômodos1 { get; set; }

        public string? Cômodos2 { get; set; }

        public string? Cômodos3 { get; set; }

        public string? Cômodos4 { get; set; }

         public void ApresentarApartamento(){
        Console.WriteLine($"O apartemento possui 2 {Cômodos1}, 1 {Cômodos2}, 1 {Cômodos3} e 1 {Cômodos4}");
    }
  }
}

