using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica
{
    class Caminhao : IVeiculo
    {
        private readonly string _tipo = "Caminhão";
        public string Tipo 
        {
            get => _tipo;
        }

        public string TipoEntrega => "terrestre";
    }
}
