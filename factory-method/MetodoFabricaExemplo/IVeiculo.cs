using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica
{
    interface IVeiculo
    {
        string Tipo { get; }

        string TipoEntrega { get; }
    }
}
