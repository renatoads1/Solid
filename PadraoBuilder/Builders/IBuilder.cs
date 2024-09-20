using PadraoBuilder.Components;
using PadraoBuilder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder.Builders
{
    interface IBuilder
    {
        void Reiniciar();
        Veiculo GetVeiculo();
        void SetBancos(int numeroBancos);
        void SetMotor(Motor motor);
        void SetTransmissao(Transmisao transmisao);
        void SetTipoVeiculo(TipoVeiculo tipoVeiculo);
    }
}
