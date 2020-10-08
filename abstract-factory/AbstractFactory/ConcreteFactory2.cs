using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /*
        Cada Fabrica Concreta tem um produto variante correspondente
    */
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
