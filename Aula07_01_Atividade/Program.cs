using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Aula07_01_Atividade
{
    public class Program
    {
         public static void Main(string[] args)
        {
            /*Fazer um programa para ler as duas notas que o aluno obteve no primeiro
            e segundo semestres de uma disciplina anual. Em seguida, mostrar a nota final
            que  o aluno obteve no ano juntamente com um texto explicativo. Caso o a nota final 
            do aluno seja inferior a 60.0, mostrar a mensagem "REPROVADO", caso contrário,
            mostrar a mensagem "APROVADO". Conforme os exemplos, todos os valores devem ser
            lidos com uma casa decimal. */

            //Dados que vão ser introduzidos
            double N1;
            double N2;
            double N3;
            double N4;
            
            //Organização:
            string Barra = "---------------------------------\n";

            //Solicitação de dados:

            Console.WriteLine("----------Calculadora de notas----------");
            Console.WriteLine("Informe a nota de cada semestre conforme solicitada");

            //Aquisição de dados

            Console.WriteLine("Infome sua nota do primeiro Bimestre: ");
            N1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(Barra);

            Console.WriteLine("Infome sua nota do segundo Bimestre: ");
            N2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(Barra);

            Console.WriteLine("Infome sua nota do terceiro Bimestre: ");
            N3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(Barra);

            Console.WriteLine("Infome sua nota do quarto Bimestre: ");
            N4 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(Barra);

            //Organização de dados

            double Notas = N1 + N2 + N3 + N4;
            double Média = Notas/4;
            
            //Estrutura de condição

            if (Média >= 65.00)
            {
                Console.WriteLine($"Sua média foi de {Média.ToString("F1", CultureInfo.InvariantCulture)}, você está aprovado!!");
            }
            else
            {
                Console.WriteLine($"Sua média foi de {Média.ToString("F1", CultureInfo.InvariantCulture)}, você está Reprovado!!");
            }
        }
    }
}