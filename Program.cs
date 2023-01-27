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

            id = new Guid("ab59c2d1-a1b1-4399-89e4-eb9535f9516e");
            Console.WriteLine(id.ToString().Substring(0, 8));
            //Console.WriteLine(id);
        }

    }

}

/* 
    Anotações:

    Links para consultas:
    https://learn.microsoft.com/pt-br/dotnet/api/system.guid?view=net-7.0 

    - Guids para que um identificador seja usado exclusivamente, utilizamos o guids.
    - Assim esse identificador possui a possibilidade muito baixa de duplicação.
    - Alguns definições usando metodos To e subtring;
        => Diminuição da quantidade de caracteres do identificador principal usando
           metodo substring().
        => Melhor manipulação dos dados.
 */