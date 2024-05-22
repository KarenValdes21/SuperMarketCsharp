using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SuperStoreKaren
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Pedidos : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            DataGridView1 = new DataGridView();
            txtCantidad = new TextBox();
            TxtPrecio = new TextBox();
            Label2 = new Label();
            Label1 = new Label();
            BtnEliminar = new Button();
            BtnEliminar.Click += new EventHandler(Button3_Click);
            BtnAgregarPedido = new Button();
            BtnAgregarPedido.Click += new EventHandler(BtnAgregarPedido_Click);
            BtnEditarPedido = new Button();
            BtnEditarPedido.Click += new EventHandler(BtnEditarPedido_Click);
            TxtDate = new DateTimePicker();
            TxtNombreProducto = new TextBox();
            Label3 = new Label();
            Label3.Click += new EventHandler(Label3_Click);
            Panel1 = new Panel();
            txtDescuento = new TextBox();
            txtGanancia = new TextBox();
            CBMetodoEnvio = new ComboBox();
            TxtDate2 = new DateTimePicker();
            CbPedidoID = new ComboBox();
            Label4 = new Label();
            Label5 = new Label();
            Label5.Click += new EventHandler(Label5_Click);
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(25, 93);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(481, 318);
            DataGridView1.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(630, 194);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(79, 20);
            txtCantidad.TabIndex = 22;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(545, 194);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(79, 20);
            TxtPrecio.TabIndex = 21;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(542, 132);
            Label2.Name = "Label2";
            Label2.Size = new Size(96, 13);
            Label2.TabIndex = 20;
            Label2.Text = "Nombre Producto  ";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(549, 93);
            Label1.Name = "Label1";
            Label1.Size = new Size(54, 13);
            Label1.TabIndex = 19;
            Label1.Text = "Pedido ID";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(692, 388);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 18;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarPedido
            // 
            BtnAgregarPedido.Location = new Point(530, 388);
            BtnAgregarPedido.Name = "BtnAgregarPedido";
            BtnAgregarPedido.Size = new Size(75, 23);
            BtnAgregarPedido.TabIndex = 17;
            BtnAgregarPedido.Text = "Agregar";
            BtnAgregarPedido.UseVisualStyleBackColor = true;
            // 
            // BtnEditarPedido
            // 
            BtnEditarPedido.Location = new Point(611, 388);
            BtnEditarPedido.Name = "BtnEditarPedido";
            BtnEditarPedido.Size = new Size(75, 23);
            BtnEditarPedido.TabIndex = 16;
            BtnEditarPedido.Text = "Editar";
            BtnEditarPedido.UseVisualStyleBackColor = true;
            // 
            // TxtDate
            // 
            TxtDate.Location = new Point(545, 312);
            TxtDate.Name = "TxtDate";
            TxtDate.Size = new Size(164, 20);
            TxtDate.TabIndex = 15;
            // 
            // TxtNombreProducto
            // 
            TxtNombreProducto.Location = new Point(545, 152);
            TxtNombreProducto.Name = "TxtNombreProducto";
            TxtNombreProducto.Size = new Size(164, 20);
            TxtNombreProducto.TabIndex = 14;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(22, 31);
            Label3.Name = "Label3";
            Label3.Size = new Size(45, 13);
            Label3.TabIndex = 23;
            Label3.Text = "Pedidos";
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Label3);
            Panel1.Location = new Point(0, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(796, 86);
            Panel1.TabIndex = 24;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(545, 236);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(79, 20);
            txtDescuento.TabIndex = 25;
            // 
            // txtGanancia
            // 
            txtGanancia.Location = new Point(630, 236);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new Size(79, 20);
            txtGanancia.TabIndex = 26;
            // 
            // CBMetodoEnvio
            // 
            CBMetodoEnvio.FormattingEnabled = true;
            CBMetodoEnvio.Location = new Point(545, 272);
            CBMetodoEnvio.Name = "CBMetodoEnvio";
            CBMetodoEnvio.Size = new Size(164, 21);
            CBMetodoEnvio.TabIndex = 28;
            // 
            // TxtDate2
            // 
            TxtDate2.Location = new Point(545, 352);
            TxtDate2.Name = "TxtDate2";
            TxtDate2.Size = new Size(164, 20);
            TxtDate2.TabIndex = 29;
            // 
            // CbPedidoID
            // 
            CbPedidoID.FormattingEnabled = true;
            CbPedidoID.Location = new Point(542, 108);
            CbPedidoID.Name = "CbPedidoID";
            CbPedidoID.Size = new Size(167, 21);
            CbPedidoID.TabIndex = 30;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(539, 178);
            Label4.Name = "Label4";
            Label4.Size = new Size(37, 13);
            Label4.TabIndex = 31;
            Label4.Text = "Precio";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(627, 178);
            Label5.Name = "Label5";
            Label5.Size = new Size(49, 13);
            Label5.TabIndex = 32;
            Label5.Text = "Cantidad";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(542, 217);
            Label6.Name = "Label6";
            Label6.Size = new Size(59, 13);
            Label6.TabIndex = 33;
            Label6.Text = "Descuento";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(634, 220);
            Label7.Name = "Label7";
            Label7.Size = new Size(53, 13);
            Label7.TabIndex = 34;
            Label7.Text = "Ganancia";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(540, 261);
            Label8.Name = "Label8";
            Label8.Size = new Size(73, 13);
            Label8.TabIndex = 35;
            Label8.Text = "Método Envio";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(540, 296);
            Label9.Name = "Label9";
            Label9.Size = new Size(69, 13);
            Label9.TabIndex = 36;
            Label9.Text = "Orden Fecha";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(542, 336);
            Label10.Name = "Label10";
            Label10.Size = new Size(67, 13);
            Label10.TabIndex = 37;
            Label10.Text = "Envio Fecha";
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(CbPedidoID);
            Controls.Add(TxtDate2);
            Controls.Add(CBMetodoEnvio);
            Controls.Add(txtGanancia);
            Controls.Add(txtDescuento);
            Controls.Add(Panel1);
            Controls.Add(txtCantidad);
            Controls.Add(TxtPrecio);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnAgregarPedido);
            Controls.Add(BtnEditarPedido);
            Controls.Add(TxtDate);
            Controls.Add(TxtNombreProducto);
            Controls.Add(DataGridView1);
            Name = "Pedidos";
            Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Pedidos_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal TextBox txtCantidad;
        internal TextBox TxtPrecio;
        internal Label Label2;
        internal Label Label1;
        internal Button BtnEliminar;
        internal Button BtnAgregarPedido;
        internal Button BtnEditarPedido;
        internal DateTimePicker TxtDate;
        internal TextBox TxtNombreProducto;
        internal Label Label3;
        internal Panel Panel1;
        internal TextBox txtDescuento;
        internal TextBox txtGanancia;
        internal ComboBox CBMetodoEnvio;
        internal DateTimePicker TxtDate2;
        internal ComboBox CbPedidoID;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal Label Label8;
        internal Label Label9;
        internal Label Label10;
    }
}