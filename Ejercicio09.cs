using System;

namespace Ejemplos
{
    /// <summary>
    /// Imprimir los números primos que hay en los primeros 100 números naturales.
    /// </summary>
    class Ejercicio09 : IEjercicio
    {
        public void Ejecutar()
        {
            Ejercicio08 validar = new Ejercicio08();
            for (int i = 2; i < 100; i++)           
                if (validar.validarNumeroPrimo(i))
                    Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
