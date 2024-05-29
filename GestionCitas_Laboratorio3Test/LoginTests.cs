using System;
using System.Collections.Generic;
using Xunit;
using GestionCitas;
using GestionCitas_Laboratorio3.Backend;
using System.Security.Authentication;

public class LoginTests
{
    [Fact]
    public void AutenticarCredencialesCorrectasRetornaUsuario()
    {
        var usuariosManager = new UsuariosManager();
        var usuarios = usuariosManager.MenuUsuarios();
        var login = new Login(usuarios);
        var usuario = login.Autenticar("admin", "admin");
        Assert.NotNull(usuario);
        Assert.IsType<Administrador>(usuario);
    }

    [Fact]
    public void AutenticarCredencialesIncorrectasLanzaAuthenticationException()
    {
        var usuariosManager = new UsuariosManager();
        var usuarios = usuariosManager.MenuUsuarios();
        var login = new Login(usuarios);
        var exception = Assert.Throws<AuthenticationException>(() => login.Autenticar("admin1@example.com", "wrongpassword"));
        Assert.Equal("Correo o contraseña incorrectos.", exception.Message);
    }
}
