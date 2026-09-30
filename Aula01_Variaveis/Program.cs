using System;
using System.IO;
using System.Collections.Generic;

namespace Aula01_Variaveis
{
    public class Program
    {
         public static void Main(string[] args)
        {
        // Variáveis: Definição informal de um espaço na memória do computador para armazenar dados temporariamente.
        // Tipos de variáveis: int, double, float, char, string, bool
        // int: numeros inteiros, exemplo: 1, 2, 3, 4, 5
        // double: numeros decimais, exemplo: 1.5, 2.5, 3.5
        // float: numeros decimais, exemplo: 1.5f, 2.5f, 3.5f
        // char: caracteres, exemplo: 'a', 'b', 'c'
        // string: texto, exemplo: "Olá", "Mundo", "C#"
        // bool: verdadeiro ou falso, exemplo: true, false

        //Sintaxe: tipo nomeDaVariavel = valor;
        int idade = 25;
        double altura = 1.65;
        float peso = 70.5f;
        char genero = 'A';
        string nome = "João";
        bool isEstudante = true;

        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Peso: " + peso);
        Console.WriteLine("Gênero: " + genero);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("É estudante? " + isEstudante);


        //Tipos basicos em C# - inteiros, decimais, caracteres, texto e booleanos
        //byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal, char, string, bool

        //exemplos de variáveis com diferentes tipos
        // byte 0 a 255
        byte idadeByte = 25;
        // sbyte -128 a 127
        sbyte idadeSByte = -25;
        // short -32.768 a 32.767
        short idadeShort = 25;
        // ushort 0 a 65.535
        ushort idadeUShort = 25;
        // int -2.147.483.648 a 2.147.483.647
        int idadeInt = 25;
        // uint 0 a 4.294.967.295
        uint idadeUInt = 25;
        // long -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
        long idadeLong = 25;
        // ulong 0 a 18.446.744.073.709.551.615
        ulong idadeULong = 25;


        Console.WriteLine("Idade Byte: " + idadeByte);
        //byte é um tipo de dado que armazena números inteiros de 0 a 255, ocupando 1 byte na memória.
        Console.WriteLine("Idade SByte: " + idadeSByte);
        //sbyte é um tipo de dado que armazena números inteiros de -128 a 127, ocupando 1 byte na memória.
        Console.WriteLine("Idade Short: " + idadeShort);
        //short é um tipo de dado que armazena números inteiros de -32.768 a 32.767, ocupando 2 bytes na memória.
        Console.WriteLine("Idade UShort: " + idadeUShort);
        //ushort é um tipo de dado que armazena números inteiros de 0 a 65.535, ocupando 2 bytes na memória.
        Console.WriteLine("Idade Int: " + idadeInt);
        //int é um tipo de dado que armazena números inteiros de -2.147.483.648 a 2.147.483.647, ocupando 4 bytes na memória.
        Console.WriteLine("Idade UInt: " + idadeUInt);
        //uint é um tipo de dado que armazena números inteiros de 0 a 4.294.967.295, ocupando 4 bytes na memória.
        Console.WriteLine("Idade Long: " + idadeLong);
        //long é um tipo de dado que armazena números inteiros de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807, ocupando 8 bytes na memória.
        Console.WriteLine("Idade ULong: " + idadeULong);


        //Tipos decimais em C# - float, double, decimal
        //float -3.402823e38 a 3.402823e38
        float alturaFloat = 1.75f;
        //double -1.79769313486232e308 a 1.79769313486232e308
        double alturaDouble = 1.75;
        //decimal -7.9228162514264337593543950335e28 a 7.9228162514264337593543950335e28
        decimal alturaDecimal = 1.75m;
        Console.WriteLine("Altura Float: " + alturaFloat);
        //float é um tipo de dado que armazena números decimais de -3.402823e38 a 3.402823e38, ocupando 4 bytes na memória.
        Console.WriteLine("Altura Double: " + alturaDouble);
        //double é um tipo de dado que armazena números decimais de -1.79769313486232e308 a 1.79769313486232e308, ocupando 8 bytes na memória.
        Console.WriteLine("Altura Decimal: " + alturaDecimal);
        //decimal é um tipo de dado que armazena números decimais de -7.9228162514264337593543950335e28 a 7.9228162514264337593543950335e28, ocupando 16 bytes na memória.

        //Tipos de caracteres em C# - char, string
        //char - armazena um único caractere, exemplo: 'a', 'b', 'c'
        char letra = 'A';
        //string - armazena uma sequência de caracteres, exemplo: "Olá", "Mundo", "C#"
        string texto = "Olá, Mundo!";
        //char é um tipo de dado que armazena um único caractere, ocupando 2 bytes na memória.
        Console.WriteLine("Letra: " + letra);
        //string é um tipo de dado que armazena uma sequência de caracteres, ocupando 2 bytes por caractere na memória.
        Console.WriteLine("Texto: " + texto);
        //Tipos booleanos em C# - bool
        //bool - armazena verdadeiro ou falso, exemplo: true, false
        bool isEstudanteBool = true;
        //bool é um tipo de dado que armazena verdadeiro ou falso, ocupando 1 byte na memória.
        Console.WriteLine("É estudante? " + isEstudanteBool);


        //Como declarar variáveis em C# - sintaxe: tipo nomeDaVariavel = valor;
        //Exemplo:
        int idadeDeclarada = 25;
        //Não usar espaços em nomes de variáveis, não usar caracteres especiais, não usar palavras reservadas, não usar números no início do nome da variável, não usar acentos, não usar maiúsculas e minúsculas no mesmo nome da variável.
        Console.WriteLine("Idade declarada: " + idadeDeclarada);
        //sempre que declaramos uma variável, devemos atribuir um valor a ela, caso contrário, o compilador irá gerar um erro.

        }
    }
}