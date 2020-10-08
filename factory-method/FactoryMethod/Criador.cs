using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //A classe "Criador" declara a fábrica de métodos que retornará
    //um objeto da classe "Produto". As subclasses de "Criador" geralmente fornecem
    //a implementação desse médodo.
    abstract class Criador
    {
        //Note que o "Criador" pode também fornercer alguma implementação padrão da Factory Method.
        public abstract IProduto FactoryMethod();

        //Observe também que, independente de seu nome, a responsabilidade do "Criador" primário
        //não é criar produtos. Geralmente, ele contém alguma lógica central de negócios que depende
        //dos objetos Produtos retornados pelo Factory Method. Subclasses podem indiretamente mudar essa
        //lógica de negócios sobrescrevendo o Factory Method e retornando um tipo diferente de produto.

        public string SomeOperation()
        {
            //Chama o Factory Method para criar o Objeto Produto.
            var product = FactoryMethod();

            //Agora, usa o Produto.
            var result = "Creator: O mesmo código do Creator trabalhando com" + product.Operation();

            return result;
        }
    }
}
