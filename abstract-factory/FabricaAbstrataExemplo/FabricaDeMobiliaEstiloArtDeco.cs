using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    class FabricaDeMobiliaEstiloArtDeco : IFabricaDeMobilia
    {
        public ICadeira CriarCadeira()
        {
            return new CadeiraArtDeco();
        }

        public IMesa CriarMesa()
        {
            return new MesaArtDeco();
        }

        public ISofa CriarSofa()
        {
            return new SofaVitoriano();
        }
    }
}
