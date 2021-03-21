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
    public partial class PantallaMostrarFinca : Form
    {
        public PantallaMostrarFinca()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarFincas_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < PantallaMenu.contadorFinca; i++)
            {               

                if (dgvFinca.Rows[i].Cells[0].Value != String.Empty)
                {
                    int n = dgvFinca.Rows.Add();

                    dgvFinca.Rows[n].Cells[0].Value = PantallaMenu.listaFinca[i].NumeroFinca;
                    dgvFinca.Rows[n].Cells[1].Value = PantallaMenu.listaFinca[i].NombreFinca;
                    dgvFinca.Rows[n].Cells[2].Value = PantallaMenu.listaFinca[i].TamanoFinca;
                    dgvFinca.Rows[n].Cells[3].Value = PantallaMenu.listaFinca[i].DireccionFinca;
                    dgvFinca.Rows[n].Cells[4].Value = PantallaMenu.listaFinca[i].Telefono;
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
