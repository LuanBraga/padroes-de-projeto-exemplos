using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /*  A interface Fabrica Abstrata declara uma serie de metodos que retornam diferentes
        produtos abstratos. Esses produtos são chamados de familia e sao relacionados por um
        tema ou conceito de alto nível. Produtos de uma familia sao geralmente capazes de colaborar
        entre si. A familia de produtos pode ter algumas variantes, mas os produtos de uma variante 
        são incompativeis com produtos de outras variantes
    */
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
