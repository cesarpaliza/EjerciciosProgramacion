using System;

namespace Ejemplos
{
    /// <summary>
    /// Dado el array que representa los ingresos mensuales de UNIMA, 
    /// devolver un array con los valores trimestrales equivalentes.
    /// </summary>
    class Ejercicio16 : IEjercicio
    {
        int[] ingresos = new int[12] { 2156099, 2253358, 2473254, 2241575, 2554071, 2232922, 1880734, 2012356, 2397731, 3145684, 3770791, 3608749 };
        double[] total = new double[4];
        public void Ejecutar()
        {
            int aux = 0;
            int flag = 0;
            for (int i = 1; i < 13; i++)
            {
                aux = aux + ingresos[i-1];
                if (i%3==0)
                {
                    total[flag] = aux;
                    flag++;
                    aux = 0;
                }
            }
            imprimirTrimestre();
            Console.ReadKey();
        }

        private void imprimirTrimestre()
        {
            string[] trimestres = new string[4] { "Primer Trimestre", "Segundo Trimestre", "Tercer Trimestre", "Cuarto Semestre" };
            for (int j=0;j<4;j++)
                Console.WriteLine("Ingresos en el "+trimestres[j]+":"+total[j].ToString("C2"));
        }
    }
}
