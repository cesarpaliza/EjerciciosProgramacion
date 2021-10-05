using System;

namespace Ejemplos
{
    /// <summary>
    /// Determinar si un número ingresado por el usuario es divisible entre 17 o no.
    /// </summary>
    class Ejercicio01 : IEjercicio
    {

        // Versión 1
        private bool EsDivisible(int valor)
        {
            bool resultado;
            resultado = valor % 17 == 0;
            return resultado;
        }

        public void Ejecutar()
        {
            string input;
            int numero;
            bool resultado;
            do
            {
                Console.Write("Ingrese un número: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out numero));
            resultado = EsDivisible(numero);
            if (resultado)
                Console.Write("El número es divisible entre 17.");
            else
                Console.Write("El número no es divisible entre 17.");
            Console.ReadKey();
        }







        // Versión 2
        private bool EsDivisible2(int valor)
        {
            return valor % 17 == 0;
        }

        private bool EsNumero(string input, out int valor)
        {
            return int.TryParse(input, out valor);
        }

        private int CapturarNumero()
        {
            string input;
            int resultado;
            do
            {
                Console.Write("Ingrese un número: ");
                input = Console.ReadLine();
            } while (!EsNumero(input, out resultado));
            return resultado;
        }

        public void Ejecutar2()
        {
            if (EsDivisible2(CapturarNumero()))
                Console.Write("El número es divisible entre 17.");
            else
                Console.Write("El número no es divisible entre 17.");
            Console.ReadKey();
        }
    }
}
