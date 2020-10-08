using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstrata
{
    class Cliente
    {
        public void Main()
        {
            Console.WriteLine($"Cliente: Testando código do cliente com o primeiro tipo de Fabrica");
            MetodoCliente(new FabricaDeMobiliaEstiloModerno());

            Console.WriteLine($"Cliente: Testando código do cliente com o segundo tipo de Fabrica");
            MetodoCliente(new FabricaDeMobiliaEstiloVitoriano());

            Console.WriteLine($"Cliente: Testando código do cliente com o terceiro tipo de Fabrica");
            MetodoCliente(new FabricaDeMobiliaEstiloArtDeco());

            Console.ReadLine();
        }

        public void MetodoCliente(IFabricaDeMobilia fabrica) 
        {
            var cadeira = fabrica.CriarCadeira();

            var mesa = fabrica.CriarMesa();

            var sofa = fabrica.CriarSofa();

            Console.WriteLine(cadeira.Nome);
            Console.WriteLine(cadeira.MostrarPreco());
            Console.WriteLine(CompararEstilos(cadeira, new CadeiraVitoriana()));

            Console.WriteLine(mesa.Nome);
            Console.WriteLine(mesa.MostrarPreco());

            Console.WriteLine(sofa.Nome);
            Console.WriteLine(sofa.MostrarPreco());
        }

        public bool CompararEstilos(IMobilia movel1, IMobilia movel2)
        {
            return movel1.Comparar(movel2);
        }


    }
}
