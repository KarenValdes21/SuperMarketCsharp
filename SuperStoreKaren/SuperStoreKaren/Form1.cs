using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SuperStoreKaren
{
    public partial class Form1
    {
        private string query;
        private static SqlConnection cnx = new SqlConnection();
        public SqlCommand cmd;
        public SqlDataReader sqlread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcontra.Text) & !string.IsNullOrEmpty(txtusuario.Text))
            {
                var dtusuario = new DataTable();
                var fu = new Fusuario();
                dtusuario = fu.validar_usuario(txtusuario.Text, txtcontra.Text);

                if (dtusuario.Rows.Count != 0)
                {
                    int userID = Convert.ToInt32(dtusuario.Rows[0]["id"]); // Asumiendo que la columna UserID contiene el ID del usuario
                    MessageBox.Show("Bienvenido usuario " + txtusuario.Text, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    txtcontra.Clear();
                    txtusuario.Clear();

                    // Guardar el ID del usuario en My.Settings
                    My.MySettingsProperty.Settings.CurrentUserID = userID;
                    My.MySettingsProperty.Settings.Save();
                    My.MyProject.Forms.Form2.Show();
                }
                else
                {
                    MessageBox.Show("Error al entrar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al entrar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Button1_ParentChanged(object sender, EventArgs e)
        {
            var bth = new System.Drawing.Drawing2D.GraphicsPath();
            var r = Button1.ClientRectangle;
            r.Inflate(0, 10);
            bth.AddEllipse(r);
            Button1.Region = new Region(bth);
        }

        private void Usuariotxt_ParentChanged(object sender, EventArgs e)
        {
            var bth = new System.Drawing.Drawing2D.GraphicsPath();
            var r = Button1.ClientRectangle;
            r.Inflate(0, 10);
            bth.AddEllipse(r);
            Button1.Region = new Region(bth);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cnx.ConnectionString = "Data Source=LAPTOP-RRR3K3KV; Initial Catalog=SuperMarketPrueba2;Integrated Security=True";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Usuariotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseñatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form2.Show();

        }
    }
}