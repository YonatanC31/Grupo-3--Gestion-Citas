using System;
using System.Collections.Generic;
using Xunit;
using GestionCitas;
using GestionCitas_Laboratorio3.Backend;

public class PacienteTests
{
    [Fact]
    public void AsignarCita_AgregaCitaAHistorialDelPacienteYDelDoctor()
    {
        var doctor = new Doctor("doctor1@example.com", "docpass1", "Dr. Smith");
        var paciente = new Paciente("patient1@example.com", "patientpass1", "Alice");
        paciente.AsignarCita(doctor, new DateTime(2024, 6, 1), "Revisión anual");
        Assert.Single(paciente.HistorialMedico);
        Assert.Single(doctor.Citas);
        Assert.Equal("Alice", doctor.Citas[0].Paciente.NombreCompleto);
    }
}
