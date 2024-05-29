using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas_Laboratorio3.IU
{
    public interface IUsuario
    {
        string NombreCompleto { get; }
        string Correo { get; }
        string Contraseña { get; }
        void MostrarInformacion();
    }
}
