Imports MySql.Data.MySqlClient
Public Class ljual
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
        SQLSTR = "SELECT DETAILJUAL.NOTA,DETAILJUAL.KODEBRG, BARANG.NAMABRG, BARANG.HRGJUAL, DETAILJUAL.JUMLAH, DETAILJUAL.TOTAL FROM DETAILJUAL LEFT JOIN BARANG ON DETAILJUAL.KODEBRG = BARANG.KODEBRG"
        DAJUAL = New MySqlDataAdapter(SQLSTR, conn)
        DTJUAL.Clear()
        DAJUAL.Fill(DTJUAL)
        DataGridView1.DataSource = DTJUAL
    End Sub
    Private Sub ljual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGVJL()
    End Sub
End Class