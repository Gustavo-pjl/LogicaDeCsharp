using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Aula08_Switch_case
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //Como funciona a estrtura de Switch Case:
            /*Quando se tem três ou mais opções de fluxo
              a serem tratadas com base no valor de uma variável,
              ao inves de usar múltiplos if-else  encadeados,
              alguns preferem usar a estrutura de Switch Case*/


              //Atividade 1:
              /*Faça um programa para ler um valor inteiro de 1 a 7 representados um dia da semana
              sendo 1 = Domingo, 2 = Segunda, 3 = Terça, 4 = Quarta, 5 = Quinta, 6 = Sexta, 7 = Sábado
              Escrever na tela o dia da semana correspondente*/

              //Organização de dados
              string Barra = "---------------------------------\n";

              //Solicitação de dados
                Console.WriteLine("----------Calculadora de dias da semana----------");
                Console.WriteLine("Informe um número de 1 a 7 para saber qual dia da semana ele representa: ");
                int dia = int.Parse(Console.ReadLine());

                //Estrutura de Switch Case
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("O número informado representa o dia Domingo");
                        break;
                    case 2:
                        Console.WriteLine("O número informado representa o dia Segunda-feira");
                        break;
                    case 3:
                        Console.WriteLine("O número informado representa o dia Terça-feira");
                        break;
                    case 4:
                        Console.WriteLine("O número informado representa o dia Quarta-feira");
                        break;
                    case 5:
                        Console.WriteLine("O número informado representa o dia Quinta-feira");
                        break;
                    case 6:
                        Console.WriteLine("O número informado representa o dia Sexta-feira");
                        break;
                    case 7:
                        Console.WriteLine("O número informado representa o dia Sábado");
                        break;
                    default:
                        Console.WriteLine("Número inválido, informe um número de 1 a 7 para saber qual dia da semana ele representa.");
                        break;

                    //Para que serve o default? O default é usado para tratar casos que não se encaixam em nenhum dos cases,
                    //ou seja, quando o valor da variável não corresponde a nenhum dos valores esperados. Ele funciona como 
                    //um "else" em uma estrutura if-else, garantindo que sempre haja uma resposta para qualquer valor de entrada, mesmo que seja inválido.

                    //fim da estrutura de Switch Case
                    
                }
        }
    }
}