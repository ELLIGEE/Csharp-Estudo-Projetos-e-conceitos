using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            acessar a = new acessar();

            if (a.Login("abc123"))
            {
                Console.WriteLine("Seja bem vindo!!");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }

            Console.ReadKey();
        }
    }
}
