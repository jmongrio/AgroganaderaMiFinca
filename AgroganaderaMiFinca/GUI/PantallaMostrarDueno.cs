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
    public partial class PantallaMostrarDueno : Form
    {
        public PantallaMostrarDueno()
        {
            InitializeComponent();
        }

        private void btnActualizarDueno_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PantallaMenu.contadorDueno; i++)
            {

                if (dgvDueno.Rows[i].Cells[0].Value != String.Empty)
                {
                    int n = dgvDueno.Rows.Add();

                    dgvDueno.Rows[n].Cells[0].Value = PantallaMenu.listaDueno[i].Identificacion;
                    dgvDueno.Rows[n].Cells[1].Value = PantallaMenu.listaDueno[i].Nombre;
                    dgvDueno.Rows[n].Cells[2].Value = PantallaMenu.listaDueno[i].PrimerApellido;
                    dgvDueno.Rows[n].Cells[3].Value = PantallaMenu.listaDueno[i].SegundoApellido;
                    dgvDueno.Rows[n].Cells[4].Value = PantallaMenu.listaDueno[i].CorreoElectronico;
                    dgvDueno.Rows[n].Cells[5].Value = PantallaMenu.listaDueno[i].NumeroCelular;
                    dgvDueno.Rows[n].Cells[6].Value = PantallaMenu.listaDueno[i].Finca;
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
