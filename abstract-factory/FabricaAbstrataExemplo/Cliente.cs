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
            Console.ReadLine();
        }

        public void MetodoCliente(IFabricaDeMobilia fabrica) 
        {
            var cadeira = fabrica.CriarCadeira();

            var mesa = fabrica.CriarMesa();

            var sofa = fabrica.CriarSofa();

            Console.WriteLine(cadeira.Reclinar());
            Console.WriteLine(mesa.RegularAltura());
            Console.WriteLine(sofa.Estender());
        }


    }
}
