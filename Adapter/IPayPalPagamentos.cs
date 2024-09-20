using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IPayPalPagamentos
    {
        Token AuthToken();
        void PayPalPagamento();
        void PayPalRecebimento();
    }
}
