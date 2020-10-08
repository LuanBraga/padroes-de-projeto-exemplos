using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    class SofaVitoriano : ISofa
    {
        private double _valor = 600;
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

        private readonly string _nome = "Sofá Vitoriano";
        public string Nome
        {
            get => _nome;
        }

        private string _estilo = "V";
        public string Estilo => _estilo;

        public string Estender()
        {
            return $"Estendendo {Nome}";
        }

        public string MostrarPreco()
        {
            return $"R$ {Valor},00";
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
