using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Aula04_1_Atividade
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma casa decimal, bem como o valor do metro
            //quadrado do terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor do preço
            //do terreno, ambos com duas casas decimais, conforme exemplo.

            //Exemplo:

            //entrada                               | Saída
            //Digite a largura do terreno: 10.0     | Área do terreno = 300.00
            //30.0                                  |
            //Digite o comprimento do terreno: 30.0 | Preço do terreno = 60000.00


            //Area do terreno = largura * comprimento
            //Preço do terreno = area do terreno * valor do metro quadrado

            double largura, comprimento, valorMetroQuadrado, areaTerreno, precoTerreno;

            Console.WriteLine("Digite a largura do terreno: ");
            largura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno: ");
            comprimento = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do metro quadrado: ");
            valorMetroQuadrado = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaTerreno = largura * comprimento;
            precoTerreno = areaTerreno * valorMetroQuadrado;

            Console.WriteLine($"Área do terreno = {areaTerreno:F2}");
            Console.WriteLine($"Preço do terreno = {precoTerreno:F2}");
        }  
    }
}    