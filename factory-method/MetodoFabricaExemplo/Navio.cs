using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica
{
    class Navio : IVeiculo
    {
        private readonly string _tipo = "Navio";
        public string Tipo 
        {
            get => _tipo;
        }

        public string TipoEntrega => "marítima";
    }
}
