using System;

namespace Exercicio_Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
           int numerador, denominador, resultado;

            Console.Write("Coloque o Numerador...: ");
            numerador = Int16.Parse(Console.ReadLine());

            Console.Write("Coloque o Denominador...: ");
            denominador = Int16.Parse(Console.ReadLine());

                resultado = numerador / denominador; 

            if (denominador > 0)
            {
                Console.WriteLine($"{numerador} dividido por {denominador} é {resultado}");
            }

            else
            {
            
                Console.WriteLine("Não é possivel dividir por zero!");
            }
                

            

        }
    }
}
