using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SuperStoreKaren
{
    public partial class Producto
    {
        private string query;

        public Producto()
        {
            InitializeComponent();
        }
        private void BtnEditarProducto_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtProductID.Text) || string.IsNullOrWhiteSpace(TxtNombreProducto.Text))
            {
                Interaction.MsgBox("Por favor, revise que todos los campos estén llenos");
                return;
            }

            string ProductID = TxtProductID.Text;
            string NombreProducto = TxtNombreProducto.Text;
            string categoria = TxtCategoria.Text;
            string subcategoria = TxtSubcategoria.Text;
            string UsuarioCrea = "1";
            var fechaMod = Convert.ToDateTime(TxtDate.Text);

            Connection.EditarProducto(ProductID, NombreProducto, Conversions.ToInteger(UsuarioCrea), fechaMod);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadD()
        {
            try
            {
                query = "select * from producto";
                DataGridView1.DataSource = Connection.SelectQuery(query);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtProductID.Text))
            {
                Interaction.MsgBox("Por favor, revise que todos los campos estén llenos");
                return;
            }

            string ProductID = TxtProductID.Text;

            Connection.EliminarProducto(ProductID.ToString());
        }
        public string SelectedProduct;
        private void PictureBox2_Click(object sender, EventArgs e)
        {

            query = "SELECT id, [NombreProducto] FROM Producto WHERE NombreProducto = '" + SelectedProduct.Replace("'", "''") + "'";
            DataGridView1.DataSource = Connection.SelectQuery(query);
        }

        private void BtnEditarProducto_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            TxtProductID.Clear();
            TxtNombreProducto.Clear();


        }

        private void Producto_Load(object sender, EventArgs e)
        {
            query = "select * from producto;";
            DataGridView1.DataSource = Connection.SelectQuery(query);

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtProductID.Text) || string.IsNullOrWhiteSpace(TxtNombreProducto.Text))
            {
                Interaction.MsgBox("Por favor, revise que todos los campos estén llenos");
                return;
            }

            string ProductID = TxtProductID.Text;
            string NombreProducto = TxtNombreProducto.Text;
            string categoria = TxtCategoria.Text;
            string subcategoria = TxtSubcategoria.Text;
            string UsuarioCrea = "1";


            Connection.AgregarProducto(ProductID, NombreProducto, categoria, subcategoria, Conversions.ToInteger(UsuarioCrea));

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtProductID.Text))
            {
                Interaction.MsgBox("Por favor, revise que todos los campos estén llenos");
                return;
            }

            string ProductID = TxtProductID.Text;

            Connection.EliminarProducto(ProductID.ToString());
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}