using System;

namespace Ejemplos
{
    /// <summary>
    /// Recibir como input de entrada un número de horas y devolver como resultado su equivalencia en segundos.
    /// </summary>
    class Ejercicio05 : IEjercicio
    {
        public void Ejecutar()
        {
            string input;
            int horas;

            do
            {
                Console.Write("Ingrese un numero de horas: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out horas));

            Console.WriteLine(horas*3600+" Segundos");
            Console.ReadKey();

        }
    }
}
