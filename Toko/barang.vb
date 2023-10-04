Imports MySQL.Data.MySQLClient
Public Class BARANG
    Public DTBRG As New DataTable
    Sub koneksi()
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
    Sub DGV()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM BARANG", conn)
        ds = New DataSet
        da.Fill(ds, "BARANG")
        dgvbrg.DataSource = ds.Tables("BARANG")
    End Sub

    Private Sub FORMDATABARANG_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        DGV()
    End Sub
    Private Sub BTSIMPAN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btsimpan.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into BARANG values ('" & txtkodebrg.Text & "','" & txtnamabrg.Text & "','" & txthrgbeli.Text & "','" & txthrgjual.Text & "','" & txtjmlawal.Text & "',0,0,0)"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("data berhasil disimpan")
        Catch ex As Exception
            MessageBox.Show("data gagal disimpan")

        End Try
    End Sub
    Private Sub BTEDIT_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTEDIT.Click
        Try
            If TXTKODEBRG.Text = "" Then
                MsgBox("Data Belum Di Pilih", vbExclamation, "Pesan")
                Exit Sub
            ElseIf TXTNAMABRG.Text = "" Then
                MsgBox("Nama Barang tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                str = "SELECT * FROM BARANG WHERE KODEBRG = '" & txtkodebrg.Text & "'"
                da = New MySqlDataAdapter(str, conn)
                DTBRG.Clear()
                da.Fill(DTBRG)
                DGVBRG.DataSource = DTBRG
                If DTBRG.Rows.Count > 0 Then
                    str = "UPDATE BARANG SET KODEBRG ='" & txtkodebrg.Text & "',NAMABRG ='" & txtnamabrg.Text & "',HRGBELI ='" & txthrgbeli.Text & "',HRGJUAL ='" & txthrgjual.Text & "',JMLAWAL ='" & txtjmlawal.Text & "' WHERE KODEBRG='" & txtkodebrg.Text & "'"
                    cmd = New MySqlCommand(str, conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil di Edit", MsgBoxStyle.Information, "Edit")
                    Call DGV()
                    Call BLANKFORM()

                    ''Else
                    ''MsgBox("Data Belum di Pilih", vbInformation, "Peringatan !")
                End If
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub
    Private Sub BTHAPUS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bthapus.Click
        Dim X As String
        Dim XKODEBRG As String
        XKODEBRG = txtkodebrg.Text
        X = MsgBox("DATA BARANG " & txtnamabrg.Text & " JADI DIHAPUS !", MsgBoxStyle.YesNo)
        If X = vbYes Then
            str = "DELETE FROM BARANG WHERE KODEBRG = '" & XKODEBRG & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        End If
        DGV()
        BLANKFORM()
    End Sub

    Private Sub TXTKODEBRG_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtkodebrg.Leave
        str = "SELECT * FROM BARANG WHERE KODEBRG = '" & txtkodebrg.Text & "'"
        da = New MySqlDataAdapter(str, conn)
        DTBRG.Clear()
        da.Fill(DTBRG)
        dgvbrg.DataSource = DTBRG
        If DTBRG.Rows.Count > 0 Then
            txtnamabrg.Text = dgvbrg.Rows.Item(dgvbrg.CurrentRow.Index).Cells(1).Value
            txthrgbeli.Text = dgvbrg.Rows.Item(dgvbrg.CurrentRow.Index).Cells(2).Value
            txthrgjual.Text = dgvbrg.Rows.Item(dgvbrg.CurrentRow.Index).Cells(3).Value
            txtjmlawal.Text = dgvbrg.Rows.Item(dgvbrg.CurrentRow.Index).Cells(4).Value
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        End If
        DGV()
    End Sub
    Private Sub DGVBRG_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvbrg.CellClick
        If dgvbrg.RowCount > 0 Then
            Dim baris As Integer
            With dgvbrg
                baris = .CurrentRow.Index
                txtkodebrg.Text = .Item(0, baris).Value
                txtnamabrg.Text = .Item(1, baris).Value
                txthrgbeli.Text = .Item(2, baris).Value
                txthrgjual.Text = .Item(3, baris).Value
                txtjmlawal.Text = .Item(4, baris).Value
                txtkodebrg.Enabled = True
                txtkodebrg.Focus()
            End With
        End If
    End Sub
    Sub BLANKFORM()
        txtkodebrg.Text = ""
        txtnamabrg.Text = ""
        txthrgbeli.Text = 0
        txthrgjual.Text = 0
        txtjmlawal.Text = 0
        ''TXTKODEBRG.GetPositionFromCharIndex()
    End Sub

    Private Sub BTBLANKFORM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btblankform.Click
        BLANKFORM()
    End Sub

    Private Sub BTKELUAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btkeluar.Click
        Close()
    End Sub

    Private Sub FORMDATABARANG_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Leave
        conn.Close()
    End Sub

    Private Sub FORMDATABARANG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
