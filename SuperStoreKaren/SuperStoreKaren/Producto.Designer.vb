<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TxtProductID = New System.Windows.Forms.TextBox()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.TxtDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnEditarProducto = New System.Windows.Forms.Button()
        Me.BtnAgregarProd = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.TxtSubcategoria = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(481, 318)
        Me.DataGridView1.TabIndex = 0
        '
        'TxtProductID
        '
        Me.TxtProductID.Location = New System.Drawing.Point(577, 104)
        Me.TxtProductID.Name = "TxtProductID"
        Me.TxtProductID.Size = New System.Drawing.Size(118, 20)
        Me.TxtProductID.TabIndex = 1
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Location = New System.Drawing.Point(577, 160)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(118, 20)
        Me.TxtNombreProducto.TabIndex = 2
        '
        'TxtDate
        '
        Me.TxtDate.Location = New System.Drawing.Point(560, 292)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(200, 20)
        Me.TxtDate.TabIndex = 4
        '
        'BtnEditarProducto
        '
        Me.BtnEditarProducto.Location = New System.Drawing.Point(620, 363)
        Me.BtnEditarProducto.Name = "BtnEditarProducto"
        Me.BtnEditarProducto.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditarProducto.TabIndex = 5
        Me.BtnEditarProducto.Text = "Editar"
        Me.BtnEditarProducto.UseVisualStyleBackColor = True
        '
        'BtnAgregarProd
        '
        Me.BtnAgregarProd.Location = New System.Drawing.Point(539, 363)
        Me.BtnAgregarProd.Name = "BtnAgregarProd"
        Me.BtnAgregarProd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarProd.TabIndex = 6
        Me.BtnAgregarProd.Text = "Agregar"
        Me.BtnAgregarProd.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(701, 363)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(575, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Producto ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(575, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre Producto  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Productos"
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Location = New System.Drawing.Point(578, 212)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(100, 20)
        Me.TxtCategoria.TabIndex = 11
        '
        'TxtSubcategoria
        '
        Me.TxtSubcategoria.Location = New System.Drawing.Point(578, 251)
        Me.TxtSubcategoria.Name = "TxtSubcategoria"
        Me.TxtSubcategoria.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubcategoria.TabIndex = 12
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtSubcategoria)
        Me.Controls.Add(Me.TxtCategoria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnAgregarProd)
        Me.Controls.Add(Me.BtnEditarProducto)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.TxtNombreProducto)
        Me.Controls.Add(Me.TxtProductID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Producto"
        Me.Text = "Producto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtProductID As TextBox
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents TxtDate As DateTimePicker
    Friend WithEvents BtnEditarProducto As Button
    Friend WithEvents BtnAgregarProd As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCategoria As TextBox
    Friend WithEvents TxtSubcategoria As TextBox
End Class
