using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
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
            for (int i = 0; i < PantallaMenu.contadorRazaAnimal; i++)
            {

                if (dgvRaza.Rows[i].Cells[0].Value != String.Empty)
                {
                    int n = dgvRaza.Rows.Add();

                    dgvRaza.Rows[n].Cells[0].Value = PantallaMenu.listaRazaAnimal[i].CodigoRaza;
                    dgvRaza.Rows[n].Cells[1].Value = PantallaMenu.listaRazaAnimal[i].DescrpcionRaza;                    
                }
                else
                {
                    string mensaje = "Se han ingresado todos los registros.";
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show(mensaje, "Atención", botones);
                    i = 9;
                }

            }
        }
    }
}
