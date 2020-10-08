using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /*
        Fabricas Concretas produzem uma familia de produtos pertencentes a um unico variante.
        As Fabricas garantem que os produtos resultantes sejam compativeis.
        Note que assinaturas dos Metodos das Fabricas Concretas retornam um produto abstrato,
        enquanto por dentro do metodo um produto concreto é instanciado.
    */
    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
