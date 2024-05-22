Imports System.Data.SqlClient
Public Class Form1
    Dim query As String
    Shared cnx As New SqlConnection
    Public cmd As SqlClient.SqlCommand
    Public sqlread As SqlClient.SqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtcontra.Text <> String.Empty And txtusuario.Text <> String.Empty) Then
            Dim dtusuario As New DataTable
            Dim fu As New Fusuario
            dtusuario = fu.validar_usuario(txtusuario.Text, txtcontra.Text)

            If (dtusuario.Rows.Count <> 0) Then
                Dim userID As Integer = Convert.ToInt32(dtusuario.Rows(0)("id")) ' Asumiendo que la columna UserID contiene el ID del usuario
                MessageBox.Show("Bienvenido usuario " + txtusuario.Text, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                txtcontra.Clear()
                txtusuario.Clear()

                ' Guardar el ID del usuario en My.Settings
                My.Settings.CurrentUserID = userID
                My.Settings.Save()
                Form2.Show()
            Else
                MessageBox.Show("Error al entrar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error al entrar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Button1_ParentChanged(sender As Object, e As EventArgs) Handles Button1.ParentChanged
        Dim bth As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim r As Rectangle = Button1.ClientRectangle
        r.Inflate(0, 10)
        bth.AddEllipse(r)
        Button1.Region = New Region(bth)
    End Sub

    Private Sub Usuariotxt_ParentChanged(sender As Object, e As EventArgs) Handles txtusuario.ParentChanged
        Dim bth As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim r As Rectangle = Button1.ClientRectangle
        r.Inflate(0, 10)
        bth.AddEllipse(r)
        Button1.Region = New Region(bth)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnx.ConnectionString = "Data Source=LAPTOP-RRR3K3KV; Initial Catalog=SuperMarketPrueba2;Integrated Security=True"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Usuariotxt_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub contraseñatxt_TextChanged(sender As Object, e As EventArgs) Handles txtcontra.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()

    End Sub
End Class
