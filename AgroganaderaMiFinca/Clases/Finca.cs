using System;
using System.Collections.Generic;
using System.Text;

namespace Cliente
{
    public class Finca
    {
        private int numeroFinca;
        private string nombreFinca;
        private double tamanoFinca;
        private string direccionFinca;
        private int telefono;

        public Finca()
        {
                
        }
        public int NumeroFinca { get => numeroFinca; set => numeroFinca = value; }
        public string NombreFinca { get => nombreFinca; set => nombreFinca = value; }
        public double TamanoFinca { get => tamanoFinca; set => tamanoFinca = value; }
        public string DireccionFinca { get => direccionFinca; set => direccionFinca = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
