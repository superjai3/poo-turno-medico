using System;
using TurnoMedico.Models;

namespace TurnoMedico
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente("Lorenza", "Heiz", "28111523", 2502);
            paciente.FechaNacimiento = new DateTime(1982, 5, 20);
            paciente.SetDireccion("San Martín 152", "Carlos Paz");

            Medico medico = new Medico("Ramiro", "Ballares", "30154225", 955);
            medico.FechaNacimiento = new DateTime(1991, 1, 15);
            medico.SetDireccion("Sarmiento 1200", "Carlos Paz");
            medico.SetEspecialidad("Médico Clínico");

            Secretaria secretaria = new Secretaria("Sofía", "Prida", "37115204", "Monotributista", 20371152049, new DateTime(2018, 1, 1));
            secretaria.FechaNacimiento = new DateTime(1998, 7, 7);
            secretaria.SetDireccion("Palmares 5200", "Carlos Paz");

            DateTime fechaTurno = DateTime.Now;

            Turno turno = new Turno(fechaTurno, medico, paciente, secretaria);

            turno.ImprimirTurno();
        }
    }
}
