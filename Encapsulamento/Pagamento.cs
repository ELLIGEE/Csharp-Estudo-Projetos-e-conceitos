using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Pagamento
    {
       public DateTime Vencimento;
       
        public void Pagar() { }

  public  class PagamentoBoleto : Pagamento { }
       
    }
}
