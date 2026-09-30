using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Aula07_Estrutura_Condicional
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //Estrutura condicional
            //if (condição) {bloco de código a ser executado se a condição for verdadeira}
            //if (condição) {bloco de código a ser executado se a condição for verdadeira} else {bloco de código a ser executado se a condição for falsa}

            //Exemplo:
            if (5 > 10)
            {
                Console.WriteLine("5 é maior que 10");
            }
            else
            {
                Console.WriteLine("5 não é maior que 10");
            }
        }
    }
}