using Segregacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregacao
{
    class Veiculo : IVeiculo
    {
        public void startVeiculo()
        {
            Console.WriteLine("Start veiculo!!!");
        }
    }
}
