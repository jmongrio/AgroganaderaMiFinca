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
    public partial class PantallaRegistrarAnimal : Form
    {
        Validaciones v = new Validaciones();
        public PantallaRegistrarAnimal()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdentificacionAnimal_TextChanged(object sender, EventArgs e)
        {
            v.comprobarNumeros(txtIdentificacionAnimal, btnRegistrarAnimal, errorProvider1);
        }

        private void txtFechaNacimientoAnimal_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtFechaNacimientoAnimal, btnRegistrarAnimal, errorProvider1);
        }

        private void txtMadreAnimal_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtMadreAnimal, btnRegistrarAnimal, errorProvider1);
        }

        private void txtPadreAnimal_TextChanged(object sender, EventArgs e)
        {
            v.comprobarEspaciosVacios(txtPadreAnimal, btnRegistrarAnimal, errorProvider1);
        }

        private void PantallaRegistrarAnimal_Load(object sender, EventArgs e)
        {
            //Agrega las fincas al @comboBox
            for (int i = 0; i < PantallaMenu.contadorFinca; i++)
            {
                if (PantallaMenu.listaFinca[i].NombreFinca != null)
                {
                    cmbFincaAnimal.Items.Insert(i, PantallaMenu.listaFinca[i].NombreFinca);
                }
                else
                {
                    i = PantallaMenu.contadorFinca;
                }
            }

            //Agrega las Razas al @comboBox
            for (int i = 0; i < PantallaMenu.contadorRazaAnimal; i++)
            {
                if (PantallaMenu.listaFinca[i].NombreFinca != null)
                {
                    cmbRazaAnimal.Items.Insert(i, PantallaMenu.listaRazaAnimal[i].DescrpcionRaza);
                }
                else
                {
                    i = PantallaMenu.contadorFinca;
                }
            }

            //Agrega los Sexos al @comboBox
            cmbSexoAnimal.Items.Insert(0, "Hembra");
            cmbSexoAnimal.Items.Insert(1, "Macho");

        }        

        private void btnRegistrarAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComprobarEspaciosVacios() == true)
                {
                    errorProvider1.SetError(btnRegistrarAnimal, "");

                    if (PantallaMenu.contadorAnimal != 10)
                    {
                        PantallaMenu.listaAnimal[PantallaMenu.contadorAnimal] = RegistrarAnimal();

                        PantallaMenu.contadorAnimal++;

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
                    errorProvider1.SetError(btnRegistrarAnimal, "Existen espacios sin llenar.");
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
        public Animal RegistrarAnimal()
        {
            Animal nuevoAnimal = new Animal();

            try
            {
                nuevoAnimal.Identificacion = Convert.ToInt32(txtIdentificacionAnimal.Text);
                nuevoAnimal.Nombre = txtNombreAnimal.Text;
                nuevoAnimal.FechaNacimiento = txtFechaNacimientoAnimal.Text;
                nuevoAnimal.Madre = txtMadreAnimal.Text;
                nuevoAnimal.Padre = txtPadreAnimal.Text;
                //Extrae el número de la finca en base al indice seleccionado en comboBox
                int indiceFinca = cmbFincaAnimal.SelectedIndex;
                nuevoAnimal.Finca = PantallaMenu.listaFinca[indiceFinca].NumeroFinca;
                //Extrae el número de la raza en base al indice seleccionado en comboBox
                int indiceRaza = cmbRazaAnimal.SelectedIndex;
                nuevoAnimal.Raza = PantallaMenu.listaRazaAnimal[indiceRaza].CodigoRaza;
                //Extrae el número de la sexo en base al indice seleccionado en comboBox
                int indiceSexo = cmbSexoAnimal.SelectedIndex;
                if(cmbSexoAnimal.SelectedIndex == 0)
                {
                    nuevoAnimal.Sexo = 1;
                }
                else
                {
                    nuevoAnimal.Sexo = 2;
                }
                
            }
            catch (Exception e)
            {
                string mensaje = "Ha ocurrido un error: " + e;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, "Error", botones);
            }

            return nuevoAnimal;
        }

        public bool ComprobarEspaciosVacios() //Evalua que todos los campor esten llenos.
        {
            bool vacio = false;
            if ((txtIdentificacionAnimal.Text.Trim() != string.Empty) && (txtNombreAnimal.Text.Trim() != string.Empty) &&
                (txtFechaNacimientoAnimal.Text.Trim() != string.Empty) && (txtMadreAnimal.Text.Trim() != string.Empty) &&
                (txtPadreAnimal.Text.Trim() != string.Empty)  && (cmbSexoAnimal.SelectedIndex != -1) &&
                (cmbFincaAnimal.SelectedIndex != -1) && (cmbRazaAnimal.SelectedIndex != -1))
            {
                vacio = true;
            }

            return vacio;
        }

        public void LimpiarCampos() //Reestablece los campos
        {
            txtIdentificacionAnimal.Text = "";
            txtNombreAnimal.Text = "";
            txtFechaNacimientoAnimal.Text = "";
            txtMadreAnimal.Text = "";
            txtPadreAnimal.Text = "";
            cmbFincaAnimal.SelectedIndex = -1;
            cmbRazaAnimal.SelectedIndex = -1;
            cmbSexoAnimal.SelectedIndex = -1;
        }        
    }
}
