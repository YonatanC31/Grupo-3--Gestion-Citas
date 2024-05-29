using GestionCitas;
using GestionCitas_Laboratorio3.IU;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas_Laboratorio3.Backend
{
    public class Doctor : Usuario
    {
        public List<Cita> Citas { get; private set; } = new List<Cita>();

        public Doctor(string correo, string contraseña, string nombreCompleto)
            : base(correo, contraseña, nombreCompleto)
        { }

        public void VerCitas()
        {
            var table = new Table();
            table.AddColumn("Paciente");
            table.AddColumn("Fecha");
            table.AddColumn("Notas");

            foreach (var cita in Citas)
            {
                table.AddRow(cita.Paciente.NombreCompleto, cita.Fecha.ToString("g"), cita.Notas);
            }

            AnsiConsole.Write(table);
        }

        public void VerHistorialPaciente(Paciente paciente)
        {
            var table = new Table();
            table.AddColumn("Fecha");
            table.AddColumn("Notas");

            foreach (var cita in paciente.HistorialMedico)
            {
                table.AddRow(cita.Fecha.ToString("g"), cita.Notas);
            }

            AnsiConsole.MarkupLine($"[bold yellow]Historial de {paciente.NombreCompleto}:[/]");
            AnsiConsole.Write(table);
        }
    }
}
