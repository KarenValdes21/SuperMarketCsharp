using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SuperStoreKaren
{

    public partial class Clientes
    {
        private string query;
        private string adapter;
        private string conexion;

        public Clientes()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFiltro.Text))
            {
                Interaction.MsgBox("Por favor, revise que todos los campos estén llenos");
                return;
            }

            string ClienteID = TxtFiltro.Text;
            string IdSegmento = CbIdSegmento.SelectedValue.ToString();
            string IdRegion = CbIdRegion.SelectedValue.ToString();

            // Obtener el ID del usuario que ha iniciado sesión desde My.Settings
            int UsuarioCrea = My.MySettingsProperty.Settings.CurrentUserID;

            // Verificar que el ID del usuario es válido
            if (UsuarioCrea <= 0)
            {
                Interaction.MsgBox("Error: ID de usuario no válido. Por favor, vuelva a iniciar sesión.");
                return;
            }

            Connection.AgregarCliente(ClienteID, UsuarioCrea, IdRegion, IdSegmento);
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFiltro.Text))
            {
                Interaction.MsgBox("Por favor, asegúrate de completar todos los campos.");
                return;
            }

            string ClienteID = TxtFiltro.Text;
            var idRegion = CbIdRegion.SelectedValue; // Suponiendo que CbIdRegion es un ComboBox que contiene el ID de la región seleccionada
            var idSegmento = CbIdSegmento.SelectedValue; // Suponiendo que CbIdSegmento es un ComboBox que contiene el ID del segmento seleccionado
            int UsuarioModifica = 1; // Suponiendo que UsuarioModifica es el ID del usuario que realiza la edición
            var fechaMod = Convert.ToDateTime(TxtDate.Text);

            Connection.EditarCliente(ClienteID, Conversions.ToInteger(idRegion), Conversions.ToInteger(idSegmento), UsuarioModifica, fechaMod);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFiltro.Text))
            {
                Interaction.MsgBox("Por favor, revisa que todos los campos estén llenos");
                return;
            }

            string ClienteID = TxtFiltro.Text;

            Connection.EliminarCliente(ClienteID);
        }


        // query = "select * from cliente"
        // DataGridView1.DataSource = Connection.SelectQuery(query)

        // query = "select distinct Region from Region"
        // CbIdRegion.DataSource = Connection.SelectQuery(query)
        // CbIdRegion.DisplayMember = "Region"

        // query = "select id, segmento from segmento"
        // CbIdSegmento.DataSource = Connection.SelectQuery(query)
        // CbIdSegmento.DisplayMember = "segmento"
        // CbIdSegmento.ValueMember = "id"
        private void Clientes_Load(object sender, EventArgs e)
        {
            // Define la cadena de conexión
            string connectionString = "Data Source=LAPTOP-RRR3K3KV; Initial Catalog=SuperMarketPrueba2;Integrated Security=True";

            try
            {
                // Asumiendo que Connection es un objeto que maneja la conexión a la base de datos
                query = "select * from cliente";
                DataGridView1.DataSource = Connection.SelectQuery(query);

                // Cargar regiones
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT Id, Region FROM Region", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dtRegion = new DataTable();
                            dtRegion.Load(reader);

                            CbIdRegion.DisplayMember = "Region";
                            CbIdRegion.ValueMember = "Id";
                            CbIdRegion.DataSource = dtRegion;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al cargar las regiones: " + ex.Message);
            }

            try
            {
                // Cargar segmentos
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT Id, Segmento FROM Segmento", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dtSegmento = new DataTable();
                            dtSegmento.Load(reader);

                            CbIdSegmento.DisplayMember = "Segmento";
                            CbIdSegmento.ValueMember = "Id";
                            CbIdSegmento.DataSource = dtSegmento;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al cargar los segmentos: " + ex.Message);
            }
        }


    }
}