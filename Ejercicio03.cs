using System;

namespace Ejemplos
{
    /// <summary>
    /// Tomar como input de entrada un número n y crear una piramide de n pisos.
    /// 
    /// Ejemplo, para n = 5 el resultado sería:
    /// 
    /// *
    /// **
    /// ***
    /// ****
    /// *****
    /// </summary>
    class Ejercicio03 : IEjercicio
    {
        public void Ejecutar()
        {
            int n;
            string input;

            do
            {
                Console.Write("Ingrese un numero: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out n));

            for (int i = 1;i <= n; i++)
            {
                for (int valor = 1; valor <= i; valor++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            
            Console.ReadKey();

        }
    }
}
