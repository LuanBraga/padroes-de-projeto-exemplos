using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica
{
    class LogisticaTerrestre : Logistica
    {
        public override IVeiculo CriarTransporte()
        {
            return new Caminhao();
        }
    }
}
