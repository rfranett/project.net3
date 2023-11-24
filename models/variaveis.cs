using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.net3.Models
{
    public class Pessoa
    {
        public  string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public void Apresentar()
        {
             Console.WriteLine($"\n Olá, Meu nome é {Nome}.\n Tenho {Idade} anos.\n E meu Email é {Email}\n");
             Console.WriteLine($"I hoje é o segundo dia estudando c#.\n");
        }
    }
}