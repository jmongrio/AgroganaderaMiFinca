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
            comprobarNumeros(txtIdentificacionDueno);
        }

        /*
         * Realiza la verificación de las entradas númericas
         */
        void comprobarNumeros(MaskedTextBox nombre)
        {
            if (nombre.Text.Trim() != string.Empty && nombre.Text.All(Char.IsDigit))
            {
                btnRegistrarFinca.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }
            else
            {
                if (!(nombre.Text.All(Char.IsDigit)))
                {
                    errorProvider1.SetError(nombre, "Este espacio sólo debe contener números.");
                }
                else
                {
                    errorProvider1.SetError(nombre, "Debe introducir algún dato.");
                }
                btnRegistrarFinca.Enabled = false;
                nombre.Focus();
            }
        }
    }
}
