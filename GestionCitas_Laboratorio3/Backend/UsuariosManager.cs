using GestionCitas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas_Laboratorio3.Backend
{
    public class UsuariosManager
    {
        public List<Usuario> MenuUsuarios()
        {
            var doctor1 = new Doctor("doctor", "doctor", "Dr. Amaya");
            var doctor2 = new Doctor("doctor2", "doctor2", "Dr. Garcia");

            var paciente1 = new Paciente("Jennifer@gmail.com", "1234", "Jennifer");
            var paciente2 = new Paciente("Oscar@gmail.com", "5678", "Oscar");

            var cita1 = new Cita(paciente1, doctor1, new DateTime(2024, 5, 30, 10, 0, 0), "Revisión general");
            var cita2 = new Cita(paciente2, doctor1, new DateTime(2024, 6, 1, 11, 0, 0), "Consulta de seguimiento");
            var cita3 = new Cita(paciente1, doctor2, new DateTime(2024, 6, 2, 9, 0, 0), "Chequeo anual");

            doctor1.Citas.Add(cita1);
            doctor1.Citas.Add(cita2);
            doctor2.Citas.Add(cita3);

            paciente1.HistorialMedico.Add(cita1);
            paciente1.HistorialMedico.Add(cita3);
            paciente2.HistorialMedico.Add(cita2);

            var usuarios = new List<Usuario>
            {
                new Administrador("admin", "admin", "Administrador 1"),
                new Administrador("admin2", "admin2", "Administrador 2"),
                doctor1,
                doctor2,
                paciente1,
                paciente2
            };

            return usuarios;
        }
    }
}