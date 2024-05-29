using GestionCitas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas_Laboratorio3.Backend
{
    public class Login : ILogin
    {
        private readonly List<Usuario> _usuarios;

        public Login(List<Usuario> usuarios)
        {
            _usuarios = usuarios;
        }

        public Usuario Autenticar(string correo, string contraseña)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.Correo == correo && u.Contraseña == contraseña);
            if (usuario == null)
            {
                throw new AuthenticationException("Correo o contraseña incorrectos.");
            }
            return usuario;
        }
    }
}
