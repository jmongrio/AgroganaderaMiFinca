using System;
using System.Collections.Generic;
using System.Text;

namespace AgroganaderaMiFinca
{
    class RazaAnimal
    {
        private int codigoRaza;
        private string descrpcionRaza;

        public RazaAnimal(int codigoRaza, string descrpcionRaza)
        {
            CodigoRaza = codigoRaza;
            DescrpcionRaza = descrpcionRaza;
        }// Constructor

        public RazaAnimal() { } // Constructor

        public int CodigoRaza { get => codigoRaza; set => codigoRaza = value; }
        public string DescrpcionRaza { get => descrpcionRaza; set => descrpcionRaza = value; }
    }
}
