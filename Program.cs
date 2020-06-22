using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "100 Dolares em reais: " +Conversor.ConversorDolarParaReal(100));
            Console.WriteLine("100 Reais em Dolares: " +Conversor.ConversorRealParaDolar(100));

            System.Console.WriteLine("100 Euros em Reais: " +Conversor.ConversorEuroParaReal(100));
            System.Console.WriteLine("100 Reais em Euros: " +Conversor.ConversorRealParaEuro(100));


        }
    }
}
