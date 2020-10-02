using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Produtos Concretos fornecem várias implementações da Interface Produto.
    class ProdutoConcreto1 : IProduto
    {
        public string Operation()
        {
            return " {Resultado do ConcreteProduct1}";
        }
    }
}
