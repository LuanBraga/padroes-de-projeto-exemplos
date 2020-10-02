using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica
{
    class LogisticaMaritima : Logistica
    {
        public override IVeiculo CriarTransporte()
        {
            return new Navio();
        }
    }
}
