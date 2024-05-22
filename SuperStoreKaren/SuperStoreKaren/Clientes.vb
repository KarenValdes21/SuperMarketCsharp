Imports System.Data.SqlClient

Public Class Clientes
    Private query As String
    Private adapter As String
    Private conexion As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        If String.IsNullOrWhiteSpace(TxtFiltro.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim ClienteID As String = TxtFiltro.Text
        Dim IdSegmento As String = CbIdSegmento.SelectedValue.ToString()
        Dim IdRegion As String = CbIdRegion.SelectedValue.ToString()

        ' Obtener el ID del usuario que ha iniciado sesión desde My.Settings
        Dim UsuarioCrea As Integer = My.Settings.CurrentUserID

        ' Verificar que el ID del usuario es válido
        If UsuarioCrea <= 0 Then
            MsgBox("Error: ID de usuario no válido. Por favor, vuelva a iniciar sesión.")
            Return
        End If

        Connection.AgregarCliente(ClienteID, UsuarioCrea, IdRegion, IdSegmento)
    End Sub

    Private Sub BtnEditarCliente_Click(sender As Object, e As EventArgs) Handles BtnEditarCliente.Click
        If String.IsNullOrWhiteSpace(TxtFiltro.Text) Then
            MsgBox("Por favor, asegúrate de completar todos los campos.")
            Return
        End If

        Dim ClienteID = TxtFiltro.Text
        Dim idRegion = CbIdRegion.SelectedValue ' Suponiendo que CbIdRegion es un ComboBox que contiene el ID de la región seleccionada
        Dim idSegmento = CbIdSegmento.SelectedValue ' Suponiendo que CbIdSegmento es un ComboBox que contiene el ID del segmento seleccionado
        Dim UsuarioModifica = 1 ' Suponiendo que UsuarioModifica es el ID del usuario que realiza la edición
        Dim fechaMod = Convert.ToDateTime(TxtDate.Text)

        Connection.EditarCliente(ClienteID, idRegion, idSegmento, UsuarioModifica, fechaMod)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(TxtFiltro.Text) Then
            MsgBox("Por favor, revisa que todos los campos estén llenos")
            Return
        End If

        Dim ClienteID = TxtFiltro.Text

        Connection.EliminarCliente(ClienteID)
    End Sub


    'query = "select * from cliente"
    '  DataGridView1.DataSource = Connection.SelectQuery(query)

    '  query = "select distinct Region from Region"
    '  CbIdRegion.DataSource = Connection.SelectQuery(query)
    '  CbIdRegion.DisplayMember = "Region"

    ' query = "select id, segmento from segmento"
    '  CbIdSegmento.DataSource = Connection.SelectQuery(query)
    '  CbIdSegmento.DisplayMember = "segmento"
    '   CbIdSegmento.ValueMember = "id"
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define la cadena de conexión
        Dim connectionString As String = "Data Source=LAPTOP-RRR3K3KV; Initial Catalog=SuperMarketPrueba2;Integrated Security=True"

        Try
            ' Asumiendo que Connection es un objeto que maneja la conexión a la base de datos
            query = "select * from cliente"
            DataGridView1.DataSource = Connection.SelectQuery(query)

            ' Cargar regiones
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand("SELECT Id, Region FROM Region", conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        Dim dtRegion As New DataTable()
                        dtRegion.Load(reader)

                        CbIdRegion.DisplayMember = "Region"
                        CbIdRegion.ValueMember = "Id"
                        CbIdRegion.DataSource = dtRegion
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al cargar las regiones: " & ex.Message)
        End Try

        Try
            ' Cargar segmentos
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand("SELECT Id, Segmento FROM Segmento", conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        Dim dtSegmento As New DataTable()
                        dtSegmento.Load(reader)

                        CbIdSegmento.DisplayMember = "Segmento"
                        CbIdSegmento.ValueMember = "Id"
                        CbIdSegmento.DataSource = dtSegmento
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al cargar los segmentos: " & ex.Message)
        End Try
    End Sub


End Class