using Cliente;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    public class Operaciones
    {
        public Dueno ObtenerDueno()
        {
            List<Dueno> resultado = new List<Dueno>();

            string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString; // Obtiene la cadena para la conexión a la base de datos.

            SqlConnection conexion = new SqlConnection(cadenaConexion); // Realiza la conexión con los paremetros de @cadenaConexion.
            SqlCommand comando = new SqlCommand();
            SqlDataReader reader; // Contenedor para los datos que devuelva la base de datos.

            string sqlQuery = "SELECT Identificacion, Nombre , Primer_Apellid0, Segundo_Apellido, Correo_Electronico, Telefono_Celular, Id_Finca from dbo.Duenno"; // Almacena la consulta a la base de datos.

            // Carga los datos de la base de datos generados por la consulta almacenada en @sqlQuery.
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = sqlQuery;
            comando.Connection = conexion;

            // Abre la conexión a la base de datos.
            conexion.Open();
            reader = comando.ExecuteReader(); // Contiene los datos devueltos por la consulta de @sqlQuery.

            // Recorre los datos almacenados en @reader y los almacena en una lista.
            while(reader.Read())
            {                
                resultado.Add
                (
                    new Dueno
                    {
                        Identificacion = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        PrimerApellido = reader.GetString(2),
                        SegundoApellido = reader.GetString(3),
                        CorreoElectronico = reader.GetString(4),
                        NumeroCelular = reader.GetInt32(5),
                        Finca = reader.GetInt32(6),
                    }
                );
            }

            // Cierra la conexión a la base de datos.
            conexion.Close();

            // Regresa el resultado obtenido.
            return null;
        }
    }
}
