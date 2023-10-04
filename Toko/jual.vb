Imports MySql.Data.MySqlClient
Public Class JUAL
    Public SQLSTR As String
    Public conn As New MySqlConnection
    Public CMD As New MySqlCommand
    Public DA As New MySqlDataAdapter
    Public DT As New DataTable
    Public DAJUAL As New MySqlDataAdapter
    Public DTJUAL As New DataTable
    Public DS As New DataSet
    Public DR As MySqlDataReader
    Public KONEKSI As String
    Public LOKASI As String
    Public XFAKTUR As String
    Public XNOTA As String
    Public XKODESP As String
    Public XKODECS As String
    Public XKODEBRG As String
    Public XNAMABRG As String
    Public XNAMASP As String
    Public XHRGBELI As String
    Public XHRGJUAL As String
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
    Sub AUTONUMBER()
        Call KonekDB()

        'Dim no As String
        'Dim hitung As Double

        SQLSTR = "select * from JUAL where NOTA in (select max(NOTA)from JUAL)"
        exdr()
        DR.Read()

        If Not DR.HasRows Then
            TXTNOTA.Text = "NT" + "0001"
        Else
            TXTNOTA.Text = Val(Microsoft.VisualBasic.Mid(DR.Item("NOTA").ToString, 4, 3)) + 1
            If Len(TXTNOTA.Text) = 1 Then
                TXTNOTA.Text = "NT000" & TXTNOTA.Text & ""
            ElseIf Len(TXTNOTA.Text) = 2 Then
                TXTNOTA.Text = "NT00" & TXTNOTA.Text & ""
            ElseIf Len(TXTNOTA.Text) = 3 Then
                TXTNOTA.Text = "NT0" & TXTNOTA.Text & ""
            End If
        End If
        TXTNOTA.Focus()
    End Sub
    Private Sub JUAL_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AUTONUMBER()

        Call konekdb()

        SQLSTR = "SELECT * FROM CUSTOMER ORDER BY NAMACS"
        CMD = New MySqlCommand(SQLSTR, conn)
        DR = CMD.ExecuteReader
        txtkodecs.Items.Clear()
        While DR.Read
            txtkodecs.Items.Add(DR("KODECS") & " " & DR("NAMACS"))
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
        txtnota.Text = ""
        TXTKODECS.Text = ""
        TXTNAMACS.Text = ""
        TXTKODEBRG.Text = ""
        TXTNAMABRG.Text = ""
        TXTHRGJUAL.Text = 0
        TXTJUMLAH.Text = 0
        txttotal.Text = 0
        Call konekdb()
        SQLSTR = "DELETE  FROM DETAILJUALSEMU"
        DA = New MySqlDataAdapter(SQLSTR, conn)
        DT.Clear()
        DA.Fill(DT)
        DGVDETAILJUAL.DataSource = DT
        txtkodecs.Focus()
    End Sub
    Sub DGV()
        Call konekdb()
        SQLSTR = "SELECT * FROM DETAILJUALSEMU"
        DA = New MySqlDataAdapter(SQLSTR, conn)
        DT.Clear()
        DA.Fill(DT)
        dgvdetailJUAL.DataSource = DT
    End Sub
    Private Sub FORMBELI_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        KOSONG()
        DGV()
        AUTONUMBER()
    End Sub
    Private Sub TXTKODECS_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TXTKODECS.SelectedValueChanged
        Call konekdb()
        XKODECS = Microsoft.VisualBasic.Left(txtkodecs.Text, 6)
        SQLSTR = "SELECT KODECS,NAMACS FROM CUSTOMER WHERE KODECS='" & XKODECS & "'"
        CMD = New MySqlCommand(SQLSTR, conn)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNAMACS.Text = DR("NAMACS")
        End While
        DR.Close()
        TXTKODEBRG.Focus()
    End Sub
    Private Sub TXTKODEBRG_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TXTKODEBRG.SelectedValueChanged
        Call konekdb()
        XKODEBRG = Microsoft.VisualBasic.Left(txtkodebrg.Text, 6)
        SQLSTR = "SELECT KODEBRG,NAMABRG,HRGJUAL FROM BARANG WHERE KODEBRG='" & XKODEBRG & "'"
        CMD = New MySqlCommand(SQLSTR, conn)
        DR = CMD.ExecuteReader
        While DR.Read
            txtnamabrg.Text = DR("NAMABRG")
            txthrgjual.Text = DR("HRGJUAL")
            XNAMABRG = DR("NAMABRG")
            XHRGJUAL = DR("HRGJUAL")
        End While
        DR.Close()
        txtjumlah.Focus()
    End Sub
    Private Sub txtjumlah_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtjumlah.TextChanged
        If txtjumlah.Text = "" Then txtjumlah.Text = 0
        XTOTAL = XHRGJUAL * txtjumlah.Text
        txttotal.Text = Format(XTOTAL)
    End Sub
    Private Sub BTTAMBAH_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTTAMBAH.Click
        XJUMLAH = txtjumlah.Text
        XNAMABRG = txtnamabrg.Text
        XHRGJUAL = txthrgjual.Text
        XTOTAL = txttotal.Text
        SQLSTR = "INSERT INTO DETAILJUALSEMU VALUES('" & XKODEBRG & "','" & XNAMABRG & "','" & XHRGJUAL & "','" & XJUMLAH & "','" & XTOTAL & "')"
        CMD = New MySqlCommand(SQLSTR, conn)
        CMD.ExecuteNonQuery()
        DGV()
        txtkodebrg.Text = ""
        txtnamabrg.Text = ""
        txthrgjual.Text = 0
        txtjumlah.Text = 0
        txttotal.Text = 0
        txtkodebrg.Focus()
    End Sub
    Private Sub BTSIMPAN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTSIMPAN.Click
        Call konekdb()
        Dim str As String
        XNOTA = txtnota.Text
        XNOTA = Microsoft.VisualBasic.Left(txtnota.Text, 7)
        str = "INSERT INTO JUAL VALUES ('" & XNOTA & "','" & Format(txttanggal.Value, "yyyy-MM-dd") & "','" & XKODECS & "')"
        CMD = New MySqlCommand(str, conn)
        CMD.ExecuteNonQuery()
        'MsgBox("Data berhasil di simpan", vbInformation, "Simpan")

        SQLSTR = "INSERT INTO DETAILJUAL (KODEBRG,HRGJUAL,JUMLAH) SELECT DETAILJUALSEMU.KODEBRG,DETAILJUALSEMU.HRGJUAL,DETAILJUALSEMU.JUMLAH FROM DETAILJUALSEMU"
        CMD = New MySqlCommand(SQLSTR, conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil di simpan", vbInformation, "Simpan")

        Call konekdb()
        SQLSTR = "UPDATE DETAILJUAL SET NOTA = '" & XNOTA & "' WHERE DETAILJUAL.NOTA Is Null"
        CMD = New MySqlCommand(SQLSTR, conn)
        CMD.ExecuteNonQuery()

        KOSONG()
        AUTONUMBER()
    End Sub
    Private Sub BTBLANKFORM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTBLANKFORM.Click
        KOSONG()
    End Sub
    Private Sub BTKELUAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTKELUAR.Click
        Close()
    End Sub
End Class