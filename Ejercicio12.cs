using System;

namespace Ejemplos
{
    /// <summary>
    /// Recibir como input de entrada el año, el mes y el día de nacimiento de un 
    /// paciente e imprimir su edad en años. Si el paciente tiene menos de un año 
    /// de vida, mostrar la edad en días
    /// </summary>
    class Ejercicio12 : IEjercicio
    {
        public void Ejecutar()
        {
            int anio = 0, mes = 0, dia = 0, n = 0, edad = 0;
            string input;
            do
            {
                Console.Write("Ingrese su año de nacimiento: ");
                input = Console.ReadLine();
                int.TryParse(input, out n);
                validarAnio(n);
                anio = n;
            } while (!validarAnio(n));
            mes = validarMes();
            dia = validarDia(mes);
            DateTime fecha = new DateTime(anio, mes, dia);
            Console.WriteLine(fecha.ToString("dd/MM/yyyy"));
            calcularEdad(anio, mes, dia);
            Console.ReadKey();
        }
        public bool validarAnio(int n)
        {
            DateTime fechaActual = DateTime.Now;
            if (n > fechaActual.Year || n < 1800)
            {
                Console.WriteLine("El año ingresado es incorrecto, porfavor intente de nuevo");
                return false;
            }
            return true;
        }
        public int validarMes()
        {
            int n;
            string input;
            bool flag;
            do
            {
                Console.Write("Ingrese su mes de nacimiento: ");
                input = Console.ReadLine();
                flag = int.TryParse(input, out n);

                if (flag)
                {
                    if (n > 12 || n < 1)
                    {
                        Console.WriteLine("El mes ingresado es incorrecto, por favor intente de nuevo");
                        flag = false;
                    }
                }
            } while (!flag);
            return n;
        }
        public int validarDia(int mes)
        {
            int n;
            string input;
            bool flag;
            do
            {
                Console.Write("Ingrese su dia de nacimiento: ");
                input = Console.ReadLine();
                flag = int.TryParse(input, out n);
                if (flag)
                {
                    if (n < 1)
                    {
                        Console.WriteLine("El dia ingresado es incorrecto, por favor intente de nuevo");
                        flag = false;
                    }
                    else if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    {
                        if (n > 31)
                        {
                            Console.WriteLine("El dia ingresado es incorrecto, por favor intente de nuevo");
                            flag = false;
                        }
                    }
                    else if (mes == 2)
                    {
                        if (n > 28)
                        {
                            Console.WriteLine("El dia ingresado es incorrecto por favor intente de nuevo");
                            flag = false;
                        }
                    }
                    else
                    {
                        if (n > 30)
                        {
                            Console.WriteLine("El dia ingresado es incorrecto por favor intente de nuevo");
                            flag = false;
                        }
                    }
                }
            } while (!flag);
            return n;
        }
        private int calcularEdad(int anio, int mes, int dia)
        {
            DateTime fecha = new DateTime(anio, mes, dia);
            DateTime fechaActual = DateTime.Now;
            int edad = 0;
            var edadDias = (fechaActual - fecha).TotalDays;
            if (edadDias > 365)
            {
                if ((fechaActual.Month - mes) >= 0)
                {
                    if ((fechaActual.Day - dia) >= 0)
                    {
                        edad = fechaActual.Year - anio;
                    }
                    else
                    {
                        edad = fechaActual.Year - anio - 1;
                    }
                }
                else
                {
                    edad = fechaActual.Year - anio - 1;
                }
                Console.WriteLine("Su edad es: " + edad + " Años");
            }
            else
            {
                int edadDiasRes = Convert.ToInt32(edadDias);
                Console.WriteLine("Su edad es: " + edadDiasRes + " Dias");
                return edadDiasRes;
            }
            return edad;
        }
    }
}
