using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class ImprimirDatos
    {
        private Persona _persona;
        private EnviarCorreo _enviarCorreo;

        public ImprimirDatos(Persona persona, EnviarCorreo enviarCorreo)
        {
            _persona = persona;
            _enviarCorreo = enviarCorreo;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {_persona.nombre}");
            Console.WriteLine($"Edad: {_persona.edad}");
            Console.WriteLine($"Dirección: {_persona.dirrecion}");
            Console.WriteLine($"Correo Electronico: {_persona.correoElectronico}\n");
            Console.WriteLine($"Receptor: {_enviarCorreo.receptor}");
            Console.WriteLine($"mensaje: {_enviarCorreo.message}");

        }
    }
}
