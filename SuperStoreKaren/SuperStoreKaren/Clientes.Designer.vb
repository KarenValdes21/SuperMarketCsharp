<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.Agregar = New System.Windows.Forms.Button()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEditarCliente = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.TxtDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CbIdRegion = New System.Windows.Forms.ComboBox()
        Me.CbIdSegmento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(604, 303)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 0
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(635, 125)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(100, 20)
        Me.TxtFiltro.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(556, 345)
        Me.DataGridView1.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(635, 106)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(50, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "ClienteID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cliente"
        '
        'BtnEditarCliente
        '
        Me.BtnEditarCliente.Location = New System.Drawing.Point(685, 303)
        Me.BtnEditarCliente.Name = "BtnEditarCliente"
        Me.BtnEditarCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditarCliente.TabIndex = 7
        Me.BtnEditarCliente.Text = "Editar"
        Me.BtnEditarCliente.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(656, 346)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'TxtDate
        '
        Me.TxtDate.Location = New System.Drawing.Point(587, 258)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(200, 20)
        Me.TxtDate.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 72)
        Me.Panel1.TabIndex = 10
        '
        'CbIdRegion
        '
        Me.CbIdRegion.FormattingEnabled = True
        Me.CbIdRegion.Location = New System.Drawing.Point(625, 166)
        Me.CbIdRegion.Name = "CbIdRegion"
        Me.CbIdRegion.Size = New System.Drawing.Size(121, 21)
        Me.CbIdRegion.TabIndex = 11
        '
        'CbIdSegmento
        '
        Me.CbIdSegmento.FormattingEnabled = True
        Me.CbIdSegmento.Location = New System.Drawing.Point(625, 204)
        Me.CbIdSegmento.Name = "CbIdSegmento"
        Me.CbIdSegmento.Size = New System.Drawing.Size(121, 21)
        Me.CbIdSegmento.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(622, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Region"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(622, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Segmento"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbIdSegmento)
        Me.Controls.Add(Me.CbIdRegion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.BtnEditarCliente)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.Agregar)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Agregar As Button
    Friend WithEvents TxtFiltro As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEditarCliente As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents TxtDate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CbIdRegion As ComboBox
    Friend WithEvents CbIdSegmento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
