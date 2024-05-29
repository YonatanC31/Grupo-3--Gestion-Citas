using System;
using Xunit;
using GestionCitas;
using GestionCitas_Laboratorio3.Backend;

public class CitaTests
{
    [Fact]
    public void CrearCita_PropiedadesAsignadasCorrectamente()
    {
        
        var doctor = new Doctor("doctor1@example.com", "docpass1", "Dr. Smith");
        var paciente = new Paciente("patient1@example.com", "patientpass1", "Alice");
        var fecha = new DateTime(2024, 6, 1);
        var notas = "Revisión anual";

        
        var cita = new Cita(paciente, doctor, fecha, notas);

        Assert.Equal(paciente, cita.Paciente);
        Assert.Equal(doctor, cita.Doctor);
        Assert.Equal(fecha, cita.Fecha);
        Assert.Equal(notas, cita.Notas);
    }
}
