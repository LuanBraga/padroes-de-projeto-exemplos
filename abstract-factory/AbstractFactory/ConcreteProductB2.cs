using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B2";
        }

        /*
            O variante, Produto B2, só é capaz de trabalhar corretamente com o variante, Produto A2.
            Mesmo assim, aceita qualquer instancia do AbstractProductA como um argumento.
        */
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}
