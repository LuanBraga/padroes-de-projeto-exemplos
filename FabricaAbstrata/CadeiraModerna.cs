using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    class CadeiraModerna : ICadeira
    {
        public string Reclinar()
        {
            return "Reclinando cadeira moderna";
        }
    }
}
