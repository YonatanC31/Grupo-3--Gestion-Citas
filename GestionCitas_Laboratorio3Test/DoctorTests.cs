using Xunit;
using GestionCitas_Laboratorio3.Backend;
using System;

public class DoctorTests
{
    [Fact]
    public void VerHistorialPacienteMuestraHistorialDelPaciente()
    {
        
        var doctor = new Doctor("doctor1@example.com", "docpass1", "Dr. Smith");
        var paciente = new Paciente("patient1@example.com", "patientpass1", "Alice");
        var cita = new Cita(paciente, doctor, new DateTime(2024, 6, 1), "Revisión anual");
        paciente.HistorialMedico.Add(cita);

        
        doctor.VerHistorialPaciente(paciente);

    }
}
