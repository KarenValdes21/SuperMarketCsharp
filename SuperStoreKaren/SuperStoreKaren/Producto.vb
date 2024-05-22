
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
Public Class Producto
    Private query As String

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub BtnEditarProducto_Click_1(sender As Object, e As EventArgs) Handles BtnEditarProducto.Click
        If String.IsNullOrWhiteSpace(TxtProductID.Text) OrElse String.IsNullOrWhiteSpace(TxtNombreProducto.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim ProductID = TxtProductID.Text
        Dim NombreProducto = TxtNombreProducto.Text
        Dim categoria = TxtCategoria.Text
        Dim subcategoria = TxtSubcategoria.Text
        Dim UsuarioCrea = "1"
        Dim fechaMod = Convert.ToDateTime(TxtDate.Text)

        Connection.EditarProducto(ProductID, NombreProducto, UsuarioCrea, fechaMod)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Public Sub LoadD()
        Try
            query = "select * from producto"
            DataGridView1.DataSource = Connection.SelectQuery(query)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(TxtProductID.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim ProductID = TxtProductID.Text

        Connection.EliminarProducto(ProductID.ToString())
    End Sub
    Public SelectedProduct As String
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

        query = "SELECT id, [NombreProducto] FROM Producto WHERE NombreProducto = '" & SelectedProduct.Replace("'", "''") & "'"
        DataGridView1.DataSource = Connection.SelectQuery(query)
    End Sub

    Private Sub BtnEditarProducto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
        TxtProductID.Clear()
        TxtNombreProducto.Clear()


    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from producto;"
        DataGridView1.DataSource = Connection.SelectQuery(query)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAgregarProd.Click
        If String.IsNullOrWhiteSpace(TxtProductID.Text) OrElse String.IsNullOrWhiteSpace(TxtNombreProducto.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim ProductID = TxtProductID.Text
        Dim NombreProducto = TxtNombreProducto.Text
        Dim categoria = TxtCategoria.Text
        Dim subcategoria = TxtSubcategoria.Text
        Dim UsuarioCrea = "1"


        Connection.AgregarProducto(ProductID, NombreProducto, categoria, subcategoria, UsuarioCrea)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrWhiteSpace(TxtProductID.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim ProductID = TxtProductID.Text

        Connection.EliminarProducto(ProductID.ToString())
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class