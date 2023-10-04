Imports MySql.Data.MySqlClient
Public Class beli
    Public SQLSTR As String
    Public conn As New MySqlConnection
    Public CMD As New MySqlCommand
    Public DA As New MySqlDataAdapter
    Public DT As New DataTable
    Public DS As New DataSet
    Public DR As MySqlDataReader
    Public KONEKSI As String
    Public LOKASI As String
    Public XFAKTUR As String
    Public XKODESP As String
    Public XKODEBRG As String
    Public XNAMABRG As String
    Public XNAMASP As String
    Public XHRGBELI As String
    Public XJUMLAH As String
    Public XTOTAL As String
    Sub exdr()
        CMD = New MySqlCommand(SQLSTR, conn)
        DR = CMD.ExecuteReader
    End Sub
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
    Private Sub beli_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        AUTONUMBER()

        Call konekdb()

        SQLSTR = "SELECT * FROM SUPLIER ORDER BY NAMASP"
        CMD = New MySqlCommand(SQLSTR, conn)
        DR = CMD.ExecuteReader
        txtkodesp.Items.Clear()
        While DR.Read
            txtkodesp.Items.Add(DR("KODESP") & " " & DR("NAMASP"))
        End While
        DR.Close()

        SQLSTR = "SELECT * FROM BARANG ORDER BY NAMABRG"
        CMD = New MySqlCommand(SQLSTR, conn)
        DR = CMD.ExecuteReader
        txtkodebrg.Items.Clear()
        While DR.Read
            txtkodebrg.Items.Add(DR("KODEBRG") & " " & DR("NAMABRG"))
        End While
        DR.Close()
    End Sub
    Sub KOSONG()
        AUTONUMBER()
        TXTFAKTUR.Text = ""
        TXTKODESP.Text = ""
        TXTNAMASP.Text = ""
        TXTKODEBRG.Text = ""
        TXTNAMABRG.Text = ""
        TXTHRGBELI.Text = 0
        TXTJUMLAH.Text = 0
        TXTTOTAL.Text = 0
        SQLSTR = "DELETE  FROM DETAILBELISEMU"
        Call konekdb()
        DA = New MySqlDataAdapter(SQLSTR, conn)
        DT.Clear()
        DA.Fill(DT)
        DGVDETAILBELI.DataSource = DT
        TXTFAKTUR.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM DETAILBELISEMU"
        DA = New MySqlDataAdapter(SQLSTR, conn)
        DT.Clear()
        DA.Fill(DT)
        DGVDETAILBELI.DataSource = DT
    End Sub
    Private Sub BELI_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        KOSONG()
        DGV()
        AUTONUMBER()
    End Sub
    Private Sub TXTKODESP_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TXTKODESP.SelectedValueChanged
        Call konekdb()
        XKODESP = Microsoft.VisualBasic.Left(txtkodesp.Text, 6)
        SQLSTR = "SELECT KODESP,NAMASP FROM SUPLIER WHERE KODESP='" & XKODESP & "'"
        CMD = New MySqlCommand(SQLSTR, conn)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNAMASP.Text = DR("NAMASP")
        End While
        DR.Close()
        TXTKODEBRG.Focus()
    End Sub
    Private Sub TXTKODEBRG_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TXTKODEBRG.SelectedValueChanged
        Call konekdb()
        XKODEBRG = Microsoft.VisualBasic.Left(txtkodebrg.Text, 6)
        SQLSTR = "SELECT NAMABRG,HRGBELI FROM BARANG WHERE KODEBRG='" & XKODEBRG & "'"
        CMD = New MySqlCommand(SQLSTR, conn)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNAMABRG.Text = DR("NAMABRG")
            txthrgbeli.Text = DR("HRGBELI")
            XNAMABRG = DR("NAMABRG")
            XHRGBELI = DR("HRGBELI")
        End While
        DR.Close()
        TXTJUMLAH.Focus()
    End Sub
    Private Sub TXTJUMLAH_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TXTJUMLAH.TextChanged
        If txtjumlah.Text = "" Then txtjumlah.Text = 0
        XTOTAL = XHRGBELI * txtjumlah.Text
        txttotal.Text = Format(XTOTAL)
    End Sub
    Private Sub BTSIMPAN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTSIMPAN.Click
        Call konekdb()
        Dim str As String
        XFAKTUR = Microsoft.VisualBasic.Left(txtfaktur.Text, 7)
        XFAKTUR = txtfaktur.Text
        str = "INSERT INTO BELI VALUES ('" & XFAKTUR & "','" & Format(txttanggal.Value, "yyyy-MM-dd") & "','" & XKODESP & "')"
        CMD = New MySqlCommand(str, conn)
        CMD.ExecuteNonQuery()
        'MsgBox("Data berhasil di simpan", vbInformation, "Simpan")

        SQLSTR = "INSERT INTO DETAILBELI (KODEBRG,HRGBELI,JUMLAH) SELECT KODEBRG,HRGBELI,JUMLAH FROM DETAILBELISEMU"
        CMD = New MySqlCommand(str, conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil di simpan", vbInformation, "Simpan")

        Call konekdb()
        SQLSTR = "UPDATE DETAILBELI SET FAKTUR = '" & XFAKTUR & "' WHERE DETAILBELI.FAKTUR Is Null"
        CMD = New MySqlCommand(str, conn)
        CMD.ExecuteNonQuery()

        KOSONG()
        AUTONUMBER()
    End Sub
    Private Sub BTKELUAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTKELUAR.Click
        Close()
    End Sub

    Private Sub BTBLANKFORM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTBLANKFORM.Click
        KOSONG()
    End Sub
    Private Sub BTTAMBAH_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTTAMBAH.Click
        XJUMLAH = txtjumlah.Text
        XKODEBRG = txtkodebrg.Text
        XHRGBELI = txthrgbeli.Text
        XTOTAL = txttotal.Text
        SQLSTR = "INSERT INTO DETAILBELISEMU VALUES('" & XKODEBRG & "','" & XNAMABRG & "','" & XHRGBELI & "','" & XJUMLAH & "','" & XTOTAL & "')"
        CMD = New MySqlCommand(SQLSTR, conn)
        CMD.ExecuteNonQuery()
        DGV()
        txtkodebrg.Text = ""
        txthrgbeli.Text = 0
        txtjumlah.Text = 0
        txttotal.Text = 0
        txtkodebrg.Focus()
    End Sub
    Sub AUTONUMBER()
        Call konekdb()

        'Dim no As String
        'Dim hitung As Double

        SQLSTR = "select * from BELI where FAKTUR in (select max(FAKTUR)from BELI)"
        exdr()
        DR.Read()

        If Not DR.HasRows Then
            TXTFAKTUR.Text = "FK" + "0001"
        Else
            TXTFAKTUR.Text = Val(Microsoft.VisualBasic.Mid(DR.Item("FAKTUR").ToString, 4, 3)) + 1
            If Len(TXTFAKTUR.Text) = 1 Then
                TXTFAKTUR.Text = "FK000" & TXTFAKTUR.Text & ""
            ElseIf Len(TXTFAKTUR.Text) = 2 Then
                TXTFAKTUR.Text = "FK00" & TXTFAKTUR.Text & ""
            ElseIf Len(TXTFAKTUR.Text) = 3 Then
                TXTFAKTUR.Text = "FK0" & TXTFAKTUR.Text & ""
            End If
        End If
        TXTKODESP.Focus()
    End Sub

End Class