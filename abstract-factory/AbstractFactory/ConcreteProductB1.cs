using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1";
        }

        /*
            O variante, Produto B1, só é capaz de trabalhar corretamente com o variante, Produto A1.
            Mesmo assim, aceita qualquer instancia do AbstractProductA como um argumento.
        */
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }

    }
}
