using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class EnviarCorreo
    {
        public string message;
        public string receptor;

        public EnviarCorreo(string message, string receptor)
        {
            this.message = message;
            this.receptor = receptor;
        }
    }
}
