using System;

namespace Exercicio_Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerador, denominador, resultado;

            Console.Write("Coloque o Numerador...: ");
            numerador = Double.Parse(Console.ReadLine());

            Console.Write("Coloque o Denominador...: ");
            denominador = Double.Parse(Console.ReadLine());

            if (denominador != 0)
            {
                resultado = numerador / denominador;
                Console.WriteLine($"{numerador} dividido por {denominador} é {resultado}");
            }

            else
            {
                Console.WriteLine("Não é possivel dividir por zero!");
            }

        }
    }
}
