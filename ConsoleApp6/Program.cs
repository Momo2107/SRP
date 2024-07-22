using System;

namespace ConsoleApp6
{   
    public class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Ramon", 23, "San Vicente", "RamonJunior@gmail.com");

            EnviarCorreo enviar = new EnviarCorreo("Estoy programando", "Martin");

            ImprimirDatos datos = new ImprimirDatos(persona, enviar);
            datos.Imprimir();
            Console.ReadKey();
        }
    }
}

