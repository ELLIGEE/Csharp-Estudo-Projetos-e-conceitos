using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjeto
{
    internal class Pessoa
    {

        public string nome;
        public string sobrenome;
        public int anoNascimento;

        //metodos simples
        public void Cumprimentar ()
        {
            Console.WriteLine("Olá eu sou " + nome + " " + sobrenome);
        }
    }

}
