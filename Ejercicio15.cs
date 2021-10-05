using System;

namespace Ejemplos
{
    /// <summary>
    /// Dado el array que representa los ingresos mensuales de UNIMA, 
    /// devolver un array con sus valores porcentuales con respecto a 
    /// la suma total de sus elementos.
    /// </summary>
    class Ejercicio15 : IEjercicio
    {
        int[] ingresos = new int[12] { 2156099, 2253358, 2473254, 2241575, 2554071, 2232922, 1880734, 2012356, 2397731, 3145684, 3770791, 3608749 };
        double[] total = new double[12];
        Ejercicio14 imprimir = new Ejercicio14();
        public void Ejecutar()
        {
            calcularPorcentaje();
            Console.ReadKey();
        }
        private void calcularPorcentaje()
        {
            double aux = 0;
            for (int i = 0; i < 12; i++)
                aux = aux + ingresos[i];
            for (int j = 0; j < 12; j++)
                total[j] = (ingresos[j] * 100) / aux;
            imprimir.imprimirIngresos(total, "F2", "%");
        }
    }
}
