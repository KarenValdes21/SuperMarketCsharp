using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SuperStoreKaren
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form2 : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            cboEstado = new ComboBox();
            cboEstado.SelectedIndexChanged += new EventHandler(cboEstado_SelectedIndexChanged);
            CbCiudad = new ComboBox();
            CbCiudad.SelectedIndexChanged += new EventHandler(CbCiudad_SelectedIndexChanged);
            DataGridView1 = new DataGridView();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click_1);
            Panel1 = new Panel();
            PictureBox2 = new PictureBox();
            PictureBox2.Click += new EventHandler(PictureBox2_Click);
            PictureBox3 = new PictureBox();
            PictureBox3.Click += new EventHandler(PictureBox3_Click);
            Panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(239, 24);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 21);
            cboEstado.TabIndex = 0;
            // 
            // CbCiudad
            // 
            CbCiudad.FormattingEnabled = true;
            CbCiudad.Location = new Point(522, 24);
            CbCiudad.Name = "CbCiudad";
            CbCiudad.Size = new Size(121, 21);
            CbCiudad.TabIndex = 1;
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(163, 96);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(625, 327);
            DataGridView1.TabIndex = 2;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(0, 105);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(152, 54);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 3;
            PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(PictureBox3);
            Panel1.Controls.Add(PictureBox2);
            Panel1.Controls.Add(PictureBox1);
            Panel1.Location = new Point(2, 63);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(155, 385);
            Panel1.TabIndex = 4;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = (Image)resources.GetObject("PictureBox2.Image");
            PictureBox2.Location = new Point(0, 33);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(155, 54);
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.TabIndex = 4;
            PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            PictureBox3.Image = (Image)resources.GetObject("PictureBox3.Image");
            PictureBox3.Location = new Point(0, 176);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(155, 50);
            PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox3.TabIndex = 5;
            PictureBox3.TabStop = false;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(cboEstado);
            Panel2.Controls.Add(CbCiudad);
            Panel2.Location = new Point(2, 0);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(801, 69);
            Panel2.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(DataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            Panel2.ResumeLayout(false);
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);

        }

        internal ComboBox cboEstado;
        internal ComboBox CbCiudad;
        internal DataGridView DataGridView1;
        internal PictureBox PictureBox1;
        internal Panel Panel1;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox3;
        internal Panel Panel2;
    }
}