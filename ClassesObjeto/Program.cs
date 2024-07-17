using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Pessoa p1 = new Pessoa();
            p1.nome = "João Guilherme";
            p1.sobrenome = "David";
            p1.anoNascimento = 1998;

            Pessoa p2 = new Pessoa()
            {
                nome = "Tiago",
                sobrenome = "Pereira",
                anoNascimento = 1998
            };
            
            Console.WriteLine("Pessoa 1:" +  p1.nome);
            Console.WriteLine("Pessoa 1:" + p1.sobrenome);
            Console.WriteLine("Pessoa 1:" + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Pessoa 2:" + p2.nome);
            Console.WriteLine("Pessoa 2:" + p2.sobrenome);
            Console.WriteLine("Pessoa 2:" + p2.anoNascimento);
            p2.Cumprimentar();

            Console.ReadKey(); 

            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse outra = new OutraClasse();
            //OutraClasse outra2 = outra;
        }
    }

    class MinhaClasse
    {

    }
}
