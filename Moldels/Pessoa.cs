using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace exemplosFundamentos.Pessoa
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}