using System;

namespace Ejemplos
{
    /// <summary>
    /// Recibir como input de entrada un número n y determinar si es un número primo.
    /// </summary>
    class Ejercicio08 : IEjercicio
    {
        public void Ejecutar()
        {
            string input, mensaje = "El numero es primo";
            int n;
            do
            {
                Console.Write("Ingrese un numero: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out n));

            if (validarNumeroPrimo(n)==false)
            {
                mensaje = "El numero no es primo";
            }
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
        private bool EsDivisible(int valor,int i)
        {
            bool resultado;
            resultado = valor % i == 0;
            return resultado;
        }

        public bool validarNumeroPrimo(int n)
        {
            if (n == 1)
                return false;
            for (int i = 2; i < n; i++)
            {
                if (EsDivisible(n, i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
