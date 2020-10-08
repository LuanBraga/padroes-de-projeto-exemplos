using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    class CadeiraArtDeco : ICadeira
    {
        private double _valor = 320;
        public double Valor
        {
            get => _valor;

            set
            {
                if (value > 0)
                {
                    _valor = value;
                }
            }
        }

        private readonly string _nome = "Cadeira Art Deco";
        public string Nome 
        { 
            get => _nome; 
        }

        private string _estilo = "A";
        public string Estilo => _estilo;

        public string MostrarPreco()
        {
            return $"R$ {Valor},00";
        }

        public string Reclinar()
        {
            return $"Reclinando {Nome}";
        }

        public bool Comparar(IMobilia movel)
        {
            if (movel.Estilo == this.Estilo)
            {
                return true;
            }
            else
                return false;
        }
    }
}
