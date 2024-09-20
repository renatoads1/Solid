using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Nubanck : INubanck
    {
        private Token token;
        public Token AuthToken()
        {
            return token = new Token();
        }

        public void FazerPagamentoNu()
        {
            token = AuthToken();
            Console.WriteLine("Pagamento efetuado com nubanck");
        }

        public void ReceberPagamentoNu()
        {
            token = AuthToken();
            Console.WriteLine("Pagamento recebido com nubanck");
        }
    }
}
