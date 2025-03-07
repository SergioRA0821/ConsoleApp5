using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Persona
    {
        public Persona(string nombre, int edad, string sexo, DateTime fechaNacimiento, double salario)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            FechaNacimiento = fechaNacimiento;
            Salario = salario;
        }
        public Persona() { }
        //comentario nuevo
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Salario { get; set; }
    }
}
