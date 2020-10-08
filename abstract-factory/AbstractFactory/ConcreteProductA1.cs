using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /*
        Produtos Concretos são criados pela Fabrica Concreta correspondente.
    */
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The Result of the Product A1";
        }
    }
}
