Imports MySql.Data.MySqlClient
Public Class CUSTOMER
    Public DTCS As New DataTable
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
        da = New MySqlDataAdapter("SELECT * FROM CUSTOMER", conn)
        ds = New DataSet
        da.Fill(ds, "CUSTOMER")
        dgvcS.DataSource = ds.Tables("CUSTOMER")
    End Sub
    Private Sub FORMCUSTOMER_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        DGV()
    End Sub
    Private Sub BTSIMPAN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btsimpan.Click
        Try
            If txtkodeCS.Text = "" Then
                MsgBox("Kode Customer tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txtnamacs.Text = "" Then
                MsgBox("Nama Customer tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                str = "SELECT * FROM CUSTOMER WHERE KODECS = '" & txtkodeCS.Text & "'"
                da = New MySqlDataAdapter(str, conn)
                DTCS.Clear()
                da.Fill(dtCS)
                dgvcS.DataSource = DTCS
                If Not DTCS.Rows.Count > 0 Then
                    str = "insert into CUSTOMER values ('" & txtkodeCS.Text & "','" & txtnamacs.Text & "','" & txtalamatcs.Text & "','" & txttelponcs.Text & "')"
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
            If txtkodeCS.Text = "" Then
                MsgBox("Data Belum Di Pilih", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txtnamacs.Text = "" Then
                MsgBox("Nama Customer tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                str = "SELECT * FROM CUSTOMER WHERE KODECS = '" & txtkodeCS.Text & "'"
                da = New MySqlDataAdapter(str, conn)
                DTCS.Clear()
                da.Fill(DTCS)
                dgvcS.DataSource = DTCS
                If DTCS.Rows.Count > 0 Then
                    str = "UPDATE CUSTOMER SET KODECS ='" & txtkodeCS.Text & "',NAMACS ='" & txtnamacs.Text & "',ALAMATCS ='" & txtalamatcs.Text & "',TELPONCS ='" & txttelponcs.Text & "' WHERE KODECS='" & txtkodeCS.Text & "'"
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
        Dim XKODECS As String
        XKODECS = txtkodeCS.Text
        X = MsgBox("DATA CUSTOMER " & txtnamacs.Text & " JADI DIHAPUS !", MsgBoxStyle.YesNo)
        If X = vbYes Then
            str = "DELETE FROM CUSTOMER WHERE KODECS = '" & XKODECS & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        End If
        DGV()
        BLANKFORM()
    End Sub

    Private Sub TXTKODECS_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtkodeCS.Leave
        str = "SELECT * FROM CUSTOMER WHERE KODECS = '" & txtkodeCS.Text & "'"
        da = New MySqlDataAdapter(str, conn)
        DTCS.Clear()
        da.Fill(DTCS)
        dgvcS.DataSource = DTCS
        If DTCS.Rows.Count > 0 Then
            txtnamacs.Text = dgvcS.Rows.Item(dgvcS.CurrentRow.Index).Cells(1).Value
            txtalamatcs.Text = dgvcS.Rows.Item(dgvcS.CurrentRow.Index).Cells(2).Value
            txttelponcs.Text = dgvcS.Rows.Item(dgvcS.CurrentRow.Index).Cells(3).Value
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        End If
        DGV()
    End Sub

    Private Sub DGVCS_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvcS.CellClick
        If dgvcS.RowCount > 0 Then
            Dim baris As Integer
            With dgvcS
                baris = .CurrentRow.Index
                txtkodeCS.Text = .Item(0, baris).Value
                txtnamacs.Text = .Item(1, baris).Value
                txtalamatcs.Text = .Item(2, baris).Value
                txttelponcs.Text = .Item(3, baris).Value
                txtkodeCS.Enabled = True
                txtkodeCS.Focus()
            End With
        End If
    End Sub
    Sub BLANKFORM()
        txtkodeCS.Text = ""
        txtnamacs.Text = ""
        txtalamatcs.Text = ""
        txttelponcs.Text = ""
    End Sub

    Private Sub BTBLANKFORM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btblankform.Click
        BLANKFORM()
    End Sub

    Private Sub BTKELUAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btkeluar.Click
        Close()
    End Sub

    Private Sub FORMCUSTOMER_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Leave
        conn.Close()
    End Sub
End Class