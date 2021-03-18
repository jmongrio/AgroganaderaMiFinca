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
    public partial class PantallaRegistrarFinca : Form
    {
        public PantallaRegistrarFinca()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void txtNumeroFinca_TextChanged(object sender, EventArgs e)
        {
            comprobarNumeros(txtNumeroFinca);
        }

        private void PantallaRegistrarFinca_Load(object sender, EventArgs e)
        {
            btnRegistrarFinca.Enabled = false;
            txtTelefono.Mask = "0000-0000";
        }

        private void txtTamanoFinca_TextChanged(object sender, EventArgs e)
        {
            comprobarNumeros(txtTamanoFinca);
        }

        private void txtTelefono_TextAlignChanged(object sender, EventArgs e)
        {
            comprobarNumeros(txtTelefono);
        }

        private void txtNombreFinca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            comprobarEspaciosVacios(txtNombreFinca);
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            comprobarEspaciosVacios(txtDireccionFinca);
        }

        /*
        * Se valida si el usuario esta ingresando unicamente números.         
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

        /*
        * Se valida si el usuario esta dejando espacios vacios.         
        */
        void comprobarEspaciosVacios(MaskedTextBox nombre)
        {
            if (nombre.Text.Trim() != string.Empty)
            {
                btnRegistrarFinca.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }
            else
            {
                errorProvider1.SetError(nombre, "Debe introducir algún dato.");

                btnRegistrarFinca.Enabled = false;
                nombre.Focus();
            }
        }
        //Programar botón
    }
}
