using System;

namespace Ejemplos
{
    /// <summary>
    /// Imprimir una lista con los primeros 100 números naturales sujeto a las siguientes reglas:
    ///   Cuando el número a imprimir sea 3 o multiplo de 3, reemplazarlo por la palabra "bizz"
    ///   Cuando el número a imprimir sea 5 o multiplo de 5, reemplazarlo por la palabra "buzz"
    ///   Cuando el número a imprimir sea multiplo de 3 y de 5, reemplazaro por la palabra "bizzbuzz"
    /// </summary>
    class Ejercicio07 : IEjercicio
    {
        public void Ejecutar()
        {
            for (int n = 1; n <= 100; n++)
            {
                if (IsThree(n))
                    Console.Write("bizz");
                if (IsFive(n))
                    Console.Write("buzz");
                else if (!IsThree(n))
                    Console.Write(n);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        private bool IsThree(int n)
        {
            bool resultado;
            resultado = n % 3 == 0;
            return resultado;
        }

        private bool IsFive(int n)
        {
            bool resultado;
            resultado = n % 5 == 0;
            return resultado;
        }
    }
}
