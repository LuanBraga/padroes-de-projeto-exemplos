using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Criadores Concretos sobrescrevem o Factory Method ao invés de mudar o resultado do tipo de Produto.
    class CriadorConcreto1 : Criador
    {
        //Note que a assinatura do método continua usando um tipo de produto abstrato, apesar do produto concreto ser
        //na verdade retornado pelo método. Dessa forma o Criador pode continuar indempendente da classe do produto concreto.
        public override IProduto FactoryMethod()
        {
            return new ProdutoConcreto1();
        }
    }
}
