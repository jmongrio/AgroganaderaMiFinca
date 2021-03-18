using System;
using System.Collections.Generic;
using System.Text;

namespace AgroganaderaMiFinca
{
    class Dueno : Persona
    {
        string correoElectronico;
        int numeroCelular;
        int finca;


        public Dueno(int identificacion, string nombre, string primerApellido, string segundoApellido, string correoElectronico, int numeroCelular, int finca) 
            : base(identificacion, nombre, primerApellido, segundoApellido)
        {
            CorreoElectronico = correoElectronico;
            NumeroCelular = numeroCelular;
            Finca = finca;
        } //Constructor

        public Dueno() { } //Constructor

        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public int NumeroCelular { get => numeroCelular; set => numeroCelular = value; }
        public int Finca { get => finca; set => finca = value; }
    }
}
