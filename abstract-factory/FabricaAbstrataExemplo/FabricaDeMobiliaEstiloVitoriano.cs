using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    class FabricaDeMobiliaEstiloVitoriano : IFabricaDeMobilia
    {
        public ICadeira CriarCadeira()
        {
            return new CadeiraVitoriana();
        }

        public IMesa CriarMesa()
        {
            return new MesaVitoriana();
        }

        public ISofa CriarSofa()
        {
            return new SofaVitoriano();
        }
    }
}
