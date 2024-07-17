using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Acelerou!");
        }

        public void Parar()
        {
            Console.WriteLine("Parou!");
        }
    }
}
