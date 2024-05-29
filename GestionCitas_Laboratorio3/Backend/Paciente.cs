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
    public class Paciente : Usuario
    {
        public List<Cita> HistorialMedico { get; private set; } = new List<Cita>();

        public Paciente(string correo, string contraseña, string nombreCompleto)
            : base(correo, contraseña, nombreCompleto)
        { }

        public void VerHistorial()
        {
            var table = new Table();
            table.AddColumn("Fecha");
            table.AddColumn("Notas");

            foreach (var cita in HistorialMedico)
            {
                table.AddRow(cita.Fecha.ToString("g"), cita.Notas);
            }

            AnsiConsole.MarkupLine("[bold yellow]Historial Médico:[/]");
            AnsiConsole.Write(table);
        }

        public void AsignarCita(Doctor doctor, DateTime fecha, string notas)
        {
            var cita = new Cita(this, doctor, fecha, notas);
            doctor.Citas.Add(cita);
            HistorialMedico.Add(cita);
            AnsiConsole.MarkupLine("[bold green]Cita asignada correctamente.[/]");
        }
    }
}