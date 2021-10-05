using System;
using System.Collections.Generic;

namespace Ejemplos
{
    /// <summary>
    /// Añadir las estructuras de clases necesarias para permitir crear 
    /// solicitudes de estudios de laboratorio a pacientes.
    /// </summary>
    class Ejercicio19 : IEjercicio
    {
        Grupo[] grupos = new Grupo[5];
        Paciente[] pacientes = new Paciente[4];
        List<Solicitud> Solicituds = new List<Solicitud>();

        public Ejercicio19()
        {
            grupos[0] = new Grupo(1, "Bioquimica");
            grupos[1] = new Grupo(2, "Hematología y coagulación");
            grupos[2] = new Grupo(3, "Serología e inmunología");
            grupos[3] = new Grupo(4, "Pruebas especiales");

            grupos[0].Estudios.Add(new Estudio(1, "Glucosa", grupos[0]));
            grupos[0].Estudios.Add(new Estudio(2, "Urea", grupos[0]));
            grupos[0].Estudios.Add(new Estudio(3, "Creatinina", grupos[0]));
            grupos[0].Estudios.Add(new Estudio(4, "Trigliceridos", grupos[0]));
            grupos[0].Estudios.Add(new Estudio(5, "Ácido urico", grupos[0]));

            grupos[1].Estudios.Add(new Estudio(1, "Biometría hematica completa", grupos[1]));
            grupos[1].Estudios.Add(new Estudio(2, "Plaquetas", grupos[1]));
            grupos[1].Estudios.Add(new Estudio(3, "Grupo sanguineo y factor Rh", grupos[1]));

            grupos[2].Estudios.Add(new Estudio(1, "Reacciones febriles", grupos[2]));
            grupos[2].Estudios.Add(new Estudio(2, "Proteina C", grupos[2]));
            grupos[2].Estudios.Add(new Estudio(3, "Ag y AcS anti-dengue", grupos[2]));

            grupos[3].Estudios.Add(new Estudio(1, "Procalcitonina", grupos[3]));
            grupos[3].Estudios.Add(new Estudio(2, "Examen citologico", grupos[3]));
            grupos[3].Estudios.Add(new Estudio(3, "Testosterona", grupos[3]));
            grupos[3].Estudios.Add(new Estudio(4, "Estradiol", grupos[3]));

            pacientes[0] = new Paciente(1, "Guadalupe", "Medina", "Molina");
            pacientes[1] = new Paciente(2, "Efrain", "Castillo", "Meza");
            pacientes[2] = new Paciente(3, "Araceli", "Perez", "Martínez");
            pacientes[3] = new Paciente(4, "José", "Rios", "Cota");
        }

        public void Ejecutar()
        {
            string aux = "";
            do
            {
                Console.Clear();
                Console.Write("Menu de pacientes\n1.-Solicitar Estudios\n2.-Estatus de un estudio\n3.-Listado de pacientes\nexit.- Salir\nR: ");
                aux = Console.ReadLine();
                if (aux == "1")
                {
                    Console.Clear();
                    solicitudes();
                }
                else if (aux == "2")
                {
                    do
                    {
                        Console.Clear();
                        foreach (Solicitud s in Solicituds)
                        {
                            Console.WriteLine(s.ToString());
                            foreach (Estudio e in s.Estudios)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }
                        Console.Write("Para salir escriba 'back': ");
                        aux = Console.ReadLine();
                    } while (aux != "back");                  
                }
                else if (aux == "3")
                {
                    do
                    {
                        Console.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write(pacientes[i].Id + ".-" + " ");
                            Console.Write(pacientes[i].Nombre + " ");
                            Console.Write(pacientes[i].ApellidoPaterno + " ");
                            Console.WriteLine(pacientes[i].ApellidoMaterno + " ");
                        }
                        Console.Write("Para salir escriba 'back': ");
                        aux = Console.ReadLine();
                    } while (aux != "back");
                }
            } while (aux != "exit");
        }

        private void solicitudes()
        {
            string respuesta, x;
            int n = 0, flag = 0;
            do
            {
                respuesta = "";
                Console.Clear();
                Console.WriteLine("Solicitud de estudios");
                do
                {
                    Console.Write("Ingrese el Id del paciente: ");
                    respuesta = Console.ReadLine();
                } while (!int.TryParse(respuesta, out n));
                var pacienteASolicitar = pacientes[n - 1];

                respuesta = "";
                Console.Clear();
                Console.WriteLine("Paciente: " + pacientes[n - 1].Id + ".-" + " " + pacientes[n - 1].Nombre + " " + pacientes[n - 1].ApellidoPaterno + " " + pacientes[n - 1].ApellidoMaterno + " ");
                Console.Write("Ingrese el tipo de estudio que desea solicitar\n1.-Bioquímica\n2.-Hematología y coagulación\n3.-Serología e Inmunología\n4.-Pruebas especiales\nR: ");

                respuesta = Console.ReadLine();
                int.TryParse(respuesta, out int aux);
                respuesta = "";
                Estudio estudioASolicitar;
                Console.Clear();
                switch (aux)
                {
                    case 1:
                        Console.Write("Pruebas Bioquímicas\n1.-Glucosa\n2.-Urea\n3.-Creatinina\n4.-Trigliceridos\n5.-Ácido Urido\n'Back' para regresar\nR: ");
                        break;
                    case 2:
                        Console.Write("Hematología y Coagulación\n1.-Biometría hematica completa\n2.-Plaquetas\n3.-Grupo sanguineo y factor rh\n'Back' para regresar\nR: ");
                        break;
                    case 3:
                        Console.Write("Serología e Inmunología\n1.-Reacciones febriles\n2.-Proteina C\n3.-Ag y AcS anti-dengue\n'Back' para regresar\nR: ");
                        break;
                    case 4:
                        Console.Write("Pruebas Especiales\n1.-Procalcitonina\n2.-Examen Citológico\n3.-Testosterona\n4.-Estradiol\n'Back' para regresar\nR: ");
                        break;
                    default:
                        break;
                }
                x = Console.ReadLine();
                int.TryParse(x, out flag);
                Console.Clear();
                estudioASolicitar = grupos[aux - 1].Estudios[flag - 1];
                DateTime fecha = ingresarFecha();
                Solicituds.Add(new Solicitud(estudioASolicitar, pacienteASolicitar, fecha));
                Console.WriteLine("Deseas realizar mas solicitudes(yes/no): ");
                respuesta = Console.ReadLine();
            } while (respuesta != "no");
        }
        public DateTime ingresarFecha()
        {
            int anio = 0, mes = 0, dia = 0;
            int n;
            string input;
            do
            {
                Console.Write("Ingrese el año: ");
                input = Console.ReadLine();
                int.TryParse(input, out n);
                validarAnio(n);
                anio = n;
            } while (!validarAnio(n));
            mes = validarMes();
            dia = validarDia(mes);
            DateTime fecha = new DateTime(anio, mes, dia);
            Console.WriteLine("Solicitud de estudio realizada con exito para el dia : " + fecha.ToString("dd/MM/yyyy"));
            return fecha;
        }
        private bool validarAnio(int n)
        {
            DateTime fechaActual = DateTime.Now;
            if (n < fechaActual.Year)
            {
                Console.WriteLine("El año ingresado es incorrecto, porfavor intente de nuevo");
                return false;
            }
            return true;
        }
        private int validarMes()
        {
            int n;
            string input;
            bool flag;
            do
            {
                Console.Write("Ingrese el mes: ");
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
        private int validarDia(int mes)
        {
            int n;
            string input;
            bool flag;
            do
            {
                Console.Write("Ingrese el dia: ");
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

        class Estudio
        {
            public int Id;
            public string Descripcion;
            public Grupo Grupo;

            public Estudio(int id, string descripcion, Grupo grupo)
            {
                Id = id;
                Descripcion = descripcion;
                Grupo = grupo;
            }

            public override string ToString()
            {
                return Id + ".- " + Descripcion;
            }
        }

        class Grupo
        {
            public int Id;
            public string Descripcion;
            public List<Estudio> Estudios = new List<Estudio>();

            public Grupo(int id, string descripcion)
            {
                Id = id;
                Descripcion = descripcion;
            }
        }

        class Solicitud
        {
            public List<Estudio> Estudios = new List<Estudio>();
            public Paciente Paciente;
            public DateTime Fecha;

            public Solicitud(Estudio Estudios, Paciente Paciente, DateTime fecha)
            {
                Fecha = fecha;
                this.Paciente = Paciente;
                this.Estudios.Add(Estudios);
            }

            public override string ToString()
            {
                return Fecha.ToString("dd/MM/yyyy hh:mm")+" "+ Paciente.nombreCompleto();
            }
        }
    }
}
