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
            throw new NotImplementedException();
        }

        public IMesa CriarMesa()
        {
            throw new NotImplementedException();
        }

        public ISofa CriarSofa()
        {
            throw new NotImplementedException();
        }
    }
}
