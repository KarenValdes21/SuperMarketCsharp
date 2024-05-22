using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SuperStoreKaren
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Producto : Form
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
            TxtProductID = new TextBox();
            TxtNombreProducto = new TextBox();
            TxtDate = new DateTimePicker();
            BtnEditarProducto = new Button();
            BtnEditarProducto.Click += new EventHandler(BtnEditarProducto_Click_1);
            BtnAgregarProd = new Button();
            BtnAgregarProd.Click += new EventHandler(Button2_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            TxtCategoria = new TextBox();
            TxtSubcategoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(25, 104);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(481, 318);
            DataGridView1.TabIndex = 0;
            // 
            // TxtProductID
            // 
            TxtProductID.Location = new Point(577, 104);
            TxtProductID.Name = "TxtProductID";
            TxtProductID.Size = new Size(118, 20);
            TxtProductID.TabIndex = 1;
            // 
            // TxtNombreProducto
            // 
            TxtNombreProducto.Location = new Point(577, 160);
            TxtNombreProducto.Name = "TxtNombreProducto";
            TxtNombreProducto.Size = new Size(118, 20);
            TxtNombreProducto.TabIndex = 2;
            // 
            // TxtDate
            // 
            TxtDate.Location = new Point(560, 292);
            TxtDate.Name = "TxtDate";
            TxtDate.Size = new Size(200, 20);
            TxtDate.TabIndex = 4;
            // 
            // BtnEditarProducto
            // 
            BtnEditarProducto.Location = new Point(620, 363);
            BtnEditarProducto.Name = "BtnEditarProducto";
            BtnEditarProducto.Size = new Size(75, 23);
            BtnEditarProducto.TabIndex = 5;
            BtnEditarProducto.Text = "Editar";
            BtnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarProd
            // 
            BtnAgregarProd.Location = new Point(539, 363);
            BtnAgregarProd.Name = "BtnAgregarProd";
            BtnAgregarProd.Size = new Size(75, 23);
            BtnAgregarProd.TabIndex = 6;
            BtnAgregarProd.Text = "Agregar";
            BtnAgregarProd.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(701, 363);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 23);
            Button3.TabIndex = 7;
            Button3.Text = "Eliminar";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(575, 77);
            Label1.Name = "Label1";
            Label1.Size = new Size(64, 13);
            Label1.TabIndex = 8;
            Label1.Text = "Producto ID";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(575, 144);
            Label2.Name = "Label2";
            Label2.Size = new Size(96, 13);
            Label2.TabIndex = 9;
            Label2.Text = "Nombre Producto  ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(46, 38);
            Label3.Name = "Label3";
            Label3.Size = new Size(55, 13);
            Label3.TabIndex = 10;
            Label3.Text = "Productos";
            // 
            // TxtCategoria
            // 
            TxtCategoria.Location = new Point(578, 212);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(100, 20);
            TxtCategoria.TabIndex = 11;
            // 
            // TxtSubcategoria
            // 
            TxtSubcategoria.Location = new Point(578, 251);
            TxtSubcategoria.Name = "TxtSubcategoria";
            TxtSubcategoria.Size = new Size(100, 20);
            TxtSubcategoria.TabIndex = 12;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtSubcategoria);
            Controls.Add(TxtCategoria);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(Button3);
            Controls.Add(BtnAgregarProd);
            Controls.Add(BtnEditarProducto);
            Controls.Add(TxtDate);
            Controls.Add(TxtNombreProducto);
            Controls.Add(TxtProductID);
            Controls.Add(DataGridView1);
            Name = "Producto";
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(Producto_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal TextBox TxtProductID;
        internal TextBox TxtNombreProducto;
        internal DateTimePicker TxtDate;
        internal Button BtnEditarProducto;
        internal Button BtnAgregarProd;
        internal Button Button3;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal TextBox TxtCategoria;
        internal TextBox TxtSubcategoria;
    }
}