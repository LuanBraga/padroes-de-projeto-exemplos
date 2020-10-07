using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    public interface IFabricaDeMobilia
    {
        ICadeira CriarCadeira();

        IMesa CriarMesa();

        ISofa CriarSofa();
    }
}
