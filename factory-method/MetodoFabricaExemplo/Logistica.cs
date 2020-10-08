using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica
{
    abstract class Logistica
    {
        public abstract IVeiculo CriarTransporte();

        public string Entregar()
        {
            var veiculo = CriarTransporte();

            var entregaVia = veiculo.TipoEntrega;

            return $"A entrega será feita por um {veiculo.Tipo}, por via {entregaVia}";

        }
        public string CalculaFrete(double distancia, double peso) 
        {
            var veiculo = CriarTransporte();

            var valor = 0.0;

            if (veiculo.Tipo == "Caminhão")
            {
                valor =  (distancia / peso) * 5;
            }
            if (veiculo.Tipo == "Navio")
            {
                valor = (distancia / peso) * 7;
            }
            if (veiculo.Tipo == "Avião")
            {
                valor = (distancia / peso) * 9;
            }

            return $"O valor do frete será: R$ {Math.Round(valor)}";
        }
    }
}
