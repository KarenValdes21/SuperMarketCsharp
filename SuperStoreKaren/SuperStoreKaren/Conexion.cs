using System.Data.SqlClient;

namespace SuperStoreKaren
{

    public class Conexion
    {

        protected SqlConnection ccn = new SqlConnection();
        protected SqlCommand cmd = new SqlCommand();

        public void conectado()
        {
            ccn = new SqlConnection("Data Source=LAPTOP-RRR3K3KV;Initial Catalog=SuperMarketPrueba2;Integrated security = true");
            ccn.Open();
        }

    }
}