Public Class Pedidos
    Private query As String

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub BtnAgregarPedido_Click(sender As Object, e As EventArgs) Handles BtnAgregarPedido.Click
        ' Validar que todos los campos necesarios estén llenos
        If String.IsNullOrWhiteSpace(CbPedidoID.Text) OrElse
       String.IsNullOrWhiteSpace(TxtPrecio.Text) OrElse
       String.IsNullOrWhiteSpace(txtCantidad.Text) OrElse
       String.IsNullOrWhiteSpace(txtDescuento.Text) OrElse
       String.IsNullOrWhiteSpace(txtGanancia.Text) OrElse
       String.IsNullOrWhiteSpace(TxtDate.Text) OrElse
       String.IsNullOrWhiteSpace(TxtDate2.Text) OrElse
       String.IsNullOrWhiteSpace(CBMetodoEnvio.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        ' Obtener los valores de los campos
        Dim PedidoID = CbPedidoID.Text
        Dim Precio = TxtPrecio.Text
        Dim Cantidad = txtCantidad.Text
        Dim Descuento = txtDescuento.Text
        Dim Ganancia = txtGanancia.Text
        Dim OrdenFecha = Convert.ToDateTime(TxtDate.Text)
        Dim EnvioFecha = Convert.ToDateTime(TxtDate2.Text)
        Dim ModoEnvio = CBMetodoEnvio.Text
        Dim UsuarioCrea = "1"

        ' Validar y convertir los valores numéricos y de fecha
        If Not Decimal.TryParse(TxtPrecio.Text, Precio) Then
            MsgBox("Por favor, ingrese un precio válido")
            Return
        End If

        If Not Integer.TryParse(txtCantidad.Text, Cantidad) Then
            MsgBox("Por favor, ingrese una cantidad válida")
            Return
        End If

        If Not Decimal.TryParse(txtDescuento.Text, Descuento) Then
            MsgBox("Por favor, ingrese un descuento válido")
            Return
        End If

        If Not Decimal.TryParse(txtGanancia.Text, Ganancia) Then
            MsgBox("Por favor, ingrese una ganancia válida")
            Return
        End If

        If Not DateTime.TryParse(TxtDate.Text, OrdenFecha) Then
            MsgBox("Por favor, ingrese una fecha de orden válida")
            Return
        End If

        If Not DateTime.TryParse(TxtDate2.Text, EnvioFecha) Then
            MsgBox("Por favor, ingrese una fecha de envío válida")
            Return
        End If

        ' Llamar al método para agregar el pedido
        Try
            Connection.AgregarPedido(PedidoID, Precio, Cantidad, Descuento, Ganancia, OrdenFecha, EnvioFecha, ModoEnvio, UsuarioCrea)
            MsgBox("Pedido insertado con éxito")
        Catch ex As Exception
            MsgBox("Error al insertar el pedido: " & ex.Message)
        End Try
    End Sub
    Private Sub BtnEditarPedido_Click(sender As Object, e As EventArgs) Handles BtnEditarPedido.Click
        If String.IsNullOrWhiteSpace(CbPedidoID.Text) OrElse
       String.IsNullOrWhiteSpace(TxtPrecio.Text) OrElse
       String.IsNullOrWhiteSpace(txtCantidad.Text) OrElse
       String.IsNullOrWhiteSpace(txtDescuento.Text) OrElse
       String.IsNullOrWhiteSpace(txtGanancia.Text) OrElse
       String.IsNullOrWhiteSpace(TxtDate.Text) OrElse
       String.IsNullOrWhiteSpace(TxtDate2.Text) OrElse
       String.IsNullOrWhiteSpace(CBMetodoEnvio.Text) Then

            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim PedidoID = CbPedidoID.Text
        Dim Precio = Convert.ToDecimal(TxtPrecio.Text)
        Dim Cantidad = Convert.ToInt32(txtCantidad.Text)
        Dim Descuento = Convert.ToDecimal(txtDescuento.Text)
        Dim Ganancia = Convert.ToDecimal(txtGanancia.Text)
        Dim OrdenFecha = Convert.ToDateTime(TxtDate.Text)
        Dim EnvioFecha = Convert.ToDateTime(TxtDate2.Text)
        Dim ModoEnvio = CBMetodoEnvio.Text
        Dim idUsuarioModifica = "1"

        Connection.EditarPedido(PedidoID, Precio, Cantidad, Descuento, Ganancia, OrdenFecha, EnvioFecha, ModoEnvio, idUsuarioModifica)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If String.IsNullOrWhiteSpace(CbPedidoID.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim PedidoID = CbPedidoID.Text

        Connection.EliminarPedido(PedidoID.ToString())
    End Sub

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from Pedido;"
        DataGridView1.DataSource = Connection.SelectQuery(query)


        query = "select id, ModoEnvio from Pedido"
        CBMetodoEnvio.DataSource = Connection.SelectQuery(query)
        CBMetodoEnvio.DisplayMember = "ModoEnvio"
        CBMetodoEnvio.ValueMember = "id"

        query = "select id, PedidoID from Pedido"
        CbPedidoID.DataSource = Connection.SelectQuery(query)
        CbPedidoID.DisplayMember = "PedidoID"
        CbPedidoID.ValueMember = "id"


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class