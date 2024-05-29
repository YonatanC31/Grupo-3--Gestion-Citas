using GestionCitas;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas_Laboratorio3.Backend
{
    
    public class Cita
    {
        public Paciente Paciente { get; private set; }
        public Doctor Doctor { get; private set; }
        public DateTime Fecha { get; private set; }
        public string Notas { get; private set; }

        public Cita(Paciente paciente, Doctor doctor, DateTime fecha, string notas)
        {
            Paciente = paciente;
            Doctor = doctor;
            Fecha = fecha;
            Notas = notas;
        }
    }
}
