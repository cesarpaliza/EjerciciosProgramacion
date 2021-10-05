using System;

namespace Ejemplos
{
    /// <summary>
    /// Recibir como input de entrada un numero de segundos y devolver como resultado su equivalencia en hora, minutos y segundos.
    /// 
    /// Ejemplo para el input = 5000 el resultado será:
    /// 
    /// 1:23:20
    /// </summary>
    class Ejercicio06 : IEjercicio
    {

        public void Ejecutar()
        {
            string input;
            int n=0;
            int hr = 0, min = 0;
            int sec = 0;
            do
            {
                Console.Write("Ingrese los segundos: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out n));

            hr = n / 3600;
            min = (n % 3600) / 60;
            sec = (n % 60);
            Console.WriteLine(hr+":"+min+":"+sec);
            Console.ReadKey();
        }
    }
}
