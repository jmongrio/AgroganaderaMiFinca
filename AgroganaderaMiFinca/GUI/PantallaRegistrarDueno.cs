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
    public partial class PantallaRegistrarDueno : Form
    {
        Validaciones v = new Validaciones();

        public PantallaRegistrarDueno()
        {
            InitializeComponent();
        }

        private void txtDireccionFinca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdentificacionDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtIdentificacionDueno, btnRegistrarDueno, errorProvider1);
        }

        private void txtNombreDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtNombreDueno, btnRegistrarDueno, errorProvider1);
        }

        private void txtPrimerApellidoDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtPrimerApellidoDueno, btnRegistrarDueno, errorProvider1);
        }

        private void txtSegundoApellidoDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtSegundoApellidoDueno, btnRegistrarDueno, errorProvider1);
        }

        private void txtCorreoElectronicoDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtCorreoElectronicoDueno, btnRegistrarDueno, errorProvider1);
        }

        private void txtNumeroCelularDueno_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtNumeroCelularDueno, btnRegistrarDueno, errorProvider1);
        }

        private void btnRegistrarDueno_Click(object sender, EventArgs e)
        {
            try
            {
                if(ComprobarEspaciosVacios() == true)
                {
                    errorProvider1.SetError(btnRegistrarDueno, "");

                    if (PantallaMenu.contadorDueno != 10)
                    {
                        PantallaMenu.listaDueno[PantallaMenu.contadorDueno] = RegistrarDueno();

                        PantallaMenu.contadorDueno++;

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
                    errorProvider1.SetError(btnRegistrarDueno, "Existen espacios sin llenar.");
                }
            }
            catch (Exception i)
            {
                string mensaje = "Ha ocurrido un error: " + i;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Error", botones);
            }
        }

        private void PantallaRegistrarDueno_Load(object sender, EventArgs e)
        {
            //Agrega las fincas al @comboBox
            for(int i = 0; i < PantallaMenu.contadorFinca; i++)
            {
                if(PantallaMenu.listaFinca[i].NombreFinca != null)
                {
                    cmbFincaDueno.Items.Insert(i, PantallaMenu.listaFinca[i].NombreFinca);
                }
                else
                {
                    i = PantallaMenu.contadorFinca;
                }
            }
            
        }

        /*
         * Asigna los datos del formulario a las variable de la lista
         */
        public Dueno RegistrarDueno()
        {
            Dueno nuevoDueno = new Dueno();

            try
            {
                nuevoDueno.Identificacion = Convert.ToInt32(txtIdentificacionDueno.Text);
                nuevoDueno.Nombre = txtNombreDueno.Text;
                nuevoDueno.PrimerApellido = txtPrimerApellidoDueno.Text;
                nuevoDueno.SegundoApellido = txtSegundoApellidoDueno.Text;
                nuevoDueno.CorreoElectronico = txtCorreoElectronicoDueno.Text;
                nuevoDueno.NumeroCelular = Convert.ToInt32(txtNumeroCelularDueno.Text);
                //Extrae el número de la finca en base al indice seleccionado en comboBox
                int indice = cmbFincaDueno.SelectedIndex;
                nuevoDueno.Finca = PantallaMenu.listaFinca[indice].NumeroFinca;
            }
            catch (Exception e)
            {
                string mensaje = "Ha ocurrido un error: " + e;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Error", botones);
            }

            return nuevoDueno;
        }

        public bool ComprobarEspaciosVacios() //Evalua que todos los campor esten llenos.
        {
            bool vacio = false;
            if ((txtIdentificacionDueno.Text.Trim() != string.Empty) && (txtNombreDueno.Text.Trim() != string.Empty) &&
                (txtPrimerApellidoDueno.Text.Trim() != string.Empty) && (txtSegundoApellidoDueno.Text.Trim() != string.Empty) &&
                (txtCorreoElectronicoDueno.Text.Trim() != string.Empty) && (txtNumeroCelularDueno.Text.Trim() != string.Empty)&&
                cmbFincaDueno.SelectedIndex != -1)
            {
                vacio = true;
            }

            return vacio;
        }

        public void LimpiarCampos() //Reestablece los campos
        {
            txtIdentificacionDueno.Text = "";
            txtNombreDueno.Text = "";
            txtPrimerApellidoDueno.Text = "";
            txtSegundoApellidoDueno.Text = "";
            txtCorreoElectronicoDueno.Text = "";
            txtNumeroCelularDueno.Text = "";
            cmbFincaDueno.SelectedIndex = -1;
        }
    }//Fin PantallaRegistrarDueno
}
