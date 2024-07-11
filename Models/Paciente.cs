using System;

namespace TurnoMedico.Models
{
    public class Paciente : Persona
    {
        public int NumHistClinica { get; private set; }
        public DateTime FechaAlta { get; private set; }

        public Paciente(string nombre, string apellido, string num_doc, int hist_clinica)
            : base(nombre, apellido, num_doc)
        {
            NumHistClinica = hist_clinica;
            FechaAlta = DateTime.Now;
        }
    }
}
