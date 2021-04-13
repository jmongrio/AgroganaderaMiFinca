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
    public partial class PantallaRegistrarRaza : Form
    {
        Validaciones v = new Validaciones();

        public PantallaRegistrarRaza()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoRaza_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtCodigoRaza, btnRegistrarRaza, errorProvider1);
        }

        private void txtDescripcionRaza_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtDescripcionRaza, btnRegistrarRaza, errorProvider1);            
        }

        public void btnRegistrarRaza_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComprobarEspaciosVacios() == true)
                {
                    errorProvider1.SetError(btnRegistrarRaza, "");

                    if (PantallaMenu.contadorRazaAnimal != 10)
                    {
                        PantallaMenu.listaRazaAnimal[PantallaMenu.contadorRazaAnimal] = RegistrarRaza();

                        PantallaMenu.contadorRazaAnimal++;

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
                    errorProvider1.SetError(btnRegistrarRaza, "Existen espacios sin llenar.");
                }
            }
            catch (Exception i)
            {
                string mensaje = "Ha ocurrido un error: " + i;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Error", botones);
            }
        }

        public RazaAnimal RegistrarRaza()
        {
            RazaAnimal nuevaRaza = new RazaAnimal();

            try
            {
                nuevaRaza.CodigoRaza = Convert.ToInt32(txtCodigoRaza.Text);
                nuevaRaza.DescrpcionRaza = txtDescripcionRaza.Text;
            }
            catch (Exception e)
            {
                string mensaje = "Ha ocurrido un error: " + e;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Error", botones);
            }

            return nuevaRaza;
        }

        public bool ComprobarEspaciosVacios() //Evalua que todos los campor esten llenos.
        {
            bool vacio = false;
            if ((txtCodigoRaza.Text.Trim() != string.Empty) && (txtDescripcionRaza.Text.Trim() != string.Empty))
            {
                vacio = true;
            }

            return vacio;
        }

        public void LimpiarCampos() //Reestablece los campos
        {
            txtCodigoRaza.Text = "";
            txtDescripcionRaza.Text = "";
        }
    }
}
