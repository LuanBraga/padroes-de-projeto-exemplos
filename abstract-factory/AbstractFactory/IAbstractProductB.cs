using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /*
        Aqui está a interface base de outro produto. Todos os Produtos
        podem interagir com cada um dos outros, mas uma interacao apropriada é possivel apenas entre
        produtos da mesma variante concreta.
    */
    public interface IAbstractProductB
    {
        //O Produto B é habilitado a fazer suas proprias coisas...
        string UsefulFunctionB();

        /*
            ..Mas ele pode colaborar com o Produto A.
            
            A fabrica Abstrata tem certeza que todos os Produtos que cria são da mesma variante
            e assim, compativeis.
        */
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
