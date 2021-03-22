using System;

namespace AgroganaderaMiFinca
{
    public class Empleado : Persona
    {
        private double salario;
        public Empleado(int identificacion, string nombre, string primerAppellido, string segundoApellido, double salario) 
            : base(identificacion, nombre, primerAppellido, segundoApellido)
        {
            Salario = salario;
        } // Constructor

        public Empleado() { } //Constructor

        public double Salario { get => salario; set => salario = value; }
    }
}
