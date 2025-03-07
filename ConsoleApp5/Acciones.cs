using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //Sergio Reyes Alfaro
    internal class Acciones
    {
        Persona p = new Persona();
        Persona[] turnoM;
        Persona[] turnoV;

        public void AgregarTM()
        {
            Console.WriteLine("Cuantos empleados vas a agregar?");
            int numEM = Convert.ToInt32(Console.ReadLine());
            turnoM = new Persona[numEM];

            for (int i = 0; i < turnoM.Length; i++)
            {
                Console.WriteLine("Nombre");
                p.Nombre = Console.ReadLine();
                Console.WriteLine("Edad");
                p.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sexo");
                p.Sexo = Console.ReadLine();
                Console.WriteLine("Fecha de nacimiento");
                p.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Salario");
                p.Salario = Convert.ToDouble(Console.ReadLine());

                turnoM[i] = new Persona(p.Nombre, p.Edad, p.Sexo, p.FechaNacimiento, p.Salario);
            }
        }
        public void AgregarTV()
        {
            Console.WriteLine("Cuantos empleados vas a agregar?");
            int numEV = Convert.ToInt32(Console.ReadLine());
            turnoV = new Persona[numEV];

            for (int i = 0; i < turnoV.Length; i++)
            {
                Console.WriteLine("Nombre");
                p.Nombre = Console.ReadLine();
                Console.WriteLine("Edad");
                p.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sexo");
                p.Sexo = Console.ReadLine();
                Console.WriteLine("Fecha de nacimiento");
                p.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Salario");
                p.Salario = Convert.ToDouble(Console.ReadLine());

                turnoV[i] = new Persona(p.Nombre, p.Edad, p.Sexo, p.FechaNacimiento, p.Salario);
            }
        }
        public void ContarEmpleados()
        {
            Console.WriteLine($"La suma de los empleados del turno matutino y vespertino es: {turnoM.Length + turnoV.Length}");
        }
        public void PromedioEdades()
        {
            double sumaPromedioTM = 0;
            foreach (var p in turnoM)
            {
                sumaPromedioTM = sumaPromedioTM + p.Edad;
            }
            double sumaPromedioTV = 0;
            foreach (var p in turnoM)
            {
                sumaPromedioTV = sumaPromedioTV + p.Edad;
            }
            Console.WriteLine($"El promedio de edades de ambos turnos es: {(sumaPromedioTM + sumaPromedioTV)/(turnoM.Length + turnoV.Length)}");
        }
        public void SumaSalarios()
        {
            double sumaSalariosTM = 0;
            foreach (var p in turnoM)
            {
                sumaSalariosTM = sumaSalariosTM + p.Salario;
            }
            double sumaSalariosTV = 0;
            foreach (var p in turnoV)
            {
                sumaSalariosTV = sumaSalariosTV + p.Salario;
            }
            Console.WriteLine($"La suma de todos los salarios es: {sumaSalariosTM + sumaSalariosTV}");
        }
        public void MostrarEmpleados()
        {
            Console.WriteLine("Empleados turno Matutino:");
            foreach (var p in turnoM)
            {
                Console.WriteLine($"Nombre: {p.Nombre}");
                Console.WriteLine($"Edad: {p.Edad}");
                Console.WriteLine($"Sexo: {p.Sexo}");
                Console.WriteLine($"Fecha de nacimiento: {p.FechaNacimiento}");
                Console.WriteLine($"Salario: {p.Salario}");
            }
            Console.WriteLine("Empleados turno Vespertino:");
            foreach (var p in turnoV)
            {
                Console.WriteLine($"Nombre: {p.Nombre}");
                Console.WriteLine($"Edad: {p.Edad}");
                Console.WriteLine($"Sexo: {p.Sexo}");
                Console.WriteLine($"Fecha de nacimiento: {p.FechaNacimiento}");
                Console.WriteLine($"Salario: {p.Salario}");
            }
        }
    }
}
