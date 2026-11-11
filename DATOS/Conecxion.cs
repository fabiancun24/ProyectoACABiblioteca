using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ProyectoACAbiblioteca.DATOS
{
    public class Conexion
    {
        private string cadenaConexion = "Server = (localdb)\\MSSQLLocalDB;Database=ProyectoACAbiblioteca;Integrated Security=true;TrustServerCertificate=true;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }

}
