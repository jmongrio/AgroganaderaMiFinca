using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroganaderaMiFinca
{
    public partial class PantallaRegistrarDueno : Form
    {
        Validaciones v = new Validaciones();

        public PantallaRegistrarDueno()
        {
            InitializeComponent();
        }

        private void txtDireccionFinca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdentificacionDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtIdentificacionDueno, btnRegistrarDueno, errorProvider1);
        }

        private void txtNombreDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtIdentificacionDueno, btnRegistrarDueno, errorProvider1);
        }

        private void txtPrimerApellidoDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtPrimerApellidoDueno, btnRegistrarDueno, errorProvider1);
        }

        private void txtSegundoApellidoDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtSegundoApellidoDueno, btnRegistrarDueno, errorProvider1);
        }

        private void txtCorreoElectronicoDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtCorreoElectronicoDueno, btnRegistrarDueno, errorProvider1);
        }

        private void txtNumeroCelularDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtNumeroCelularDueno, btnRegistrarDueno, errorProvider1);
        }
        //Programar finca
        //Programar boton Registrar

    }//Fin PantallaRegistrarDueno
}
