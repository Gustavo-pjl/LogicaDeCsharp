using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Aula06_Expressões_Lógicas
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //expressões lógicas
            //expressão -------> resultado -------> valor verdadeiro ou falso
            //a && b ---------> a e b? -------> true ou false
            //a || b ---------> a ou b? -------> true ou false
            //!a ------------> não a? -------> true ou false

            //5 > 10 && 5 < 10 --------> false
            //5 < 10 && 12 > 10 --------> true
            //5 > 10 || 5 < 10 --------> true
            //5 < 10 || 12 > 10 --------> true
            //!(5 > 10) --------> true
            //!5 < 10 -----------------> false
            
        }
    }
}