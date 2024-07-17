using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metodos m = new metodos();
            m.Cumprimentar();
            m.Somar(10, 5);
            m.Apresentar("João", 25);

            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);
            m.AumentarRef(ref valor2);

            string nomeCompleto = m.MontaNome("João", "David");
            int codigoChar = m.codigoChar('a');
            double pi = m.ValorPI();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(pi);
            Console.ReadKey();

            m.Cumprimentar();
            m.Cumprimentar("João", 14);

            m.Comparar(100, 50 * 2);
        }
    }
}
