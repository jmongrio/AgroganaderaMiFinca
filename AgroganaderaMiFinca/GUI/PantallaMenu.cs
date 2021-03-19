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
    public partial class PantallaMenu : Form
    {
        public PantallaMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlMostrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PantallaRegistrarFinca registroFinca = new PantallaRegistrarFinca())
                registroFinca.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (PantallaRegistrarDueno registroDueno = new PantallaRegistrarDueno())
                registroDueno.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (PantallaRegistrarEmpleado registroEmpleado = new PantallaRegistrarEmpleado())
                registroEmpleado.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (PantallaRegistrarRaza registroRaza = new PantallaRegistrarRaza())
                registroRaza.ShowDialog();
        }
    }
}
