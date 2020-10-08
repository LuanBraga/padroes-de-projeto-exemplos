using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    public interface IMobilia
    {
        public string Estilo { get; }
        public double Valor { get; set; }

        public string Nome { get; }

        public string MostrarPreco();

        public bool Comparar(IMobilia movel);
    }
}
