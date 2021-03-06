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
    public partial class PantallaMostrarEmpleado : Form
    {
        public PantallaMostrarEmpleado()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PantallaMenu.contadorEmpleado; i++)
            {

                if (dgvEmpleado.Rows[i].Cells[0].Value != String.Empty)
                {
                    int n = dgvEmpleado.Rows.Add();

                    dgvEmpleado.Rows[n].Cells[0].Value = PantallaMenu.listaEmpleado[i].Identificacion;
                    dgvEmpleado.Rows[n].Cells[1].Value = PantallaMenu.listaEmpleado[i].Nombre;
                    dgvEmpleado.Rows[n].Cells[2].Value = PantallaMenu.listaEmpleado[i].PrimerApellido;
                    dgvEmpleado.Rows[n].Cells[3].Value = PantallaMenu.listaEmpleado[i].SegundoApellido;
                    dgvEmpleado.Rows[n].Cells[4].Value = PantallaMenu.listaEmpleado[i].Salario;
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
