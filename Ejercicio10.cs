using System;

namespace Ejemplos
{
    /// <summary>
    /// Imprimir los primeros 100 números primos.
    /// </summary>
    class Ejercicio10 : IEjercicio
    {
        public void Ejecutar()
        {
            Ejercicio08 validar = new Ejercicio08();
            int n = 1, aux = 2;
            while (n <= 100)
            {
                if (validar.validarNumeroPrimo(aux))
                {
                    Console.WriteLine(aux);
                    n++;
                }
                aux++;
            }
            Console.ReadKey();
        }
    }
}
