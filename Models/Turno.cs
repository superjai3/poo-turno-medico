using System;

namespace TurnoMedico.Models
{
    public class Turno
    {
        public DateTime Dia { get; private set; }
        public Medico Medico { get; private set; }
        public Paciente Paciente { get; private set; }
        public Secretaria UsuarioCarga { get; private set; }

        public Turno(DateTime dia, Medico medico, Paciente paciente, Secretaria usuarioCarga)
        {
            Dia = dia;
            Medico = medico;
            Paciente = paciente;
            UsuarioCarga = usuarioCarga;
        }

        public void ImprimirTurno()
        {
            Console.WriteLine($"Paciente: {Paciente.GetNombreCompleto()}");
            Console.WriteLine($"Médico: {Medico.GetNombreCompleto()} - Especialidad: {Medico.GetEspecialidad()}");
            Console.WriteLine($"Secretaria: {UsuarioCarga.GetNombreCompleto()}");
            Console.WriteLine($"Fecha del Turno: {Dia.ToShortDateString()}");
        }
    }
}
