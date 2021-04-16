using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class frmServidor : Form
    {
        TcpListener tcpListener;
        Thread subprocesoEscuchaCliente;
        bool servidorIniciado;

        public frmServidor()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            IniciarServidor();
        }

        private void IniciarServidor()
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 25000);

            subprocesoEscuchaCliente = new Thread(new ThreadStart(EscucharCliente));
            subprocesoEscuchaCliente.Start();
            subprocesoEscuchaCliente.IsBackground = true;

            servidorIniciado = true;
            lblEstadoConexion.Text = "Conectado"; 
        }

        private void EscucharCliente()
        {
            tcpListener.Start();
                        
            while (servidorIniciado)
            {
                try
                {
                    TcpClient client = tcpListener.AcceptTcpClient();

                    Thread clienteHilo = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    clienteHilo.Start(client);
                }
                catch (Exception)
                {
                    break;
                }                
            }
        }

        private void ComunicacionCliente(object obt)
        {
            TcpClient tcpCliente = (TcpClient)obt;
            NetworkStream clienteStream = tcpCliente.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();

            byte[] buffer = new byte[4096];
            int byteLeidos;

            while (servidorIniciado)
            {
                byteLeidos = 0;

                try
                {
                    byteLeidos = clienteStream.Read(buffer, 0, buffer.Length);
                }
                catch (Exception)
                {
                    break;
                }

                if (byteLeidos == 0)
                {
                    break;
                }

                string mensaje = encoder.GetString(buffer, 0, byteLeidos);

                MessageBox.Show(string.Format("El cliente {0} se ha conectado", mensaje));
            }

            tcpCliente.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            DetenerServidor();
        }

        private void DetenerServidor()
        {
            servidorIniciado = false;
            tcpListener.Stop();
            lblEstadoConexion.Text = "Desconectado";
        }
    }
}
