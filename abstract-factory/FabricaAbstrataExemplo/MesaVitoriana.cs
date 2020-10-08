using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    class MesaVitoriana : IMesa
    {
        private double _valor = 340;
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

        private readonly string _nome = "Mesa Vitoriana";
        public string Nome 
        { 
            get => _nome; 
        }

        private string _estilo = "V";
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
