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
    public partial class PantallaRegistrarFinca : Form
    {
        Validaciones v = new Validaciones();       

        public PantallaRegistrarFinca()
        { 
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void txtNumeroFinca_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtNumeroFinca, btnRegistrarFinca, errorProvider1);
        }

        private void txtTamanoFinca_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtTamanoFinca, btnRegistrarFinca, errorProvider1);
        }

        private void txtNombreFinca_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtNombreFinca, btnRegistrarFinca, errorProvider1);
        }

        private void txtDireccionFinca_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtDireccionFinca, btnRegistrarFinca, errorProvider1);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtTelefono, btnRegistrarFinca, errorProvider1);
        }

        private void btnRegistrarFinca_Click(object sender, EventArgs e)
        {
            try
            {

                if (ComprobarEspaciosVacios() == true)
                {
                    errorProvider1.SetError(btnRegistrarFinca, "");

                    if (PantallaMenu.contadorFinca != 10)
                    {
                        PantallaMenu.listaFinca[PantallaMenu.contadorFinca] = RegistrarFinca();

                        PantallaMenu.contadorFinca++;

                        string mensaje = "Se ha agregado los datos correctamente.";
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Listo", botones);

                        LimpiarCampos();
                    }
                    else
                    {
                        string mensaje = "Se ha llegado al número maximo de fincas (10).";
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Error", botones);
                    }
                }
                else
                {
                    string mensaje = "Existen espacios sin llenar.";
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show(mensaje, "Error", botones);
                    errorProvider1.SetError(btnRegistrarFinca, "Existen espacios sin llenar.");
                }
            }
            catch (Exception i)
            {
                string mensaje = "Ha ocurrido un error: " + i;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Error", botones);
            }

        }

        /*
         * Asigna los datos del formulario a las variable de la lista
         */
        public Finca RegistrarFinca()
        {
            Finca nuevaFinca = new Finca();
            
            try
            {
                nuevaFinca.NumeroFinca = Convert.ToInt32(txtNumeroFinca.Text);
                nuevaFinca.NombreFinca = txtNombreFinca.Text;
                nuevaFinca.TamanoFinca = Convert.ToInt32(txtTamanoFinca.Text);
                nuevaFinca.DireccionFinca = txtDireccionFinca.Text;
                nuevaFinca.Telefono = Convert.ToInt32(txtTelefono.Text);
            }
            catch(Exception e)
            {
                string mensaje = "Ha ocurrido un error: " + e;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Error", botones);
            }           

            return nuevaFinca;
        }

        public bool ComprobarEspaciosVacios() //Evalua que todos los campor esten llenos.
        {
            bool vacio = false;
            if((txtNumeroFinca.Text.Trim() != string.Empty) && (txtNombreFinca.Text.Trim() != string.Empty) && 
                (txtTamanoFinca.Text.Trim() != string.Empty) && (txtDireccionFinca.Text.Trim() != string.Empty) && 
                (txtTelefono.Text.Trim() != string.Empty))
            {
                vacio = true;
            }

            return vacio;
        }

        public void LimpiarCampos() //Reestablece los campos
        {
            txtNumeroFinca.Text = "";
            txtNombreFinca.Text = "";
            txtTamanoFinca.Text = "";
            txtDireccionFinca.Text = "";
            txtTelefono.Text = "";
        }
    }
}
