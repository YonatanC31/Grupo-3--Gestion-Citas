using System;
using System.Collections.Generic;
using GestionCitas_Laboratorio3.Backend;
using GestionCitas_Laboratorio3.IU;
using Spectre.Console;

namespace GestionCitas
{
    public abstract class Usuario : IUsuario
    {
        public string NombreCompleto { get; private set; }
        public string Correo { get; private set; }
        public string Contraseña { get; private set; }

        protected Usuario(string correo, string contraseña, string nombreCompleto)
        {
            Correo = correo;
            Contraseña = contraseña;
            NombreCompleto = nombreCompleto;
        }

        public virtual void MostrarInformacion()
        {
            AnsiConsole.MarkupLine($"[green]Nombre:[/] {NombreCompleto}");
            AnsiConsole.MarkupLine($"[green]Correo:[/] {Correo}");
        }
    }
}
