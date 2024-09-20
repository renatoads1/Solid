using Segregacao.Interfaces;

namespace Segregacao
{
    class Moto : IMoto
    {
        public void configureMoto()
        {
            Console.WriteLine("configurando Moto ");
        }

        public void startVeiculo()
        {
            Console.WriteLine("Ligando Moto");
        }
    }
}
