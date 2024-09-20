using PadraoBuilder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder.Products
{
    class Veiculo
    {
        private TipoVeiculo tipoVeiculo;
        private int bancos;
        private Motor motor;
        private Transmisao transmisao;

        public TipoVeiculo TipoVeiculo {
            get => tipoVeiculo;
            set => tipoVeiculo = value;
        }
        public int Bancos
        {
            get => bancos;
            set => bancos = value;
        }
        public Motor Motor
        {
            get => motor;
            set => motor = value;
        }
        public Transmisao Transmisao
        {
            get => transmisao;
            set => transmisao = value;
        }


    }
}
