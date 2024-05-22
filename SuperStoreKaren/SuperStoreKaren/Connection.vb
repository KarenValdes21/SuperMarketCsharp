Imports System.Data.SqlClient

Public Class Connection
    Protected ccn As New SqlConnection
    Protected cmd As New SqlCommand


    Private Shared cnx As SqlConnection = New SqlConnection()
    Private Shared Sub Connect()
        Try
            cnx.ConnectionString = "Data Source=LAPTOP-RRR3K3KV; Initial Catalog=SuperMarketPrueba2;Integrated Security=True"
            Call cnx.Open()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub
    Private Shared Sub Disconect()
        Try
            If cnx.State = ConnectionState.Open Then
                Call cnx.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al desconectar de la base de datos: " & ex.Message)
        End Try
    End Sub
    ' Create a method to excecute a Selection query
    Public Shared Function SelectQuery(query As String) As DataTable
        Dim dt = New DataTable()
        Try
            Call Connect()
            Dim cmd = New SqlCommand(query, cnx)
            Dim da = New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        Finally
            Call Disconect()
        End Try
        Return dt
    End Function

    Public Shared Sub AgregarUsuario(Username As String, Contraseña As String, Us As Integer)
        Try
            Call Connect()
            Dim cmd = New SqlCommand("SP_AgregarUsuario", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username.ToString()
            cmd.Parameters.AddWithValue("@Contraseña", SqlDbType.VarChar).Value = Contraseña.ToString()
            cmd.Parameters.AddWithValue("@IdUsuarioCrea", Us)


            cmd.ExecuteNonQuery()

            MsgBox("Producto insertado con éxito")
        Catch ex As Exception
            MsgBox("Error al insertar el Producto " & ex.Message)
        Finally
            Call Disconect()
        End Try
    End Sub

    Public Shared Sub EliminarProducto(ProductID As String)
        Try
            Call Connect()
            Dim cmd = New SqlCommand("SP_EliminarProducto", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ProductoID", SqlDbType.VarChar).Value = ProductID.ToString()

            cmd.ExecuteNonQuery()

            MsgBox("Registro eliminado con éxito")
        Catch ex As Exception
            MsgBox("Error al eliminar el registro " & ex.Message)
        Finally
            Call Disconect()
        End Try
    End Sub

    Public Shared Sub AgregarProducto(ProductID As String, NombreProducto As String, Categoria As String, Subcategoria As String, UsuarioCrea As Integer)
        Try
            Call Connect()
            Dim cmd = New SqlCommand("SP_AgregarProducto", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ProductoID", SqlDbType.VarChar).Value = ProductID.ToString()
            cmd.Parameters.AddWithValue("@NombreProducto", SqlDbType.VarChar).Value = NombreProducto.ToString()
            cmd.Parameters.AddWithValue("@IdUsuarioCrea", UsuarioCrea)

            cmd.ExecuteNonQuery()

            MsgBox("Producto insertado con éxito")
        Catch ex As Exception
            MsgBox("Error al insertar el Producto " & ex.Message)
        Finally
            Call Disconect()
        End Try
    End Sub
    Public Shared Sub EditarProducto(ProductID As String, NombreProducto As String, UsuarioCrea As Integer, FechaModifica As Date)
        Try
            Call Connect()
            Dim cmd = New SqlCommand("SP_EditarProducto", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ProductoID", SqlDbType.VarChar).Value = ProductID.ToString()
            cmd.Parameters.AddWithValue("@NuevoNombreProducto", SqlDbType.VarChar).Value = NombreProducto.ToString()
            cmd.Parameters.AddWithValue("@NuevoIdUsuarioModifica", UsuarioCrea)
            cmd.Parameters.AddWithValue("@fechaModifica", FechaModifica)
            cmd.ExecuteNonQuery()


            MsgBox("Producto editado con éxito")
        Catch ex As Exception
            MsgBox("Error al editar el registro " & ex.Message)
        Finally
            Call Disconect()
        End Try
    End Sub

    'Public Shared Sub AgregarCliente(ClienteID As String, UsuarioCrea As Integer, IdRegion As String, IdSegmento As String)
    '    Try
    '      '      Call Connect()
    'Dim cmd = New SqlCommand("SPAgregarCliente", cnx)
    '       cmd.CommandType = CommandType.StoredProcedure
    '       cmd.Parameters.AddWithValue("@ClienteID", SqlDbType.VarChar).Value = ClienteID.ToString()
    '        cmd.Parameters.AddWithValue("@IdSegmento, ", SqlDbType.VarChar).Value = IdRegion.ToString()
    '        cmd.Parameters.AddWithValue("@IdRegion", SqlDbType.VarChar).Value = IdSegmento.ToString()
    '        cmd.Parameters.AddWithValue("@IdUsuarioCrea", UsuarioCrea)


    '        cmd.ExecuteNonQuery()

    '        MsgBox("Producto insertado con éxito")
    ''Catch ex As Exception
    ' MsgBox("Error al insertar el Producto " & ex.Message)
    '     Finally
    ' Call Disconect()
    'End Try
    ' End Sub '
    Public Function ObtenerRegiones() As DataTable
        Dim dtRegion As New DataTable
        Try
            Call Connect()
            Dim cmd = New SqlCommand("SELECT Id, Region FROM Region", cnx)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dtRegion)
        Catch ex As Exception
            MsgBox("Error al obtener regiones: " & ex.Message)
        Finally
            Call Disconect()
        End Try
        Return dtRegion
    End Function

    Public Function ObtenerSegmentos() As DataTable
        Dim dtSegmento As New DataTable
        Try
            Call Connect()
            Dim cmd = New SqlCommand("SELECT Id, Segmento FROM Segmento", cnx)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dtSegmento)
        Catch ex As Exception
            MsgBox("Error al obtener segmentos: " & ex.Message)
        Finally
            Call Disconect()
        End Try
        Return dtSegmento
    End Function

    Public Shared Sub AgregarCliente(ClienteID As String, UsuarioCrea As Integer, IdRegion As String, IdSegmento As String)
        Try
            Call Connect()
            Dim cmd = New SqlCommand("SPAgregarCliente", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ClienteID", ClienteID)
            cmd.Parameters.AddWithValue("@IdRegion", IdRegion)
            cmd.Parameters.AddWithValue("@IdSegmento", IdSegmento)
            cmd.Parameters.AddWithValue("@IdUsuarioCrea", UsuarioCrea)

            cmd.ExecuteNonQuery()

            MsgBox("Cliente insertado con éxito")
        Catch ex As Exception
            MsgBox("Error al insertar el cliente: " & ex.Message)
        Finally
            Call Disconect()
        End Try
    End Sub


    Public Shared Sub AgregarPedido(PedidoID As String, Precio As Decimal, Cantidad As Integer, Descuento As Decimal, Ganancia As Decimal, OrdenFecha As DateTime, EnvioFecha As DateTime, ModoEnvio As String, UsuarioCrea As Integer)
        Try
            Call Connect()
            Dim cmd = New SqlCommand("SP_AgregarPedido", cnx)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@PedidoID", SqlDbType.NVarChar).Value = PedidoID
            cmd.Parameters.AddWithValue("@Precio", SqlDbType.Decimal).Value = Precio
            cmd.Parameters.AddWithValue("@Cantidad", SqlDbType.Int).Value = Cantidad
            cmd.Parameters.AddWithValue("@Descuento", SqlDbType.Decimal).Value = Descuento
            cmd.Parameters.AddWithValue("@Ganancia", SqlDbType.Decimal).Value = Ganancia
            cmd.Parameters.AddWithValue("@OrdenFecha", SqlDbType.DateTime).Value = OrdenFecha
            cmd.Parameters.AddWithValue("@EnvioFecha", SqlDbType.DateTime).Value = EnvioFecha
            cmd.Parameters.AddWithValue("@ModoEnvio", SqlDbType.NVarChar).Value = ModoEnvio
            cmd.Parameters.AddWithValue("@IdUsuarioCrea", UsuarioCrea)
            cmd.ExecuteNonQuery()

            MsgBox("Pedido insertado con éxito")
        Catch ex As Exception
            MsgBox("Error al insertar el pedido " & ex.Message)
        Finally
            Call Disconect()
        End Try
    End Sub
    Public Shared Sub EditarCliente(ClienteID As String, idRegion As Integer, idSegmento As Integer, UsuarioModifica As Integer, FechaModifica As Date)
        Try
            Call Connect()
            Dim cmd As New SqlCommand("SP_EditarCliente", cnx)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ClienteID", ClienteID)
            cmd.Parameters.AddWithValue("@idRegion", idRegion)
            cmd.Parameters.AddWithValue("@idSegmento", idSegmento)
            cmd.Parameters.AddWithValue("@NuevoIdUsuarioModifica", UsuarioModifica)
            cmd.Parameters.AddWithValue("@fechaModifica", FechaModifica)
            cmd.ExecuteNonQuery()

            MsgBox("Producto editado con éxito")
        Catch ex As Exception
            MsgBox("Error al editar el registro " & ex.Message)
        Finally
            Call Disconect()
        End Try
    End Sub

    Public Shared Sub EditarPedido(PedidoID As String, Precio As Decimal, Cantidad As Integer, Descuento As Decimal, Ganancia As Decimal, OrdenFecha As DateTime, EnvioFecha As DateTime, ModoEnvio As String, idUsuarioModifica As Integer)
        Try
            Call Connect()
            Dim cmd = New SqlCommand("SP_EditarPedido", cnx)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@PedidoID", SqlDbType.VarChar).Value = PedidoID
            cmd.Parameters.AddWithValue("@Precio", SqlDbType.Decimal).Value = Precio
            cmd.Parameters.AddWithValue("@Cantidad", SqlDbType.Int).Value = Cantidad
            cmd.Parameters.AddWithValue("@Descuento", SqlDbType.Decimal).Value = Descuento
            cmd.Parameters.AddWithValue("@Ganancia", SqlDbType.Decimal).Value = Ganancia
            cmd.Parameters.AddWithValue("@OrdenFecha", SqlDbType.DateTime).Value = OrdenFecha
            cmd.Parameters.AddWithValue("@EnvioFecha", SqlDbType.DateTime).Value = EnvioFecha
            cmd.Parameters.AddWithValue("@ModoEnvio", SqlDbType.VarChar).Value = ModoEnvio
            cmd.Parameters.AddWithValue("@idUsuarioModifica", SqlDbType.Int).Value = idUsuarioModifica

            cmd.ExecuteNonQuery()

            MsgBox("Pedido editado con éxito")
        Catch ex As Exception
            MsgBox("Error al editar el pedido " & ex.Message)
        Finally
            Call Disconect()
        End Try
    End Sub

    Public Shared Sub EliminarPedido(PedidoID As String)
        Try
            Call Connect()
            Dim cmd = New SqlCommand("SP_EliminarPedido", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@PedidoID", SqlDbType.VarChar).Value = PedidoID.ToString()

            cmd.ExecuteNonQuery()

            MsgBox("Registro eliminado con éxito")
        Catch ex As Exception
            MsgBox("Error al eliminar el registro " & ex.Message)
        Finally
            Call Disconect()
        End Try
    End Sub

    Public Shared Sub EliminarCliente(ClienteID As String)
        Try
            Call Connect()
            Dim cmd As New SqlCommand("SP_EliminarCliente", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ClienteID", SqlDbType.VarChar).Value = ClienteID.ToString()

            cmd.ExecuteNonQuery()

            MsgBox("Cliente desactivado con éxito")
        Catch ex As Exception
            MsgBox("Error al desactivar el cliente: " & ex.Message)
        Finally
            Call Disconect()
        End Try
    End Sub






End Class