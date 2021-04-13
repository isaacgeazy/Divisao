using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
           int num, den, resu;
            
            Console.Write("Digite o numerador....: ");
            num = Int16.Parse(Console.ReadLine());

            Console.Write("Digite o denominador..:");
            den = Int16.Parse(Console.ReadLine());

            
            resu = num / den;

            if (den > 0) {
          
          
             Console.WriteLine($"{num} dividido por {den} é {resu}");

            }else{

  
              Console.WriteLine("Não é possível dividir por zero.");

            }



        }
    }
}
