using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    class FabricaDeMobiliaEstiloModerno : IFabricaDeMobilia
    {
        public ICadeira CriarCadeira()
        {
            return new CadeiraModerna();
        }

        public IMesa CriarMesa()
        {
            return new MesaModerna();
        }

        public ISofa CriarSofa()
        {
            return new SofaModerno();
        }
    }
}
