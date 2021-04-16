using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Servidor
{
    class Conexion
    {

        public static SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection("JASON\SQLEXPRESS; DATABASE = MIFINCA; Integrated Security=True");

            conexion.Open();

            return conexion;
        }
    }
}
