using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// O factory Method é um padrão criacional de projeto que fornece uma interface para criar objetos em uma superclasse,
    /// mas permite que as subclasses alterem o tipo de objetos que serão criados.
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            new Cliente().Main();
        }
    }
}
