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
    public partial class PantallaMenu : Form
    {
        //Listas
        public static Finca[] listaFinca = new Finca[10];
        public static Dueno[] listaDueno = new Dueno[10];
        public static Empleado[] listaEmpleado = new Empleado[10];
        public static RazaAnimal[] listaRazaAnimal = new RazaAnimal[10];
        public static Animal[] listaAnimal = new Animal[10];

        //Controladores        
        public static int contadorFinca = 0;
        public static int contadorDueno = 0;
        public static int contadorEmpleado = 0;
        public static int contadorRazaAnimal = 0;
        public static int contadorAnimal = 0;

        public PantallaMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Esta realmente seguro que desea salir?";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult respuesta = MessageBox.Show(mensaje, "Salir", botones);

            if(respuesta == DialogResult.Yes)
            {
                this.Close();
            }            
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

        private void button5_Click(object sender, EventArgs e)
        {
            using (PantallaRegistrarAnimal registroAnimal = new PantallaRegistrarAnimal())
                registroAnimal.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (PantallaMostrarFinca mostrarFinca = new PantallaMostrarFinca())
                mostrarFinca.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (PantallaMostrarDueno mostrarDueno = new PantallaMostrarDueno())
                mostrarDueno.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (PantallaMostrarEmpleado mostrarEmpleado = new PantallaMostrarEmpleado())
                mostrarEmpleado.ShowDialog();
        }

        private void btnRazaAnimal_Click(object sender, EventArgs e)
        {
            using (PantallaMostrarRaza mostrarRaza = new PantallaMostrarRaza())
                mostrarRaza.ShowDialog();
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            using (PantallaMostarAnimales mostrarAnimal = new PantallaMostarAnimales())
                mostrarAnimal.ShowDialog();
        }

        private void btnClasificacionAnimales_Click(object sender, EventArgs e)
        {
            using (PantallaMostrarClasificacionAnimales mostrarClasificacion = new PantallaMostrarClasificacionAnimales())
                mostrarClasificacion.ShowDialog();
        }
    }
}
