using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprendendo_CS03
{
    public class ProgramIF
    {
        static void Main(string[]args){

        

            System.Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade < 18){

                System.Console.WriteLine("Voce é menor de idade");
            }else{
                System.Console.WriteLine("Voce é Maior de idade");
            }

        }
    }
}