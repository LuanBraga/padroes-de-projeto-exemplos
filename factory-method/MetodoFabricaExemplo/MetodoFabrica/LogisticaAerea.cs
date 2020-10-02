using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica
{
    class LogisticaAerea : Logistica
    {
        public override IVeiculo CriarTransporte()
        {
            return new Aviao();
        }
    }
}
