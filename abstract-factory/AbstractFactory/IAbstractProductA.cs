using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /*
        Cada produto distinto de uma familia de produtos deve ter uma interface base.
        Todas as variantes de produtos devem implementar essa interface.
    */
    public interface IAbstractProductA
    {
        string UsefulFunctionA();
    }
}
