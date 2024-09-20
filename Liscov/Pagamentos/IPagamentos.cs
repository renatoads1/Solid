using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liscov.Pagamentos
{
    public interface IPagamentos
    {
        void validarCartao();
        void coletaPagamento();
    }
}
