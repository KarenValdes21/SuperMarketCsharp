Public Class Form2
    Private query As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ' Add any initialization after the InitializeComponent() call.
        ' Create a new instance of the Connection class

        query = "select id, Estado from Estado"
        cboEstado.DataSource = Connection.SelectQuery(query)
        cboEstado.DisplayMember = "Estado"
        cboEstado.ValueMember = "id"

    End Sub
    ' Al correr el progama es importante recordar que no todos los estados contienen clientes.
    ' Un ejemplo que si contiene clientes es Oregon
    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged
        query = "select id, Ciudad from [dbo].[Ciudad] where idEstado=" & cboEstado.SelectedValue
        CbCiudad.DataSource = Connection.SelectQuery(query)
        CbCiudad.DisplayMember = "Ciudad"
        CbCiudad.ValueMember = "id"
    End Sub

    Private Sub CbCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCiudad.SelectedIndexChanged


        If cboEstado.Text Is Nothing Then
            Exit Sub
        End If
        query = "select * from VW_DatosSuperMarket1 where [NombreCiudad]='" & CbCiudad.Text & "'"
        DataGridView1.DataSource = Connection.SelectQuery(query)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        'Panel2.Hide()

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs)
        'Panel2.Show()

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Producto.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Clientes.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Pedidos.Show()

    End Sub
End Class