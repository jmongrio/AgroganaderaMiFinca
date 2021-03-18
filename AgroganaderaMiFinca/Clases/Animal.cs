using System;
using System.Collections.Generic;
using System.Text;

namespace AgroganaderaMiFinca
{
    class Animal
    {
        private int identificacion;
        private string nombre;
        private int finca;
        private int raza;
        private string fechaNacimiento;
        private int sexo;
        private string madre;
        private string padre;

        public Animal()
        {
            
        }

        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Finca { get => finca; set => finca = value; }
        public int Raza { get => raza; set => raza = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Sexo { get => sexo; set => sexo = value; }
        public string Madre { get => madre; set => madre = value; }
        public string Padre { get => padre; set => padre = value; }        
    }
}
