using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class NubanckAdapter : IPayPalPagamentos
    {
        private Nubanck _nubanck;

        public NubanckAdapter(Nubanck nubanck)
        {
            _nubanck = nubanck;
        }

        public Token AuthToken()
        {
            return _nubanck.AuthToken();
        }

        public void PayPalPagamento()
        {
            _nubanck.FazerPagamentoNu();
        }

        public void PayPalRecebimento()
        {
            _nubanck.ReceberPagamentoNu();
        }
    }
}
