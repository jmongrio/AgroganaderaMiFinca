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
    public partial class PantallaMostrarRaza : Form
    {
        PantallaMenu pm = new PantallaMenu();

        public PantallaMostrarRaza()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int n = dgvRaza.Rows.Add();

            dgvRaza.Rows[n].Cells[0].Value = pm.listaRazaAnimal[0];
            dgvRaza.Rows[n].Cells[1].Value = pm.listaRazaAnimal[1];
        }
    }
}
