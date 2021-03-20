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
    public partial class PantallaRegistrarRaza : Form
    {
        Validaciones v = new Validaciones();

        PantallaMenu pm = new PantallaMenu();

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
        private void pnlRegistroRaza_MouseLeave(object sender, EventArgs e)
        {
            activarBoton();
        }

        //Controlador de espacios vacios.
        public void activarBoton()
        {
            if ((txtCodigoRaza.Text.Trim() != string.Empty) && (txtDescripcionRaza.Text.Trim() != string.Empty))
            {
                errorProvider1.SetError(pnlRegistroRaza, "");
                btnRegistrarRaza.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(pnlRegistroRaza, "Hay algún espacio sin llenar!.");
                btnRegistrarRaza.Enabled = false;
            }
        }

        /*
         * RegistrarRazaAnimal()
         * Se crea un objeto 'nuevaRazaAnimal' que almacena los datos que se solicitan.
         * al final regresa los datos guardados en nuevaRazaAnimal.
         * Se puede almacenar en un array de tipo RazaAnimal.
         */
        public RazaAnimal RegistrarRazaAnimal()
        {
            RazaAnimal nuevaRazaAnimal = new RazaAnimal();

            nuevaRazaAnimal.CodigoRaza = Convert.ToInt32(txtCodigoRaza.Text);
            nuevaRazaAnimal.DescrpcionRaza = txtDescripcionRaza.Text;

            return nuevaRazaAnimal;
        }

        public void btnRegistrarRaza_Click(object sender, EventArgs e)
        {
            if (pm.listaRazaAnimal.Length == pm.contadorRazaAnimal)
            {
                //Err
                errorProvider1.SetError(btnRegistrarRaza, "¡Ya no quedan espacios para guardar¡");
            }
            else
            {
                pm.listaRazaAnimal[pm.contadorRazaAnimal] = RegistrarRazaAnimal(); ;
                pm.contadorRazaAnimal++;
            }
        }
    }
}
