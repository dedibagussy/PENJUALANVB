Imports MySql.Data.MySqlClient
Public Class SUPLIER
    Public DTSP As New DataTable
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
        da = New MySqlDataAdapter("SELECT * FROM SUPLIER", conn)
        ds = New DataSet
        da.Fill(ds, "SUPLIER")
        dgvsp.DataSource = ds.Tables("SUPLIER")
    End Sub
    Private Sub FORMSUPLIER_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        DGV()
    End Sub
    Private Sub BTSIMPAN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btsimpan.Click
        Try
            If TXTKODESP.Text = "" Then
                MsgBox("Kode Suplier tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf TXTNAMASP.Text = "" Then
                MsgBox("Nama Suplier tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                str = "SELECT * FROM SUPLIER WHERE KODESP = '" & txtkodesp.Text & "'"
                da = New MySqlDataAdapter(str, conn)
                DTSP.Clear()
                da.Fill(dtsp)
                DGVSP.DataSource = DTSP
                If Not DTSP.Rows.Count > 0 Then
                    str = "insert into SUPLIER values ('" & txtkodesp.Text & "','" & txtnamasp.Text & "','" & txtalamatsp.Text & "','" & TXTTELPONSP.Text & "')"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data berhasil di simpan", vbInformation, "Simpan")
                    Call DGV()
                    Call BLANKFORM()

                Else
                    MsgBox("Data Sudah Ada", vbExclamation, "Peringatan !")
                End If
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub
    Private Sub BTEDIT_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTEDIT.Click
        Try
            If TXTKODESP.Text = "" Then
                MsgBox("Data Belum Di Pilih", vbExclamation, "Pesan")
                Exit Sub
            ElseIf TXTNAMASP.Text = "" Then
                MsgBox("Nama Barang tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                str = "SELECT * FROM SUPLIER WHERE KODESP = '" & txtkodesp.Text & "'"
                da = New MySqlDataAdapter(str, conn)
                DTSP.Clear()
                da.Fill(dtsp)
                DGVSP.DataSource = DTSP
                If DTSP.Rows.Count > 0 Then
                    str = "UPDATE SUPLIER SET KODESP ='" & txtkodesp.Text & "',NAMASP ='" & txtnamasp.Text & "',ALAMATSP ='" & txtalamatsp.Text & "',TELPONSP ='" & txttelponsp.Text & "' WHERE KODESP='" & txtkodesp.Text & "'"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
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
        Dim XKODESP As String
        XKODESP = TXTKODESP.Text
        X = MsgBox("DATA SUPLIER " & TXTNAMASP.Text & " JADI DIHAPUS !", MsgBoxStyle.YesNo)
        If X = vbYes Then
            str = "DELETE FROM SUPLIER WHERE KODESP = '" & XKODESP & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        End If
        DGV()
        BLANKFORM()
    End Sub

    Private Sub TXTKODESP_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TXTKODESP.Leave
        str = "SELECT * FROM SUPLIER WHERE KODESP = '" & txtkodesp.Text & "'"
        da = New MySqlDataAdapter(str, conn)
        DTSP.Clear()
        da.Fill(dtsp)
        DGVSP.DataSource = DTSP
        If DTSP.Rows.Count > 0 Then
            TXTNAMASP.Text = DGVSP.Rows.Item(DGVSP.CurrentRow.Index).Cells(1).Value
            TXTALAMATSP.Text = DGVSP.Rows.Item(DGVSP.CurrentRow.Index).Cells(2).Value
            txttelponsp.Text = DGVSP.Rows.Item(DGVSP.CurrentRow.Index).Cells(3).Value
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        End If
        DGV()
    End Sub

    Private Sub DGVSP_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DGVSP.CellClick
        If DGVSP.RowCount > 0 Then
            Dim baris As Integer
            With DGVSP
                baris = .CurrentRow.Index
                TXTKODESP.Text = .Item(0, baris).Value
                TXTNAMASP.Text = .Item(1, baris).Value
                TXTALAMATSP.Text = .Item(2, baris).Value
                txttelponsp.Text = .Item(3, baris).Value
                TXTKODESP.Enabled = True
                TXTKODESP.Focus()
            End With
        End If
    End Sub
    Sub BLANKFORM()
        TXTKODESP.Text = ""
        TXTNAMASP.Text = ""
        TXTALAMATSP.Text = ""
        txttelponsp.Text = ""
    End Sub

    Private Sub BTBLANKFORM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btblankform.Click
        BLANKFORM()
    End Sub

    Private Sub BTKELUAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btkeluar.Click
        Close()
    End Sub

    Private Sub FORMSUPLIER_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Leave
        conn.Close()
    End Sub
End Class