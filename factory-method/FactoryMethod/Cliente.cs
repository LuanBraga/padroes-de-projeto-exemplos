using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Código que usa o método fábrica.
    class Cliente
    {
        public void Main()
        {
            Console.WriteLine("App: Iniciado com o ConcreteCreator1.");
            ClientCode(new CriadorConcreto1());

            Console.WriteLine("");

            Console.WriteLine("App: Iniciado com o ConcreteCreator2.");
            ClientCode(new CriadorConcreto2());

            Console.ReadLine();
        }

        //O codigo do Cliente trabalha com uma instância do Concrete Creator, embora através de sua interface base.
        //Enquanto o Client continuar trabalhando com o creator via interface base, você pode passar qualquer subclasse
        //do creator.

        public void ClientCode(Criador creator)
        {
            //..
            Console.WriteLine("Cliente: Eu não sei como a classe Creator funciona," +
                "mas tudo funciona mesmo assim.\n" + creator.SomeOperation());
            //..
        }
    }
}
