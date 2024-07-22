using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string dirrecion;
        public string correoElectronico;

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dirrecion = direccion;
            this.correoElectronico = correoElectronico;
        }
    }
}
