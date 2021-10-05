using System;

namespace Ejemplos
{
    /// <summary>
    /// Imprimir en pantalla los números del 1 al 100
    /// </summary>
    class Ejercicio02 : IEjercicio
    {
        public void Ejecutar()
        {
            int numero=0;

            while (numero < 100)
            {
                numero++;
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }

        public void Ejecutar2()
        {
 
            for(int numero = 1; numero <= 100; numero++)          
                Console.WriteLine(numero);
            
            Console.ReadKey();
        }
    }
}
