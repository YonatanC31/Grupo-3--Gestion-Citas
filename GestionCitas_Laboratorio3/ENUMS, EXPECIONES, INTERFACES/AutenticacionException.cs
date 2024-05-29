using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas_Laboratorio3.Backend
{
    public class AutenticacionException : Exception
    {
        public AutenticacionException(string mensaje) : base(mensaje)
        {
        }
    }
}