Imports MySql.Data.MySqlClient
Public Class LBELI
    Public SQLSTR As String
    Public conn As New MySqlConnection
    Public CMD As New MySqlCommand
    Public DA As New MySqlDataAdapter
    Public DT As New DataTable
    Public DAJUAL As New MySqlDataAdapter
    Public DTJUAL As New DataTable
    Public DS As New DataSet
    Public DR As MySqlDataReader
    Sub konekdb()
        Try
            Dim str As String = "server=localhost;user=root;password=;database=db_penjualan;allow user variables=true"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub DGVJL()
        Call konekdb()
        SQLSTR = "SELECT DETAILBELI.KODEBRG, BARANG.NAMABRG, DETAILBELI.HRGBELI, DETAILBELI.JUMLAH, FROM DETAILBELI LEFT JOIN BARANG ON DETAILBELI.KODEBRG = BARANG.KODEBRG"
        DAJUAL = New MySqlDataAdapter(SQLSTR, conn)
        DTJUAL.Clear()
        DAJUAL.Fill(DTJUAL)
        DataGridView1.DataSource = DTJUAL
    End Sub
    Private Sub ljual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGVJL()
    End Sub
End Class