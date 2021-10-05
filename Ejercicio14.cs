using System;

namespace Ejemplos
{
    /// <summary>
    /// Dado el array que representa los ingresos mensuales de UNIMA, 
    /// devolver un array con sus valores acumulados.
    /// </summary>
    class Ejercicio14 : IEjercicio
    {
        int[] ingresos = new int[12] { 2156099, 2253358, 2473254, 2241575, 2554071, 2232922, 1880734, 2012356, 2397731, 3145684, 3770791, 3608749 };
        double[] total = new double[12];
        public void Ejecutar()
        {
            imprimirIngresos(total, "C2", "");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Imprime los meses
        /// </summary>
        /// <param name="total">valores que acompañan a los meses</param>
        /// <param name="formato">formato que desea imprimir los valores</param>
        /// <param name="posfijo">caracter al final del valor</param>
        public void imprimirIngresos(double[] total, string formato, string posfijo)
        {
            ingresosTotales();
            string[] meses = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            for (int j = 0; j < 12; j++)
                Console.WriteLine("Los ingresos de " + meses[j] + " Fueron: " + total[j].ToString(formato) + posfijo);
        }
        private void ingresosTotales()
        {
            total[0] = ingresos[0];
            for (int i = 1; i < 12; i++)
                total[i] = ingresos[i] + total[i - 1];
        }
    }
}
