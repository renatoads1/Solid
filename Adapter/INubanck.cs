using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface INubanck
    {
        Token AuthToken();
        void FazerPagamentoNu();
        void ReceberPagamentoNu();
    }
}
