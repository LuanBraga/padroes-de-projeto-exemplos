using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica
{
    class Cliente
    {
        public void Main() 
        {
            Console.WriteLine("Aplicação iniciada com transporte terrestre");
            CodigoCliente(new LogisticaTerrestre());

            Console.WriteLine("\n");
            
            Console.WriteLine("Aplicação iniciada com transporte marítimo");
            CodigoCliente(new LogisticaMaritima());

            Console.WriteLine("\n");

            Console.WriteLine("Aplicação iniciada com transporte aéreo");
            CodigoCliente(new LogisticaAerea());

            Console.ReadLine();
        }

        public void CodigoCliente(Logistica log)
        {
            Console.WriteLine(log.Entregar());
            Console.WriteLine(log.CalculaFrete(200, 15));
        }
    }
}
