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
    public partial class PantallaMostarAnimales : Form
    {
        public PantallaMostarAnimales()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PantallaMenu.contadorAnimal; i++)
            {

                if (dgvAnimales.Rows[i].Cells[0].Value != String.Empty)
                {
                    int n = dgvAnimales.Rows.Add();

                    dgvAnimales.Rows[n].Cells[0].Value = PantallaMenu.listaAnimal[i].Identificacion;
                    dgvAnimales.Rows[n].Cells[1].Value = PantallaMenu.listaAnimal[i].Nombre;
                    dgvAnimales.Rows[n].Cells[2].Value = PantallaMenu.listaAnimal[i].Finca;
                    dgvAnimales.Rows[n].Cells[3].Value = PantallaMenu.listaAnimal[i].Raza;
                    dgvAnimales.Rows[n].Cells[4].Value = PantallaMenu.listaAnimal[i].FechaNacimiento;
                    dgvAnimales.Rows[n].Cells[5].Value = PantallaMenu.listaAnimal[i].Sexo;
                    dgvAnimales.Rows[n].Cells[6].Value = PantallaMenu.listaAnimal[i].Madre;
                    dgvAnimales.Rows[n].Cells[7].Value = PantallaMenu.listaAnimal[i].Padre;
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
