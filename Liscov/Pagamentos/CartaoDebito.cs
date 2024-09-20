using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liscov.Pagamentos
{
    class CartaoDebito : CartaoNubank
    {
        public override void validarCartao()
        {
            Console.WriteLine("Validando Saldo");
            Console.WriteLine("Saldo ok");
        }
    }
}
