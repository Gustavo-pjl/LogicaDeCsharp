using System;
using System.IO;
using System.Collections.Generic;

namespace Aula03_Proces_De_Dados_Casting01
{
    public class Program
    {
         public static void Main(string[] args)
        {
         //Casting: É o processo de conversão de um tipo de dado para outro tipo de dado. Existem dois tipos de casting: implícito e explícito.
        //Casting implícito: É a conversão automática de um tipo de dado para outro tipo de dado, sem a necessidade de intervenção do programador. Exemplo: int para double.
        //Casting explícito: É a conversão de um tipo de dado para outro tipo de dado, com a necessidade de intervenção do programador. Exemplo: double para int.
        //Sintaxe: (tipo)variavel;  

        //regra geral, o casting implícito é feito quando o tipo de dado de destino é maior que o tipo de dado de origem. Exemplo: int para double.
        //regra geral, o casting explícito é feito quando o tipo de dado de destino é menor que o tipo de dado de origem. Exemplo: double para int.


        //Exemplo de casting implícito:

        int x, y;
        x = 10;
        y = 2 * x; //casting implícito de int para double
        Console.WriteLine("O valor de x é: " + x);
        Console.WriteLine("O valor de y é: " + y);

        //Exemplo de casting explícito:
        double z = 10.5;
        int w = (int)z; //casting explícito de double para int
        Console.WriteLine("O valor de z é: " + z);
        Console.WriteLine("O valor de w é: " + w);

        //Calculando a area de um trapezio, onde a base maior é 10, a base menor é 5 e a altura é 4. A area do trapezio é dada pela formula: area = (baseMaior + baseMenor) * altura / 2. O resultado da area deve ser exibido com duas casas decimais.
        double baseMaior = 10;
        double baseMenor = 5;
        double altura = 4;
        double area = (baseMaior + baseMenor) * altura / 2;
        
        Console.WriteLine("A area do trapezio é: " + area);


        //Boas praticas de casting: Sempre que possível, utilize o casting implícito,
        //pois ele é mais seguro e evita perda de dados. Evite o uso de casting explícito, 
        // pois ele pode causar perda de dados e erros de execução. Sempre que possível,
        //  utilize o tipo de dado mais adequado para a variável, evitando assim a necessidade de casting
        // 
        
        //Boas praticas de float e double
        // Double é mais preciso que float, mas ocupa mais memória. Float é mais rápido que double, 
        // mas menos preciso. Use double quando precisar de precisão e float quando precisar de velocidade.

        //float é um tipo de dado que ocupa 4 bytes de memória e tem uma precisão de 7 dígitos decimais. 
        // Double é um tipo de dado que ocupa 8 bytes de memória e tem uma precisão de 15 dígitos decimais.
        //  Use float quando precisar de velocidade e double quando precisar de precisão.

        //Boa pratica: sempre indique o tipo do numero, por exemplo: 10.5f para float e 10.5 para double. 
        // Evite usar o tipo de dado padrão, pois ele pode causar perda de dados e erros de execução.


        //Exemplo 2:

        int a, b;
        double resultado;

        a = 5; 
        b = 2;
        resultado = (double)a / b; //casting explícito de int para double

        }

    }
}