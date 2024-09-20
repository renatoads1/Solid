using Segregacao.Interfaces;

namespace Segregacao
{
    public class Carro : ICarro
    {
        public void configureCarro()
        {
            Console.WriteLine("configurando carro");
        }

        public void startVeiculo()
        {
            Console.WriteLine("Ligando carro");
        }
    }
}
