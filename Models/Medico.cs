using System;

namespace TurnoMedico.Models
{
    public class Medico : Persona
    {
        public int Matricula { get; private set; }
        public string Especialidad { get; private set; } = string.Empty;

        public Medico(string nombre, string apellido, string num_doc, int matricula)
            : base(nombre, apellido, num_doc)
        {
            Matricula = matricula;
        }

        public void SetEspecialidad(string especialidad)
        {
            Especialidad = especialidad;
        }

        public string GetEspecialidad()
        {
            return Especialidad;
        }
    }
}
