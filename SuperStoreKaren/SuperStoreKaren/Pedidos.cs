using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SuperStoreKaren
{
    public partial class Pedidos
    {
        private string query;

        public Pedidos()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void BtnAgregarPedido_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos necesarios estén llenos
            if (string.IsNullOrWhiteSpace(CbPedidoID.Text) || string.IsNullOrWhiteSpace(TxtPrecio.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtDescuento.Text) || string.IsNullOrWhiteSpace(txtGanancia.Text) || string.IsNullOrWhiteSpace(TxtDate.Text) || string.IsNullOrWhiteSpace(TxtDate2.Text) || string.IsNullOrWhiteSpace(CBMetodoEnvio.Text))
            {
                Interaction.MsgBox("Por favor, revise que todos los campos estén llenos");
                return;
            }

            // Obtener los valores de los campos
            string PedidoID = CbPedidoID.Text;
            string Precio = TxtPrecio.Text;
            string Cantidad = txtCantidad.Text;
            string Descuento = txtDescuento.Text;
            string Ganancia = txtGanancia.Text;
            var OrdenFecha = Convert.ToDateTime(TxtDate.Text);
            var EnvioFecha = Convert.ToDateTime(TxtDate2.Text);
            string ModoEnvio = CBMetodoEnvio.Text;
            string UsuarioCrea = "1";

            // Validar y convertir los valores numéricos y de fecha
            bool localTryParse() { decimal argresult = Conversions.ToDecimal(Precio); var ret = decimal.TryParse(TxtPrecio.Text, out argresult); Precio = argresult.ToString(); return ret; }

            if (!localTryParse())
            {
                Interaction.MsgBox("Por favor, ingrese un precio válido");
                return;
            }

            bool localTryParse1() { int argresult1 = Conversions.ToInteger(Cantidad); var ret = int.TryParse(txtCantidad.Text, out argresult1); Cantidad = argresult1.ToString(); return ret; }

            if (!localTryParse1())
            {
                Interaction.MsgBox("Por favor, ingrese una cantidad válida");
                return;
            }

            bool localTryParse2() { decimal argresult2 = Conversions.ToDecimal(Descuento); var ret = decimal.TryParse(txtDescuento.Text, out argresult2); Descuento = argresult2.ToString(); return ret; }

            if (!localTryParse2())
            {
                Interaction.MsgBox("Por favor, ingrese un descuento válido");
                return;
            }

            bool localTryParse3() { decimal argresult3 = Conversions.ToDecimal(Ganancia); var ret = decimal.TryParse(txtGanancia.Text, out argresult3); Ganancia = argresult3.ToString(); return ret; }

            if (!localTryParse3())
            {
                Interaction.MsgBox("Por favor, ingrese una ganancia válida");
                return;
            }

            if (!DateTime.TryParse(TxtDate.Text, out OrdenFecha))
            {
                Interaction.MsgBox("Por favor, ingrese una fecha de orden válida");
                return;
            }

            if (!DateTime.TryParse(TxtDate2.Text, out EnvioFecha))
            {
                Interaction.MsgBox("Por favor, ingrese una fecha de envío válida");
                return;
            }

            // Llamar al método para agregar el pedido
            try
            {
                Connection.AgregarPedido(PedidoID, Conversions.ToDecimal(Precio), Conversions.ToInteger(Cantidad), Conversions.ToDecimal(Descuento), Conversions.ToDecimal(Ganancia), OrdenFecha, EnvioFecha, ModoEnvio, Conversions.ToInteger(UsuarioCrea));
                Interaction.MsgBox("Pedido insertado con éxito");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al insertar el pedido: " + ex.Message);
            }
        }
        private void BtnEditarPedido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CbPedidoID.Text) || string.IsNullOrWhiteSpace(TxtPrecio.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtDescuento.Text) || string.IsNullOrWhiteSpace(txtGanancia.Text) || string.IsNullOrWhiteSpace(TxtDate.Text) || string.IsNullOrWhiteSpace(TxtDate2.Text) || string.IsNullOrWhiteSpace(CBMetodoEnvio.Text))
            {

                Interaction.MsgBox("Por favor, revise que todos los campos estén llenos");
                return;
            }

            string PedidoID = CbPedidoID.Text;
            decimal Precio = Convert.ToDecimal(TxtPrecio.Text);
            int Cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal Descuento = Convert.ToDecimal(txtDescuento.Text);
            decimal Ganancia = Convert.ToDecimal(txtGanancia.Text);
            var OrdenFecha = Convert.ToDateTime(TxtDate.Text);
            var EnvioFecha = Convert.ToDateTime(TxtDate2.Text);
            string ModoEnvio = CBMetodoEnvio.Text;
            string idUsuarioModifica = "1";

            Connection.EditarPedido(PedidoID, Precio, Cantidad, Descuento, Ganancia, OrdenFecha, EnvioFecha, ModoEnvio, Conversions.ToInteger(idUsuarioModifica));
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CbPedidoID.Text))
            {
                Interaction.MsgBox("Por favor, revise que todos los campos estén llenos");
                return;
            }

            string PedidoID = CbPedidoID.Text;

            Connection.EliminarPedido(PedidoID.ToString());
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            query = "select * from Pedido;";
            DataGridView1.DataSource = Connection.SelectQuery(query);


            query = "select id, ModoEnvio from Pedido";
            CBMetodoEnvio.DataSource = Connection.SelectQuery(query);
            CBMetodoEnvio.DisplayMember = "ModoEnvio";
            CBMetodoEnvio.ValueMember = "id";

            query = "select id, PedidoID from Pedido";
            CbPedidoID.DataSource = Connection.SelectQuery(query);
            CbPedidoID.DisplayMember = "PedidoID";
            CbPedidoID.ValueMember = "id";


        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}