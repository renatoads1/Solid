using PadraoBuilder.Components;
using PadraoBuilder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder.Builders
{
    class VeiculoBuilder : IBuilder
    {
        private Veiculo veiculo = new Veiculo();
        public Veiculo GetVeiculo()
        {
            Veiculo result = veiculo;
            Reiniciar();
            return result;
        }

        public void Reiniciar()
        {
            veiculo = new Veiculo();
        }

        public void SetBancos(int numeroBancos)
        {
            veiculo.Bancos = numeroBancos;
        }

        public void SetMotor(Motor motor)
        {
            veiculo.Motor = motor;
        }

        public void SetTipoVeiculo(TipoVeiculo tipoVeiculo)
        {
            veiculo.TipoVeiculo = tipoVeiculo;
        }

        public void SetTransmissao(Transmisao transmisao)
        {
            veiculo.Transmisao = transmisao;
        }
    }
}
