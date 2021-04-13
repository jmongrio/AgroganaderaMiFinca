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

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtNombreEmpleado, btnRegistrarEmpleado, errorProvider1);
        }

        private void txtPrimerApellidoEmpleado_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtPrimerApellidoEmpleado, btnRegistrarEmpleado, errorProvider1);
        }

        private void txtSegundoApellidoEmpleado_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtSegundoApellidoEmpleado, btnRegistrarEmpleado, errorProvider1);
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComprobarEspaciosVacios() == true)
                {
                    errorProvider1.SetError(btnRegistrarEmpleado, "");

                    if (PantallaMenu.contadorEmpleado != 10)
                    {
                        PantallaMenu.listaEmpleado[PantallaMenu.contadorEmpleado] = RegistrarEmpleado();

                        PantallaMenu.contadorEmpleado++;

                        string mensaje = "Se ha agregado los datos correctamente.";
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Listo", botones);

                        LimpiarCampos();
                    }
                    else
                    {
                        string mensaje = "Se ha llegado al número maximo de dueños (10).";
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Error", botones);
                    }
                }
                else
                {
                    string mensaje = "Existen espacios sin llenar.";
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show(mensaje, "Error", botones);
                    errorProvider1.SetError(btnRegistrarEmpleado, "Existen espacios sin llenar.");
                }
            }
            catch (Exception i)
            {
                string mensaje = "Ha ocurrido un error: " + i;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Error", botones);
            }
        }

        public Empleado RegistrarEmpleado()
        {
            Empleado nuevoEmpleado = new Empleado();

            try
            {
                nuevoEmpleado.Identificacion = Convert.ToInt32(txtIdentificacionEmpleado.Text);
                nuevoEmpleado.Nombre = txtNombreEmpleado.Text;
                nuevoEmpleado.PrimerApellido = txtPrimerApellidoEmpleado.Text;
                nuevoEmpleado.SegundoApellido = txtSegundoApellidoEmpleado.Text;
                nuevoEmpleado.Salario = Convert.ToInt32(txtSalarioEmpleado.Text);
            }
            catch (Exception e)
            {
                string mensaje = "Ha ocurrido un error: " + e;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Error", botones);
            }

            return nuevoEmpleado;
        }

        public bool ComprobarEspaciosVacios() //Evalua que todos los campor esten llenos.
        {
            bool vacio = false;
            if ((txtIdentificacionEmpleado.Text.Trim() != string.Empty) && (txtNombreEmpleado.Text.Trim() != string.Empty) &&
                (txtPrimerApellidoEmpleado.Text.Trim() != string.Empty) && (txtSegundoApellidoEmpleado.Text.Trim() != string.Empty) &&
                (txtSalarioEmpleado.Text.Trim() != string.Empty))
            {
                vacio = true;
            }

            return vacio;
        }

        public void LimpiarCampos() //Reestablece los campos
        {
            txtIdentificacionEmpleado.Text = "";
            txtNombreEmpleado.Text = "";
            txtPrimerApellidoEmpleado.Text = "";
            txtSegundoApellidoEmpleado.Text = "";
            txtSalarioEmpleado.Text = "";
        }        
    }
}
