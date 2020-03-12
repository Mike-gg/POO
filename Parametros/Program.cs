using System;

namespace Parametros
{
    class Prueba
    {
        public static void SumaUno(ref int x)
        {
            x = x + 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            Prueba.SumaUno(ref a);
            Console.WriteLine(a);

        }
    }
}