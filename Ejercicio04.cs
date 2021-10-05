using System;

namespace Ejemplos
{
    /// <summary>
    /// Imprimir las tablas de multiplicar del 1 al 10.
    /// 
    /// Ejemplo:
    /// 
    /// 1 X 1 = 1
    /// 1 X 2 = 2
    /// 1 X 3 = 3
    /// 1 X 4 = 4
    /// 1 X 5 = 5
    /// 1 X 6 = 6
    /// 1 X 7 = 7
    /// 1 X 8 = 8
    /// 1 X 9 = 9
    /// 
    /// 2 X 1 = 2
    /// ...
    /// </summary>
    class Ejercicio04 : IEjercicio
    {
        public void Ejecutar()
        {
            int n=1;
            int i=1;

            for (n = 1;n <= i; n++)
            {
                for (i = 1; i <= 9; i++)
                {
                    Console.WriteLine(n + " X " + i + " = " + n * i);
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }

        public void Ejecutar2()
        {
            crearColumna(1);
            Console.ReadKey();
        }

        private void crearTabla(int n, int aux)
        {
            Console.WriteLine(aux +" X " + n + " = " + n*aux);
            if (n <= 9)
            {
                crearTabla(n + 1,aux);
            }
        }

        private void crearColumna(int aux)
        {
            crearTabla(1,aux);
            Console.WriteLine("");
            if (aux <= 9)
            {
                crearColumna(aux+1);
            }

        }
    }
}
