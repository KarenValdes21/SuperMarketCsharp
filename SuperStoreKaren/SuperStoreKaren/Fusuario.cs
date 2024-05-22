using System.Data;
using System.Data.SqlClient;

namespace SuperStoreKaren
{
    public class Fusuario : Conexion
    {

        public DataTable validar_usuario(string us, string pass)
        {
            conectado();
            cmd = new SqlCommand("SP_validar_usuario", ccn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Username", us);
            cmd.Parameters.AddWithValue("@contraseña", pass);

            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }

    }
}