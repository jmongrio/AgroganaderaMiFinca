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
    public partial class PantallaMostrarClasificacionAnimales : Form
    {
        public PantallaMostrarClasificacionAnimales()
        {
            InitializeComponent();
        }

        private void PantallaMostrarClasificacionAnimales_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < PantallaMenu.contadorAnimal; i++)
            {
                if (dgvPrincipal.Rows[i].Cells[0].Value != String.Empty)
                {
                    int n = dgvPrincipal.Rows.Add();

                    dgvPrincipal.Rows[n].Cells[0].Value = PantallaMenu.listaAnimal[i].Identificacion;
                    dgvPrincipal.Rows[n].Cells[1].Value = PantallaMenu.listaAnimal[i].Nombre;
                    dgvPrincipal.Rows[n].Cells[2].Value = PantallaMenu.listaAnimal[i].Finca;
                    dgvPrincipal.Rows[n].Cells[3].Value = PantallaMenu.listaAnimal[i].Raza;
                    dgvPrincipal.Rows[n].Cells[4].Value = PantallaMenu.listaAnimal[i].FechaNacimiento;
                    dgvPrincipal.Rows[n].Cells[5].Value = PantallaMenu.listaAnimal[i].Sexo;
                    dgvPrincipal.Rows[n].Cells[6].Value = PantallaMenu.listaAnimal[i].Madre;
                    dgvPrincipal.Rows[n].Cells[7].Value = PantallaMenu.listaAnimal[i].Padre;
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

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < PantallaMenu.contadorAnimal; i++)
                {
                    if (dgvHembra.Rows[i].Cells[0].Value != String.Empty)
                    {
                        if(PantallaMenu.listaAnimal[i].Sexo == 1)
                        {
                            int n = dgvHembra.Rows.Add();

                            dgvHembra.Rows[n].Cells[0].Value = PantallaMenu.listaAnimal[i].Identificacion;
                            dgvHembra.Rows[n].Cells[1].Value = PantallaMenu.listaAnimal[i].Nombre;
                            dgvHembra.Rows[n].Cells[2].Value = PantallaMenu.listaAnimal[i].Finca;
                            dgvHembra.Rows[n].Cells[3].Value = PantallaMenu.listaAnimal[i].Raza;
                            dgvHembra.Rows[n].Cells[4].Value = PantallaMenu.listaAnimal[i].FechaNacimiento;
                            dgvHembra.Rows[n].Cells[5].Value = PantallaMenu.listaAnimal[i].Sexo;
                            dgvHembra.Rows[n].Cells[6].Value = PantallaMenu.listaAnimal[i].Madre;
                            dgvHembra.Rows[n].Cells[7].Value = PantallaMenu.listaAnimal[i].Padre;
                        }
                        else
                        {
                            int n = dgvMacho.Rows.Add();

                            dgvMacho.Rows[n].Cells[0].Value = PantallaMenu.listaAnimal[i].Identificacion;
                            dgvMacho.Rows[n].Cells[1].Value = PantallaMenu.listaAnimal[i].Nombre;
                            dgvMacho.Rows[n].Cells[2].Value = PantallaMenu.listaAnimal[i].Finca;
                            dgvMacho.Rows[n].Cells[3].Value = PantallaMenu.listaAnimal[i].Raza;
                            dgvMacho.Rows[n].Cells[4].Value = PantallaMenu.listaAnimal[i].FechaNacimiento;
                            dgvMacho.Rows[n].Cells[5].Value = PantallaMenu.listaAnimal[i].Sexo;
                            dgvMacho.Rows[n].Cells[6].Value = PantallaMenu.listaAnimal[i].Madre;
                            dgvMacho.Rows[n].Cells[7].Value = PantallaMenu.listaAnimal[i].Padre;
                        }
                    }
                    else
                    {
                        string mensaje = "Se han ingresado todos los registros.";
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Atención", botones);
                        i = 9;
                    }
                }

                for (int j = 0; j < PantallaMenu.contadorAnimal; j++)
                {
                    dgvPrincipal.Rows.Clear();
                }
            }
            catch(Exception err)
            {
                string mensaje = "Ha ocurrido un error: " + err;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Error", botones);
            }
            
        }
    }
}
