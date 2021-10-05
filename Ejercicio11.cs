using System;

namespace Ejemplos
{
    /// <summary>
    /// Imprimir los números que no son primos en los primeros 100 números naturales.
    /// </summary>
    class Ejercicio11 : IEjercicio
    {
        public void Ejecutar()
        {
            Ejercicio08 validar = new Ejercicio08();

            for (int i=1;i<=100;i++)
            {
                if (!validar.validarNumeroPrimo(i))
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
