using System;

namespace Ejemplos
{
    /// <summary>
    /// Imprimir un tablero de ajedrez.
    /// 
    /// Ejemplo:
    /// 
    /// 0 1 0 1 0 1 0 1
    /// 1 0 1 0 1 0 1 0
    /// 0 1 0 1 0 1 0 1
    /// 1 0 1 0 1 0 1 0
    /// 0 1 0 1 0 1 0 1
    /// 1 0 1 0 1 0 1 0
    /// 0 1 0 1 0 1 0 1
    /// 1 0 1 0 1 0 1 0
    /// </summary>
    class Ejercicio13 : IEjercicio
    {
        public void Ejecutar()
        {
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                    Console.Write((i + j) % 2 + " ");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        /*private bool esPar(int i, int j)
        {
            bool resultado;
            resultado = (i + j) % 2 == 0;
            return resultado;
        }*/
    }
}
