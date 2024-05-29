using GestionCitas;
using GestionCitas_Laboratorio3.IU;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas_Laboratorio3.Backend
{
    public class Administrador : Usuario
    {
        public Administrador(string correo, string contraseña, string nombreCompleto) : base(correo, contraseña, nombreCompleto) { }

        public static void ShowAdministratorMenu(List<Doctor> doctores, List<Paciente> pacientes, List<Usuario> usuarios, Login login)
        {
            bool salir = false;
            while (!salir)
            {
                var opciones = new[] { "Ver listado de doctores", "Ver listado de pacientes", "Mostrar historial médico", "Salir" };
                var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("[bold cyan]Menú del Administrador[/]")
                        .AddChoices(opciones)
                );

                switch (choice)
                {
                    case "Ver listado de doctores":
                        ShowDoctors(doctores);
                        break;
                    case "Ver listado de pacientes":
                        ShowPatients(pacientes);
                        break;
                    case "Mostrar historial médico":
                        MostrarHistorialMedico(pacientes);
                        break;
                    case "Salir":
                        salir = true;
                        break;
                    default:
                        AnsiConsole.MarkupLine("[red]Opción no válida.[/]");
                        break;
                }
            }
        }

        public static void MostrarHistorialMedico(List<Paciente> pacientes)
        {
            AnsiConsole.MarkupLine("[bold yellow]Historial Médico de Pacientes:[/]");

            foreach (var paciente in pacientes)
            {
                AnsiConsole.MarkupLine($"[bold yellow]Paciente: {paciente.NombreCompleto}[/]");
                paciente.VerHistorial();
                AnsiConsole.WriteLine();
            }
        }

        public static void ShowDoctors(List<Doctor> doctores)
        {
            AnsiConsole.MarkupLine("[bold yellow]Listado de Doctores:[/]");

            var table = new Table();
            table.AddColumn("[bold yellow]Nombre[/]");
            table.AddColumn("[bold yellow]Correo[/]");
            table.AddColumn("[bold yellow]Contraseña[/]");

            foreach (var doctor in doctores)
            {
                table.AddRow(doctor.NombreCompleto, doctor.Correo, doctor.Contraseña);
            }

            AnsiConsole.Write(table);
        }

        public static void ShowPatients(List<Paciente> pacientes)
        {
            AnsiConsole.MarkupLine("[bold yellow]Listado de Pacientes:[/]");

            var table = new Table();
            table.AddColumn("[bold yellow]Nombre[/]");
            table.AddColumn("[bold yellow]Correo[/]");
            table.AddColumn("[bold yellow]Contraseña[/]");

            foreach (var paciente in pacientes)
            {
                table.AddRow(paciente.NombreCompleto, paciente.Correo, paciente.Contraseña);
            }

            AnsiConsole.Write(table);
        }
    }
}