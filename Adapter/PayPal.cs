using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PayPal : IPayPalPagamentos
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPagamento()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento paypal");
        }

        public void PayPalRecebimento()
        {
            Console.WriteLine("Recebendo pagamento paypal");
        }
    }
}
