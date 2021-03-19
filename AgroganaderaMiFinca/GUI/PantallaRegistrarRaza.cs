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
    public partial class PantallaRegistrarRaza : Form
    {
        Validaciones v = new Validaciones();

        public PantallaRegistrarRaza()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoRaza_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtCodigoRaza, btnRegistrarRaza, errorProvider1);
        }

        private void txtDescripcionRaza_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtDescripcionRaza, btnRegistrarRaza, errorProvider1);            
        }
        private void pnlRegistroRaza_MouseLeave(object sender, EventArgs e)
        {
            activarBoton();
        }

        //Controlador de espacios vacios.
        public void activarBoton()
        {
            if ((txtCodigoRaza.Text.Trim() != string.Empty) && (txtDescripcionRaza.Text.Trim() != string.Empty))
            {
                errorProvider1.SetError(pnlRegistroRaza, "");
                btnRegistrarRaza.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(pnlRegistroRaza, "Hay algún espacio sin llenar!.");
                btnRegistrarRaza.Enabled = false;
            }
        }


    }
}
