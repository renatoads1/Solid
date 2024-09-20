using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liscov.Pagamentos
{
    class CartaoCredito : CartaoNubank
    {
        public override void validarCartao() {
            Console.WriteLine("Validando Limite");
            Console.WriteLine("Limite ok");
        }
    }
}
