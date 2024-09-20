using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liscov.Pagamentos
{
    class NubankPontos : IPagamentos
    {
        public void coletaPagamento()
        {
            Console.WriteLine("Pagamento realizado!!");
            Console.WriteLine("Pontos creditados!!");
        }

        public void validarCartao()
        {
            Console.WriteLine("Limite ok");
        }
    }
}
