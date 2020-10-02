using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //A interface Produto declara as operações que todos os produtos concretos devem implementar.
    interface IProduto
    {
        string Operation();
    }
}
