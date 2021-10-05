using System;

namespace Ejemplos
{
    /// <summary>
    /// Dado el array que representa los ingresos mensuales de UNIMA, 
    /// imprimir la lista de los meses que superaron la meta de $2'300'000.00 y una lista de los que no.
    /// </summary>
    class Ejercicio17 : IEjercicio
    {
        int[] ingresos = new int[12] { 2156099, 2253358, 2473254, 2241575, 2554071, 2232922, 1880734, 2012356, 2397731, 3145684, 3770791, 3608749 };
        string[] meses = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        public void Ejecutar()
        {
            Console.WriteLine("Meses que superan la meta");
            for (int i = 0; i < meses.Length; i++)
                if (ingresos[i] > 2300000)
                    Console.WriteLine("Los ingresos de " + meses[i] + " Fueron: " + ingresos[i].ToString("C2"));
            Console.WriteLine("\nMeses que no superan la meta");
            for (int j = 0; j < meses.Length; j++)
                if (ingresos[j] < 2300000)                  
                    Console.WriteLine("Los ingresos de " + meses[j] + " Fueron: " + ingresos[j].ToString("C2"));
            Console.ReadKey();
        }
    }
}
