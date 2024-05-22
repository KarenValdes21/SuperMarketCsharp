Imports System.Data.SqlClient

Public Class Conexion

    Protected ccn As New SqlConnection
    Protected cmd As New SqlCommand

    Public Sub conectado()
        ccn = New SqlConnection("Data Source=LAPTOP-RRR3K3KV;Initial Catalog=SuperMarketPrueba2;Integrated security = true")
        ccn.Open()
    End Sub

End Class
