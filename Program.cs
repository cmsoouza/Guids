// See https://aka.ms/new-console-template for more information
using System;

namespace Guids
{
    class Program
    {
        static void Main()
        {
            var id = Guid.NewGuid();
            id.ToString();

            //id = new Guid("ab59c2d1-a1b1-4399-89e4-eb9535f9516e");
            id = new Guid();
            //Console.WriteLine(id.ToString().Substring(0, 8));

            //if (id == Guid.NewGuid())
            Console.WriteLine(id);
        }

    }

}

/* 
    Anotações:

    Links para consultas:
    https://learn.microsoft.com/pt-br/dotnet/api/system.guid?view=net-7.0 

    - Assim esse identificador possui a possibilidade muito baixa de duplicação.
    - Ao utilizamos o NewGuid() inicializar uma nova instancia na guid.
    - Quando usamos o ToString() pode contexto o mesmo irá transformar o rach
      em uma string.
    - Algumas definições:
        => Identificadores (id) possuem particularidades particulares.
        => Para realizar operações em BD utilizando esses id usamos guids.
        => Cada execução o compilador irá gerar um novo rach da guid.
        => Passando para id somente um newGuid() sem paramentro retornará "0000"
    - Caso passassemos uma string para guid vazia o mesmo irá retornar
      erro de execeção.
    - Passando o mesmo rach para string o mesmo irá compilar o paramentro
      passado.



 */