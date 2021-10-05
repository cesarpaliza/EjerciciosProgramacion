using System;
using System.Collections.Generic;

namespace Ejemplos
{
    /// <summary>
    /// Tomando como base la siguiente estructura de clases, 
    /// Crear un menú que permita añadir números de teléfono 
    /// a cualquiera de los pacientes existentes e inmediatamente 
    /// después imprima la lista de pacientes con sus respectivos 
    /// teléfonos.
    /// </summary>
    class Ejercicio18 :IEjercicio
    {
        Paciente[] pacientes = new Paciente[4];
        public Ejercicio18()
        {
            pacientes[0] = new Paciente(1, "Guadalupe", "Medina", "Molina");
            pacientes[1] = new Paciente(2, "Efrain", "Castillo", "Meza");
            pacientes[2] = new Paciente(3, "Araceli", "Perez", "Martínez");
            pacientes[3] = new Paciente(4, "José", "Rios", "Cota");

            pacientes[0].Telefonos.Add("6672148581");
        }
        public void Ejecutar()
        {
            string aux = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Menu de pacientes\n1.-Listar paciente\n2.-Añadir número de teléfono\nexit.- Salir");
                aux = Console.ReadLine();
                if (aux == "1")
                {
                    menuPacientes();
                    aux = "";
                }
                else if (aux == "2")
                {
                    agregarNumTel();
                    aux = "";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opcion no valida, intente de nuevo");
                }
            } while (aux != "exit");
        }

        public void menuPacientes()
        {
            string res = "";
            do
            {
                Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(pacientes[i].Id + ".-"+" ");
                    Console.Write(pacientes[i].Nombre + " ");
                    Console.Write(pacientes[i].ApellidoPaterno + " ");
                    Console.Write(pacientes[i].ApellidoMaterno + " ");
                    foreach (object o in pacientes[i].Telefonos)
                    {
                        Console.WriteLine("");
                        Console.Write("\t"+o);
                    }
                    Console.WriteLine("");
                }
                Console.Write("Desea volver al menu principal(yes/no): ");
                res = Console.ReadLine();
            } while (res != "yes");
        }

        public void agregarNumTel()
        {
            string res = "";
            string telefono = "";
            int n = 0;
            do
            {               
                Console.Clear();
                Console.Write("¿A que paciente desea agregar telefonos? ");
                res = Console.ReadLine();
                int.TryParse(res, out n);
                    if (n>=1 && n<=pacientes.Length)
                    {
                        Console.Write("\nEscriba el numero a añadir: ");
                        telefono = Console.ReadLine();
                        pacientes[n - 1].Telefonos.Add(telefono);
                    }
                    else
                    {
                        Console.Write("\nNo se encontro el paciente ingresado, por favor intente de nuevo");
                    }
                telefono = "";
                n = 0;
                res = "";
                Console.Write("\nPara salir escriba 'exit': ");
                res = Console.ReadLine();
            } while (res != "exit");          
        }
    }

    class Paciente
    {
        public int Id;
        public string Nombre;
        public string ApellidoPaterno;
        public string ApellidoMaterno;
        public List<string> Telefonos = new List<string>();

        public string nombreCompleto()
        {
            return Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno;
        }
        public Paciente(int id, string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            Id = id;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
        }
    }
}
