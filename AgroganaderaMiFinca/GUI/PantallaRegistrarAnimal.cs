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
    public partial class PantallaRegistrarAnimal : Form
    {
        Validaciones v = new Validaciones();
        public PantallaRegistrarAnimal()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdentificacionAnimal_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtIdentificacionAnimal, btnRegistrarAnimal, errorProvider1);
        }

        private void txtFechaNacimientoAnimal_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtFechaNacimientoAnimal, btnRegistrarAnimal, errorProvider1);
        }
    }
}
