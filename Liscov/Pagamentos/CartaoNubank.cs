using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liscov.Pagamentos
{
    abstract class CartaoNubank : IPagamentos
    {
        public void coletaPagamento()
        {
            Console.WriteLine("Pagamento realizado");
        }

        public virtual void validarCartao()
        {
            //validacao basica do cartao
        }
    }
}
