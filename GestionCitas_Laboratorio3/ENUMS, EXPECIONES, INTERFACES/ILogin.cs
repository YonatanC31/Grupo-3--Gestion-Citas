using GestionCitas;

namespace GestionCitas_Laboratorio3.Backend
{
    public interface ILogin
    {
        Usuario Autenticar(string correo, string contraseña);
    }
}