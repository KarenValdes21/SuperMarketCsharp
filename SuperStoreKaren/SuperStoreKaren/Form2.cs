using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SuperStoreKaren
{
    public partial class Form2
    {
        private string query;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form2()
        {

            // This call is required by the designer.
            InitializeComponent();
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // Add any initialization after the InitializeComponent() call.
            // Create a new instance of the Connection class

            query = "select id, Estado from Estado";
            cboEstado.DataSource = Connection.SelectQuery(query);
            cboEstado.DisplayMember = "Estado";
            cboEstado.ValueMember = "id";

        }
        // Al correr el progama es importante recordar que no todos los estados contienen clientes.
        // Un ejemplo que si contiene clientes es Oregon
        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = Conversions.ToString(Operators.ConcatenateObject("select id, Ciudad from [dbo].[Ciudad] where idEstado=", cboEstado.SelectedValue));
            CbCiudad.DataSource = Connection.SelectQuery(query);
            CbCiudad.DisplayMember = "Ciudad";
            CbCiudad.ValueMember = "id";
        }

        private void CbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cboEstado.Text is null)
            {
                return;
            }
            query = "select * from VW_DatosSuperMarket1 where [NombreCiudad]='" + CbCiudad.Text + "'";
            DataGridView1.DataSource = Connection.SelectQuery(query);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // Panel2.Hide()

        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            // Panel2.Show()

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.Producto.Show();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Clientes.Show();

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Pedidos.Show();

        }
    }
}