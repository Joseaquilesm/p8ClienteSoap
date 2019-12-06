using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using soapClient.wsAcademico;

namespace soapClient
{
    class Program
    {
        static void Main(string[] args)
        {
           
            wsAcademico.AcademicoWebServiceClient client = new wsAcademico.AcademicoWebServiceClient();
            mainMenu(client);
          

        }

        private static void consultTeacher(wsAcademico.AcademicoWebServiceClient client)
        {
            String profesor = "";
            Console.WriteLine("Ingrese el profesor:");
            profesor = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("--Profesor--\nNombre:"+ client.getProfesor(profesor).nombre  + "     Cédula:" + client.getProfesor(profesor).cedula);
            againOrExit(client);
        }

        private static void printStudents(wsAcademico.AcademicoWebServiceClient client)
        {
            for (int i = 0; i < client.getAllEstudiante().Length; i++)
            {
                Console.WriteLine("Nombre: " + 
                    client.getAllEstudiante().ElementAt(i).nombre + 
                    "    Matricula: " +
                    client.getAllEstudiante().ElementAt(i).matricula);
    
            }
            againOrExit(client);
        }

        private static void againOrExit(wsAcademico.AcademicoWebServiceClient client)
        {
            String opcion = "";
            Console.WriteLine("\nDesea volver al menu?: (Si)/(No)");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "Si":
                    mainMenu(client);
                    break;
                case "No":
                    Environment.Exit(0);
                    break;
                case "si":
                    mainMenu(client);
                    break;
                case "no":
                    Environment.Exit(0);
                    break;
                case "s":
                    mainMenu(client);
                    break;
                case "n":
                    Environment.Exit(0);
                    break;

            }
        }

        static void mainMenu(wsAcademico.AcademicoWebServiceClient client)
        {
            String opcion = "";
            Console.Clear();
            Console.WriteLine("Menu:" +
                "\n 1-Listar Estudiantes." +
                "\n 2-Consultar asignatura." +
                "\n 3-Consultar profesor.");
            Console.WriteLine("\nElija: ");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    printStudents(client);
                    break;
                case "2":
                    consultCourse(client);
                    break;
                case "3":
                     consultTeacher(client);
                    break;

            }
        }

        private static void consultCourse(AcademicoWebServiceClient client)
        {
            /* Stuff to imprimir:
              Id:
              clave:
              nombre:
              grupo:
              cantidad estudiantes:
              profesor:
             */
            String asignatura = "";
            Console.WriteLine("Ingrese la asignatura:");
            asignatura = Console.ReadLine();
            Console.Clear();
            //ID
            Console.WriteLine("--Asignatura--\nId:" + client.getAsignatura(Convert.ToInt32(asignatura)).id);
            //Clave
            Console.WriteLine("\nClave:" + client.getAsignatura(Convert.ToInt32(asignatura)).clave);
            //Nombre
            Console.WriteLine("\nNombre:" + client.getAsignatura(Convert.ToInt32(asignatura)).nombre);
            //Grupo
            Console.WriteLine("\nGrupo:" + client.getAsignatura(Convert.ToInt32(asignatura)).grupo);
            //Cant Estudiantes
            Console.WriteLine("\nCantidad Estudiantes:" + client.getAsignatura(Convert.ToInt32(asignatura)).estudiantes.Length);
            //Profesor
            Console.WriteLine("\nProfesor:" + client.getAsignatura(Convert.ToInt32(asignatura)).profesor.nombre);
            againOrExit(client);
        }
    }
}
