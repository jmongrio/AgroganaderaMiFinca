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
        Validaciones v = new Validaciones();

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
            v.comprobarNumeros(txtNumeroFinca, btnRegistrarFinca, errorProvider1);
        }

        private void PantallaRegistrarFinca_Load(object sender, EventArgs e)
        {
            btnRegistrarFinca.Enabled = false;
            txtTelefono.Mask = "0000-0000";
        }

        private void txtTamanoFinca_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtTamanoFinca, btnRegistrarFinca, errorProvider1);
        }

        private void txtTelefono_TextAlignChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtTelefono, btnRegistrarFinca, errorProvider1);
        }

        private void txtNombreFinca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            v.comprobarEspaciosVacios(txtNombreFinca, btnRegistrarFinca, errorProvider1);
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            v.comprobarEspaciosVacios(txtDireccionFinca, btnRegistrarFinca, errorProvider1);
        }
        //Programar botón
    }
}
