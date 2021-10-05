using System;

namespace Ejemplos
{
    /// <summary>
    /// Crear un menú para poder elegir que Ejercicio probar sin tener 
    /// que reeditar el archivo Program.cs cada vez que se necesite.
    /// </summary>
    class Ejercicio20
    {
        public void Ejecutar()
        {
            string input = "";
            int n = 0;
            IEjercicio ejercicio = new Ejercicio01();
            do
            {
                do
                {
                    Console.Write("Ingrese el ejercicio a ejecutar(1-19): ");
                    input = Console.ReadLine();
                } while (!(esNumero(input,out n) || input == "?" || input == "exit"));
                if (n > 0 && n < 20)
                {
                    switch (n)
                    {
                        case 1: ejercicio = new Ejercicio01(); break;
                        case 2: ejercicio = new Ejercicio02(); break;
                        case 3: ejercicio = new Ejercicio03(); break;
                        case 4: ejercicio = new Ejercicio04(); break;
                        case 5: ejercicio = new Ejercicio05(); break;
                        case 6: ejercicio = new Ejercicio06(); break;
                        case 7: ejercicio = new Ejercicio07(); break;
                        case 8: ejercicio = new Ejercicio08(); break;
                        case 9: ejercicio = new Ejercicio09(); break;
                        case 10: ejercicio = new Ejercicio10(); break;
                        case 11: ejercicio = new Ejercicio11(); break;
                        case 12: ejercicio = new Ejercicio12(); break;
                        case 13: ejercicio = new Ejercicio13(); break;
                        case 14: ejercicio = new Ejercicio14(); break;
                        case 15: ejercicio = new Ejercicio15(); break;
                        case 16: ejercicio = new Ejercicio16(); break;
                        case 17: ejercicio = new Ejercicio17(); break;
                        case 18: ejercicio = new Ejercicio18(); break;
                        case 19: ejercicio = new Ejercicio19(); break;
                        default:
                            break;
                            Console.WriteLine("Numero de ejercicio incorrecto, escria '?' para mas ayuda");
                    }
                    ejercicio.Ejecutar();
                    Console.Write("Desea salir del programa?(yes/no)");
                    input = Console.ReadLine();
                    Console.Clear();
                }
                else if (input == "?")
                {
                    Console.Clear();
                    input = "no";
                    Console.WriteLine("---Listado de ejercicios--- \nEjercicio 1: Saber si un numero es divisible entre 17\nEjercicio 2: Imprimir numeros del 1-100" +
                        "\nEjercicio 3: Tomar como input de entrada un número n y crear una piramide de n pisos\nEjercicio 4: Imprimir las tablas de multiplicar del 1 al 10." +
                        "\nEjercicio 5: Recibir como input de entrada un número de horas y devolver como resultado su equivalencia en segundos.\nEjercicio 6: Recibir segundos como input y devolver como resultado su equivalencia en hora, minutos y segundos." +
                        "\nEjercicio 7: Imprimir una lista con los primeros 100 números naturales sujeto a las siguientes reglas:(bizz buzz)\nEjercicio 8: Recibir como input de entrada un número n y determinar si es un número primo." +
                        "\nEjercicio 9: Imprimir los números primos que hay en los primeros 100 números naturales.\nEjercicio 10: Imprimir los primeros 100 números primos." +
                        "\nEjercicio 11: Imprimir los números que no son primos en los primeros 100 números naturales.\nEjercicio 12: Recibir como input el año, el mes y el día de nacimiento de un paciente e imprimir su edad en años." +
                        "\nEjercicio 13: Imprimir un tablero de ajedrez.\nEjercicio 14: Dado el array que representa los ingresos mensuales, devolver un array con sus valores acumulados." +
                        "\nEjercicio 15: Dado el array que representa los ingresos mensuales, devolver un array con sus valores porcentuales con respecto a la suma total de sus elementos." +
                        "\nEjercicio 16: Dado el array que representa los ingresos mensuales, devolver un array con los valores trimestrales equivalentes." +
                        "\nEjercicio 17: Dado el array que representa los ingresos mensuales, imprimir la lista de los meses que superaron la meta de $2'300'000.00 y una lista de los que no." +
                        "\n\n---Otros comandos---\nexit: para salir\n?: para listar los comandos");
                }
                else if (input == "exit")
                {
                    input = "yes";
                }
                else
                {
                    Console.WriteLine("Ejercicio no encontrado, escribe '?' para recibir ayuda");
                    input = "no";
                }
            } while (input == "no");
        }
        private bool esNumero(string input,out int n)
        {
            bool resultado = false;
            resultado = int.TryParse(input, out n);
            return resultado;
        }
    }
}
