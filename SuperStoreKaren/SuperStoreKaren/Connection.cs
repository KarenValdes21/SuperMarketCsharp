using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace SuperStoreKaren
{

    public class Connection
    {
        protected SqlConnection ccn = new SqlConnection();
        protected SqlCommand cmd = new SqlCommand();


        private static SqlConnection cnx = new SqlConnection();
        private static void Connect()
        {
            try
            {
                cnx.ConnectionString = "Data Source=LAPTOP-RRR3K3KV; Initial Catalog=SuperMarketPrueba2;Integrated Security=True";
                cnx.Open();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        private static void Disconect()
        {
            try
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al desconectar de la base de datos: " + ex.Message);
            }
        }
        // Create a method to excecute a Selection query
        public static DataTable SelectQuery(string query)
        {
            var dt = new DataTable();
            try
            {
                Connect();
                var cmd = new SqlCommand(query, cnx);
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
            return dt;
        }

        public static void AgregarUsuario(string Username, string Contraseña, int Us)
        {
            try
            {
                Connect();
                var cmd = new SqlCommand("SP_AgregarUsuario", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username.ToString();
                cmd.Parameters.AddWithValue("@Contraseña", SqlDbType.VarChar).Value = Contraseña.ToString();
                cmd.Parameters.AddWithValue("@IdUsuarioCrea", Us);


                cmd.ExecuteNonQuery();

                Interaction.MsgBox("Producto insertado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al insertar el Producto " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }

        public static void EliminarProducto(string ProductID)
        {
            try
            {
                Connect();
                var cmd = new SqlCommand("SP_EliminarProducto", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ProductoID", SqlDbType.VarChar).Value = ProductID.ToString();

                cmd.ExecuteNonQuery();

                Interaction.MsgBox("Registro eliminado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al eliminar el registro " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }

        public static void AgregarProducto(string ProductID, string NombreProducto, string Categoria, string Subcategoria, int UsuarioCrea)
        {
            try
            {
                Connect();
                var cmd = new SqlCommand("SP_AgregarProducto", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", SqlDbType.VarChar).Value = ProductID.ToString();
                cmd.Parameters.AddWithValue("@NombreProducto", SqlDbType.VarChar).Value = NombreProducto.ToString();
                cmd.Parameters.AddWithValue("@IdUsuarioCrea", UsuarioCrea);

                cmd.ExecuteNonQuery();

                Interaction.MsgBox("Producto insertado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al insertar el Producto " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }
        public static void EditarProducto(string ProductID, string NombreProducto, int UsuarioCrea, DateTime FechaModifica)
        {
            try
            {
                Connect();
                var cmd = new SqlCommand("SP_EditarProducto", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", SqlDbType.VarChar).Value = ProductID.ToString();
                cmd.Parameters.AddWithValue("@NuevoNombreProducto", SqlDbType.VarChar).Value = NombreProducto.ToString();
                cmd.Parameters.AddWithValue("@NuevoIdUsuarioModifica", UsuarioCrea);
                cmd.Parameters.AddWithValue("@fechaModifica", FechaModifica);
                cmd.ExecuteNonQuery();


                Interaction.MsgBox("Producto editado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al editar el registro " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }

        // Public Shared Sub AgregarCliente(ClienteID As String, UsuarioCrea As Integer, IdRegion As String, IdSegmento As String)
        // Try
        // '      Call Connect()
        // Dim cmd = New SqlCommand("SPAgregarCliente", cnx)
        // cmd.CommandType = CommandType.StoredProcedure
        // cmd.Parameters.AddWithValue("@ClienteID", SqlDbType.VarChar).Value = ClienteID.ToString()
        // cmd.Parameters.AddWithValue("@IdSegmento, ", SqlDbType.VarChar).Value = IdRegion.ToString()
        // cmd.Parameters.AddWithValue("@IdRegion", SqlDbType.VarChar).Value = IdSegmento.ToString()
        // cmd.Parameters.AddWithValue("@IdUsuarioCrea", UsuarioCrea)


        // cmd.ExecuteNonQuery()

        // MsgBox("Producto insertado con éxito")
        // 'Catch ex As Exception
        // MsgBox("Error al insertar el Producto " & ex.Message)
        // Finally
        // Call Disconect()
        // End Try
        // End Sub '
        public DataTable ObtenerRegiones()
        {
            var dtRegion = new DataTable();
            try
            {
                Connect();
                var cmd = new SqlCommand("SELECT Id, Region FROM Region", cnx);
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtRegion);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al obtener regiones: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
            return dtRegion;
        }

        public DataTable ObtenerSegmentos()
        {
            var dtSegmento = new DataTable();
            try
            {
                Connect();
                var cmd = new SqlCommand("SELECT Id, Segmento FROM Segmento", cnx);
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtSegmento);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al obtener segmentos: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
            return dtSegmento;
        }

        public static void AgregarCliente(string ClienteID, int UsuarioCrea, string IdRegion, string IdSegmento)
        {
            try
            {
                Connect();
                var cmd = new SqlCommand("SPAgregarCliente", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                cmd.Parameters.AddWithValue("@IdRegion", IdRegion);
                cmd.Parameters.AddWithValue("@IdSegmento", IdSegmento);
                cmd.Parameters.AddWithValue("@IdUsuarioCrea", UsuarioCrea);

                cmd.ExecuteNonQuery();

                Interaction.MsgBox("Cliente insertado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al insertar el cliente: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }


        public static void AgregarPedido(string PedidoID, decimal Precio, int Cantidad, decimal Descuento, decimal Ganancia, DateTime OrdenFecha, DateTime EnvioFecha, string ModoEnvio, int UsuarioCrea)
        {
            try
            {
                Connect();
                var cmd = new SqlCommand("SP_AgregarPedido", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PedidoID", SqlDbType.NVarChar).Value = PedidoID;
                cmd.Parameters.AddWithValue("@Precio", SqlDbType.Decimal).Value = Precio;
                cmd.Parameters.AddWithValue("@Cantidad", SqlDbType.Int).Value = Cantidad;
                cmd.Parameters.AddWithValue("@Descuento", SqlDbType.Decimal).Value = Descuento;
                cmd.Parameters.AddWithValue("@Ganancia", SqlDbType.Decimal).Value = Ganancia;
                cmd.Parameters.AddWithValue("@OrdenFecha", SqlDbType.DateTime).Value = OrdenFecha;
                cmd.Parameters.AddWithValue("@EnvioFecha", SqlDbType.DateTime).Value = EnvioFecha;
                cmd.Parameters.AddWithValue("@ModoEnvio", SqlDbType.NVarChar).Value = ModoEnvio;
                cmd.Parameters.AddWithValue("@IdUsuarioCrea", UsuarioCrea);
                cmd.ExecuteNonQuery();

                Interaction.MsgBox("Pedido insertado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al insertar el pedido " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }
        public static void EditarCliente(string ClienteID, int idRegion, int idSegmento, int UsuarioModifica, DateTime FechaModifica)
        {
            try
            {
                Connect();
                var cmd = new SqlCommand("SP_EditarCliente", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                cmd.Parameters.AddWithValue("@idRegion", idRegion);
                cmd.Parameters.AddWithValue("@idSegmento", idSegmento);
                cmd.Parameters.AddWithValue("@NuevoIdUsuarioModifica", UsuarioModifica);
                cmd.Parameters.AddWithValue("@fechaModifica", FechaModifica);
                cmd.ExecuteNonQuery();

                Interaction.MsgBox("Producto editado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al editar el registro " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }

        public static void EditarPedido(string PedidoID, decimal Precio, int Cantidad, decimal Descuento, decimal Ganancia, DateTime OrdenFecha, DateTime EnvioFecha, string ModoEnvio, int idUsuarioModifica)
        {
            try
            {
                Connect();
                var cmd = new SqlCommand("SP_EditarPedido", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PedidoID", SqlDbType.VarChar).Value = PedidoID;
                cmd.Parameters.AddWithValue("@Precio", SqlDbType.Decimal).Value = Precio;
                cmd.Parameters.AddWithValue("@Cantidad", SqlDbType.Int).Value = Cantidad;
                cmd.Parameters.AddWithValue("@Descuento", SqlDbType.Decimal).Value = Descuento;
                cmd.Parameters.AddWithValue("@Ganancia", SqlDbType.Decimal).Value = Ganancia;
                cmd.Parameters.AddWithValue("@OrdenFecha", SqlDbType.DateTime).Value = OrdenFecha;
                cmd.Parameters.AddWithValue("@EnvioFecha", SqlDbType.DateTime).Value = EnvioFecha;
                cmd.Parameters.AddWithValue("@ModoEnvio", SqlDbType.VarChar).Value = ModoEnvio;
                cmd.Parameters.AddWithValue("@idUsuarioModifica", SqlDbType.Int).Value = idUsuarioModifica;

                cmd.ExecuteNonQuery();

                Interaction.MsgBox("Pedido editado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al editar el pedido " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }

        public static void EliminarPedido(string PedidoID)
        {
            try
            {
                Connect();
                var cmd = new SqlCommand("SP_EliminarPedido", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PedidoID", SqlDbType.VarChar).Value = PedidoID.ToString();

                cmd.ExecuteNonQuery();

                Interaction.MsgBox("Registro eliminado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al eliminar el registro " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }

        public static void EliminarCliente(string ClienteID)
        {
            try
            {
                Connect();
                var cmd = new SqlCommand("SP_EliminarCliente", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ClienteID", SqlDbType.VarChar).Value = ClienteID.ToString();

                cmd.ExecuteNonQuery();

                Interaction.MsgBox("Cliente desactivado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al desactivar el cliente: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }






    }
}