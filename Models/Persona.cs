using System;

namespace TurnoMedico.Models
{

    //CLASE
    public class Persona
    {

        //ATRIBUTOS (Propiedades)
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string TipoDoc { get; set; }
        public string NumDoc { get; private set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }



        //CONSTRUCTOR
        public Persona(string nombre, string apellido, string num_doc)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumDoc = num_doc;
        }



        //MÉTODOS
        public string GetNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public void SetDireccion(string direccion, string localidad)
        {
            Direccion = direccion;
            Localidad = localidad;
        }
    }
}
