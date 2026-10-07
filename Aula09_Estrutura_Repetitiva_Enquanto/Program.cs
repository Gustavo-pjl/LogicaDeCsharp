using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Aula08_Switch_case
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //Estrutura de repetição "Enquanto" (while)
            //A estrutura de repetição "Enquanto" (while) é usada para repetir um bloco
            //de código enquanto uma condição for verdadeira. A condição é verificada antes da execução do bloco de código.
            //Exemplo 1:
            /*Fazer um progrma que lê numeros inteiros ate que um zero seja lido. Ao final mostra a soma dos numeros lidos.*/

            //Exemplo 1:

            int x;
            int soma = 0;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"O valor da soma é {soma}");


        }
    }
}