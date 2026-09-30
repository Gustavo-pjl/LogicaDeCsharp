using System;
using System.IO;
using System.Collections.Generic;

namespace Aula02_Saida_D_Dados
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //Saída de dados: É o processo de enviar informações do programa para o usuário, geralmente através da tela do computador.
            //Tipos de saída de dados: Console.WriteLine(), Console.Write(), Console.ReadLine(), Console.ReadKey()
            //Console.WriteLine(): Escreve uma linha de texto na tela e pula para a próxima linha.
            //Console.Write(): Escreve um texto na tela sem pular para a próxima linha.
            //Console.ReadLine(): Lê uma linha de texto digitada pelo usuário.
            //Console.ReadKey(): Lê uma tecla pressionada pelo usuário.

            Console.WriteLine("Olá, mundo!");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome + "!");

             // ou

            Console.WriteLine($"Olá, {nome}!");
            Console.Write("Pressione qualquer tecla para continuar...");

           
            Console.ReadKey();

            //Para escrever o conteudo de uma variavel com pontos flutuantes, podemos utilizar o formato de string interpolada, que permite inserir variáveis dentro de uma string utilizando chaves {}. Exemplo:
            double numero = 10.515515;

            Console.WriteLine($"O número é: {numero}");
            //Para limitar o número de casas decimais, podemos utilizar o formato de string interpolada com a especificação de formato. Exemplo:
            Console.WriteLine($"O número com duas casas decimais é: {numero:F2}");
            //Paraf fazer a formatação de uma variável do tipo double para exibir apenas duas casas decimais, podemos utilizar o método ToString() com o formato "F2". Exemplo:
            Console.WriteLine("O número com duas casas decimais é: " + numero.ToString("F2"));
            //para fazer no formato de cultura brasileira, usamos o cultureinfo, que é uma classe do namespace System.Globalization. Exemplo:
            Console.WriteLine("O número com duas casas decimais no formato brasileiro é: " + numero.ToString("F2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR")));


            //Para concatenar variáveis em uma string, podemos utilizar o operador +. Exemplo:
            string nomeCompleto = "João" + " " + "Silva";
            Console.WriteLine("O nome completo é: " + nomeCompleto);

            int idade, anoNascimento;
            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            anoNascimento = DateTime.Now.Year - idade;
            Console.WriteLine("O ano de nascimento é: " + anoNascimento);
                
            
            



        }
    }
}