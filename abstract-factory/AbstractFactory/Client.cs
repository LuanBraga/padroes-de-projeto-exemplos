using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /*
        O código cliente trabalha com fabricas e produtos somente atraves de tipos abstratos: AbstractFactory e AbstractProduct.
        Isso premite voce pass qualquer subclasse factory ou produto ao codigo cliente sem quebrá-lo. 
    */

    class Client
    {
        public void Main()
        {
            //O codigo cliente pode trabalhar com qualquer classe de Fabrica Concreta.
            
            Console.WriteLine("Client: Testing client code with the first factory type...");

            ClientMethod(new ConcreteFactory1());

            Console.WriteLine("\n");
            
            Console.WriteLine("Client: Testing the same client code with the second factory type...");

            ClientMethod(new ConcreteFactory2());

            Console.ReadLine();
        }

        public void ClientMethod(IAbstractFactory factory) 
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
