using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SuperStoreKaren
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtusuario = new TextBox();
            txtusuario.ParentChanged += new EventHandler(Usuariotxt_ParentChanged);
            txtusuario.TextChanged += new EventHandler(Usuariotxt_TextChanged);
            txtcontra = new TextBox();
            txtcontra.TextChanged += new EventHandler(contraseñatxt_TextChanged);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button1.ParentChanged += new EventHandler(Button1_ParentChanged);
            Label1 = new Label();
            Label2 = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(103, 126);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 20);
            txtusuario.TabIndex = 0;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(103, 237);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(100, 20);
            txtcontra.TabIndex = 1;
            // 
            // Button1
            // 
            Button1.Location = new Point(103, 321);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 2;
            Button1.Text = "Entrar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(130, 110);
            Label1.Name = "Label1";
            Label1.Size = new Size(55, 13);
            Label1.TabIndex = 3;
            Label1.Text = "Username";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(130, 208);
            Label2.Name = "Label2";
            Label2.Size = new Size(53, 13);
            Label2.TabIndex = 4;
            Label2.Text = "Password";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(267, 373);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(100, 50);
            PictureBox1.TabIndex = 5;
            PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(339, 435);
            Controls.Add(PictureBox1);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(Button1);
            Controls.Add(txtcontra);
            Controls.Add(txtusuario);
            Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.IndianRed;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Login_Load);
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox txtusuario;
        internal TextBox txtcontra;
        internal Button Button1;
        internal Label Label1;
        internal Label Label2;
        internal PictureBox PictureBox1;
    }
}