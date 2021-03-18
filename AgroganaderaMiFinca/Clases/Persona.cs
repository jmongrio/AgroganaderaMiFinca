using System;
using System.Collections.Generic;
using System.Text;

namespace AgroganaderaMiFinca
{
    public class Persona
    {
        private int identificacion;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;

        public Persona(int identificacion, string nombre, string primerApellido, string segundoApellido)
        { } //constructor

        public Persona() { }

        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
    }
}
