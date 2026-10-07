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
            //else é um "se não", ou seja, se a condição for falsa, o bloco de código do else será executado.

            //Exemplo 1 if e else:

            //Simples / Composto
            //if (condição) 
            // {
            //    bloco de código a ser executado se a condição for verdadeira
            // }

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo");
            }
            else
            {
                Console.WriteLine("O número é negativo");
            }

            //exemplo 2 if e else if:
            Console.WriteLine("Informe a hora (0-23): ");
            int hora = int.Parse(Console.ReadLine());

            if (hora >= 0 && hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

         
        }
    }
}