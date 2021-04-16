using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente;
using Servidor;
using System.Windows.Forms;

namespace Principal
{
    public partial class Cliente : Form
    {
        bool servidorIniciado;
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Esta realmente seguro que desea salir?";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult respuesta = MessageBox.Show(mensaje, "Salir", botones);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            PantallaMenu pantallaMenu = new PantallaMenu();
            pantallaMenu.Show();
        }
                
        private void btnServidor_Click(object sender, EventArgs e)
        {
            if(!servidorIniciado) //true = servidor activo - false = servidor inactivo.
            {
                frmServidor servidor = new frmServidor();
                servidor.Show();

                servidorIniciado = true;
            }
            else
            {
                MessageBox.Show("Servidor ya se encuentra en línea.");
            }            
        }
    }
}
