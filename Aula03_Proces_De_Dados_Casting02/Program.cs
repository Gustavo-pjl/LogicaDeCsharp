using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Aula03_Proces_De_Dados_Casting02
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //Entrada de dados: O processo de entrada de dados é o processo de receber dados
            //do usuário ou de um arquivo. Existem várias formas de entrada de dados,
            //como: Console.ReadLine(), Console.Read(), Console.ReadKey(), File.ReadAllText(), 
            //File.ReadAllLines(), File.ReadLines(), etc.

            //Entrada de dados do usuário: O processo de entrada de dados do usuário é o processo de
            // receber dados do usuário através do console. Existem várias formas de entrada de dados 
            // do usuário, como: Console.ReadLine(), Console.Read(), Console.ReadKey(), etc.


            //Ler numero, caracter, numeros double, numeros float, numeros long, numeros short, numeros byte,
            //  numeros decimal, numeros bool, numeros char, numeros string, numeros DateTime, numeros TimeSpan,
            //  numeros Guid, numeros Uri, numeros IPAddress, numeros IPEndPoint, numeros EndPoint, numeros NetworkCredential,
            //  numeros NetworkInterface, numeros NetworkStream, numeros Socket, numeros TcpClient, numeros TcpListener,
            //  numeros UdpClient, numeros WebClient, numeros HttpClient, etc.

            int numero;
            Console.WriteLine("Digite um numero inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());
            //Convert.ToInt32() é um método da classe Convert que converte um valor para o tipo int. Ele pode converter
            //  valores de outros tipos, como string, double, float, etc. Se a conversão não for possível, 
            // ele lança uma exceção.
            

            int numero2;
            Console.WriteLine("Digite outro numero inteiro: ");
            numero2 = int.Parse(Console.ReadLine());
            //int.Parse() é um método da classe int que converte uma string para o tipo int. Ele pode converter
            //  valores de outros tipos, como string, double, float, etc. Se a conversão não for possível, ele lança uma exceção.
            //o QUE SERIA A EXECESSÃO? A exceção é um erro que ocorre durante a execução de um programa.
            //  Ela pode ser causada por vários fatores, como:
            //- Erros de sintaxe: quando o código não está escrito corretamente.
            //- Erros de tempo de execução: quando o programa encontra um problema durante a execução.

            char caracter;
            Console.WriteLine("Digite um caracter: ");
            caracter = Convert.ToChar(Console.ReadLine());
            //Convert.ToChar() é um método da classe Convert que converte um valor para o
            // tipo char. Ele pode converter valores de outros tipos, como string, double, float, etc. Se a conversão 
            // não for possível, ele lança uma exceção.
            char caracter2;
            Console.WriteLine("Digite outro caracter: ");
            caracter2 = char.Parse(Console.ReadLine());
            //char.Parse() é um método da classe char que converte uma string para o tipo
            // char. Ele pode converter valores de outros tipos, como string, double, float, etc. 
            // Se a conversão não for possível, ele lança uma exceção.


            double numeroDouble;
            Console.WriteLine("Digite um numero double: ");
            numeroDouble = Convert.ToDouble(Console.ReadLine());
            //Convert.ToDouble() é um método da classe Convert que converte um valor para o
            // tipo double. Ele pode converter valores de outros tipos, como string, int, float, etc. Se a conversão
            // não for possível, ele lança uma exceção.
            double numeroDouble2;
            Console.WriteLine("Digite outro numero double: ");
            numeroDouble2 = double.Parse(Console.ReadLine());
            //double.Parse() é um método da classe double que converte uma string para o tipo
            // double. Ele pode converter valores de outros tipos, como string, int, float, etc. Se a conversão
            // não for possível, ele não lança uma exceção.


            //Globalização: A globalização é o processo de integração econômica, social, cultural 
            // e política entre os países. Ela é caracterizada pelo aumento do comércio internacional, 
            // pela circulação de pessoas, informações e capitais, pela difusão de tecnologias e pela 
            // interdependência entre os países. A globalização tem impactos positivos e negativos na 
            // economia, na cultura, na política e no meio ambiente.

            //exemplo:

            double numeroDouble3;
            Console.WriteLine("Digite um numero double com ponto: ");
            numeroDouble3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //CultureInfo.InvariantCulture é uma propriedade da classe CultureInfo que representa a cultura invar
            // sável. Ela é usada para formatar e analisar valores de forma consistente, independentemente da cultura do sistema.

            Console.WriteLine("Valores digitados: ");
            Console.WriteLine("Numero inteiro: " + numero);
            Console.WriteLine("Outro numero inteiro: " + numero2);
            Console.WriteLine("Caracter: " + caracter);
            Console.WriteLine("Outro caracter: " + caracter2);
            Console.WriteLine("Numero double: " + numeroDouble);
            Console.WriteLine("Outro numero double: " + numeroDouble2);
            Console.WriteLine("Numero double com ponto: " + numeroDouble3.ToString("F2", CultureInfo.InvariantCulture));
            

            //Vetores: Um vetor é uma estrutura de dados que armazena uma coleção de elementos do mesmo tipo.

            Console.WriteLine("Digite seu nome, idade, sexo e altura (separados por espaço): ");
            
            string[] vet = Console.ReadLine().Split(' ');
            //Split() é um método da classe string que divide uma string em um array de strings
            // com base em um delimitador. Ele pode receber um ou mais delimitadores, que podem ser 
            // caracteres, strings ou expressões regulares.
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            char sexo = char.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}