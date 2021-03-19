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
    public partial class PantallaRegistrarEmpleado : Form
    {
        Validaciones v = new Validaciones();

        public PantallaRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void txtIdentificacionEmpleado_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtIdentificacionEmpleado, btnRegistrarEmpleado, errorProvider1);
        }

        private void txtSalarioEmpleado_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtSalarioEmpleado, btnRegistrarEmpleado, errorProvider1);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
