using System;
using System.IO;
using System.Collections.Generic;

namespace Funções_Mat
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //Funções matemáticas:
            //Math.Sqrt() - Retorna a raiz quadrada de um número.
            //Math.Pow() - Retorna o valor de um número(x)elevado a uma potência(y).
            //Math.Abs() - Retorna o valor absoluto de um número.

            //Criação de variáveis para armazenar os números a serem utilizados nas funções matemáticas.
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double a, b, c;

            a = Math.Sqrt(x); // Raiz quadrada de x
            b = Math.Sqrt(y); // Raiz quadrada de y
            c = Math.Sqrt(z); // Raiz quadrada de z (número negativo, retornará NaN)

            Console.WriteLine("Raiz quadrada de " + x + " é: " + a);
            Console.WriteLine("Raiz quadrada de " + y + " é: " + b);
            Console.WriteLine("Raiz quadrada de " + z + " é: " + c); // Retorna NaN (Not a Number) para números negativos   

            a = Math.Pow(x, y); // x elevado a y
            b = Math.Pow(x, 2.0); // x elevado a 2
            c = Math.Pow(5.0, 2.0); // 5 elevado a 2
            Console.WriteLine("Potência de " + x + " elevado a " + y + " é: " + a);
            Console.WriteLine("Potência de " + x + " elevado a 2 é: " + b);
            Console.WriteLine("Potência de 5.0 elevado a 2.0 é: " + c);

            a = Math.Abs(y); // Valor absoluto de y
            b = Math.Abs(z); // Valor absoluto de z
            Console.WriteLine("Valor absoluto de " + y + " é: " + a);
            Console.WriteLine("Valor absoluto de " + z + " é: " + b);

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }  
    }
}     