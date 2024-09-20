using PadraoBuilder.Builders;
using PadraoBuilder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder.Directors
{
    class Diretor
    {
        IBuilder _builder;

        public Diretor(IBuilder builder)
        {
            _builder = builder;
        }

        public void ConstruirCarroSedan() {
            _builder.SetTipoVeiculo(TipoVeiculo.SEDAM);
            _builder.SetMotor(new Motor(2000));
            _builder.SetBancos(5);
            _builder.SetTransmissao(Transmisao.MANUAL);
        }

        public void ConstruirCaminhao()
        {
            _builder.SetTipoVeiculo(TipoVeiculo.CAMINHAO);
            _builder.SetMotor(new Motor(10000));
            _builder.SetBancos(3);
            _builder.SetTransmissao(Transmisao.AUTOMATICA);
        }

    }
}
