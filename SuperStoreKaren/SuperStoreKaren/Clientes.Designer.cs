using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SuperStoreKaren
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Clientes : Form
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
            Agregar = new Button();
            Agregar.Click += new EventHandler(Button1_Click);
            TxtFiltro = new TextBox();
            DataGridView1 = new DataGridView();
            label1 = new Label();
            Label2 = new Label();
            BtnEditarCliente = new Button();
            BtnEditarCliente.Click += new EventHandler(BtnEditarCliente_Click);
            btnEliminar = new Button();
            btnEliminar.Click += new EventHandler(Button3_Click);
            TxtDate = new DateTimePicker();
            Panel1 = new Panel();
            CbIdRegion = new ComboBox();
            CbIdSegmento = new ComboBox();
            Label3 = new Label();
            Label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Agregar
            // 
            Agregar.Location = new Point(604, 303);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(75, 23);
            Agregar.TabIndex = 0;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            // 
            // TxtFiltro
            // 
            TxtFiltro.Location = new Point(635, 125);
            TxtFiltro.Name = "TxtFiltro";
            TxtFiltro.Size = new Size(100, 20);
            TxtFiltro.TabIndex = 1;
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(12, 80);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(556, 345);
            DataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(635, 106);
            label1.Name = "label1";
            label1.Size = new Size(50, 13);
            label1.TabIndex = 5;
            label1.Text = "ClienteID";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(39, 33);
            Label2.Name = "Label2";
            Label2.Size = new Size(39, 13);
            Label2.TabIndex = 6;
            Label2.Text = "Cliente";
            // 
            // BtnEditarCliente
            // 
            BtnEditarCliente.Location = new Point(685, 303);
            BtnEditarCliente.Name = "BtnEditarCliente";
            BtnEditarCliente.Size = new Size(75, 23);
            BtnEditarCliente.TabIndex = 7;
            BtnEditarCliente.Text = "Editar";
            BtnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(656, 346);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // TxtDate
            // 
            TxtDate.Location = new Point(587, 258);
            TxtDate.Name = "TxtDate";
            TxtDate.Size = new Size(200, 20);
            TxtDate.TabIndex = 9;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Label2);
            Panel1.Location = new Point(1, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(802, 72);
            Panel1.TabIndex = 10;
            // 
            // CbIdRegion
            // 
            CbIdRegion.FormattingEnabled = true;
            CbIdRegion.Location = new Point(625, 166);
            CbIdRegion.Name = "CbIdRegion";
            CbIdRegion.Size = new Size(121, 21);
            CbIdRegion.TabIndex = 11;
            // 
            // CbIdSegmento
            // 
            CbIdSegmento.FormattingEnabled = true;
            CbIdSegmento.Location = new Point(625, 204);
            CbIdSegmento.Name = "CbIdSegmento";
            CbIdSegmento.Size = new Size(121, 21);
            CbIdSegmento.TabIndex = 12;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(622, 150);
            Label3.Name = "Label3";
            Label3.Size = new Size(41, 13);
            Label3.TabIndex = 13;
            Label3.Text = "Region";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(622, 188);
            Label4.Name = "Label4";
            Label4.Size = new Size(55, 13);
            Label4.TabIndex = 14;
            Label4.Text = "Segmento";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(CbIdSegmento);
            Controls.Add(CbIdRegion);
            Controls.Add(Panel1);
            Controls.Add(TxtDate);
            Controls.Add(btnEliminar);
            Controls.Add(BtnEditarCliente);
            Controls.Add(label1);
            Controls.Add(DataGridView1);
            Controls.Add(TxtFiltro);
            Controls.Add(Agregar);
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Clientes_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button Agregar;
        internal TextBox TxtFiltro;
        internal DataGridView DataGridView1;
        internal Label label1;
        internal Label Label2;
        internal Button BtnEditarCliente;
        internal Button btnEliminar;
        internal DateTimePicker TxtDate;
        internal Panel Panel1;
        internal ComboBox CbIdRegion;
        internal ComboBox CbIdSegmento;
        internal Label Label3;
        internal Label Label4;
    }
}