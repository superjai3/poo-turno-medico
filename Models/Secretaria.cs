using System;

namespace TurnoMedico.Models
{
    public class Secretaria : Persona
    {
        public string TipoIVA { get; private set; }
        public long CUIT { get; private set; }
        public DateTime FechaIngreso { get; private set; }

        public Secretaria(string nombre, string apellido, string num_doc, string tipo_iva, long cuit, DateTime fecha_ing)
            : base(nombre, apellido, num_doc)
        {
            TipoIVA = tipo_iva;
            CUIT = cuit;
            FechaIngreso = fecha_ing;
        }

        public int ObtenerAntiguedad()
        {
            return DateTime.Now.Year - FechaIngreso.Year;
        }
    }
}
