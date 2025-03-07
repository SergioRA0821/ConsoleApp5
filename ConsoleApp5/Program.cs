using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //Sergio Reyes Alfaro
    internal class Program
    {
        public enum Menu
        {
            AgregarETurnoM = 1, AgregarETurnoV, ContarETurnoMV, PromedioEdadesMV, SalarioTotalMV, MostrarEMV, Salir
        }
        static void Main(string[] args)
        {
            Acciones acc = new Acciones();
            while (true)
            {
                switch (menu())
                {
                    case Menu.AgregarETurnoM:
                        acc.AgregarTM();
                        break;
                    case Menu.AgregarETurnoV:
                        acc.AgregarTV();
                        break;
                    case Menu.ContarETurnoMV:
                        acc.ContarEmpleados();
                        break;
                    case Menu.PromedioEdadesMV:
                        acc.PromedioEdades();
                        break;
                    case Menu.SalarioTotalMV:
                        acc.SumaSalarios();
                        break;
                    case Menu.MostrarEMV:
                        acc.MostrarEmpleados();
                        break;
                    case Menu.Salir:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Número inválido");
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("Escoge la opción que deseas realizar:");
            Console.WriteLine("1) Agregar Empleados turno Matutino");
            Console.WriteLine("2) Agregar Empleados turno Vespertino");
            Console.WriteLine("3) Contar empleados turno M y V");
            Console.WriteLine("4) Promedio edades de turno M y V");
            Console.WriteLine("5) Salario total de turno M y V");
            Console.WriteLine("6) Mostrar trabajadores de turno M y V");
            Console.WriteLine("7) Salir");

            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
