using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    class MesaArtDeco : IMesa
    {
        private double _valor = 325;
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

        private readonly string _nome = "Cadeira Arte Decor";
        public string Nome => _nome;

        private string _estilo = "A";
        public string Estilo => _estilo;

        public string MostrarPreco()
        {
            return $"R$ {Valor},00";
        }

        public string RegularAltura()
        {
            return $"Regulando {Nome}";
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
