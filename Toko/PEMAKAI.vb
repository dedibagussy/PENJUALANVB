Imports MySql.Data.MySqlClient
Public Class FORMPEMAKAI
    Public XFOTO As String
    Public DT As New DataTable
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
    Private Sub FORMPEMAKAI_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
    Sub KOSONG()
        txtkodepk.Text = ""
        txtnamapk.Text = ""
        txtpassword.Text = ""
        cbjabatan.Text = ""
        pbfoto.BackgroundImage = Nothing
        txtkodepk.Focus()
    End Sub
    Sub DGV()
        da = New MySqlDataAdapter("SELECT * FROM PEMAKAI", conn)
        ds = New DataSet
        da.Fill(ds, "PEMAKAI")
        dgvpemakai.DataSource = ds.Tables("PEMAKAI")
    End Sub
    Private Sub FORMPEMAKAI_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        DGV()
    End Sub
    Private Sub PBFOTO_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbfoto.Click
        OpenFileDialog1.ShowDialog()
        pbfoto.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        XFOTO = OpenFileDialog1.FileName
    End Sub
    Private Sub BTSIMPAN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btsimpan.Click
        Try
            If txtkodepk.Text = "" Then
                MsgBox("Kode Pemakai tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txtnamapk.Text = "" Then
                MsgBox("Nama Pemakai tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                str = "SELECT * FROM PEMAKAI WHERE KODEPK = '" & txtkodepk.Text & "'"
                da = New MySqlDataAdapter(str, conn)
                DT.Clear()
                da.Fill(DT)
                dgvpemakai.DataSource = DT
                If Not DT.Rows.Count > 0 Then
                    str = "insert into PEMAKAI values ('" & txtkodepk.Text & "','" & txtnamapk.Text & "','" & cbjabatan.Text & "','" & txtpassword.Text & "','" & XFOTO & "')"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data berhasil di simpan", vbInformation, "Simpan")
                    Call DGV()
                    Call KOSONG()

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
            If txtkodepk.Text = "" Then
                MsgBox("Data Belum Di Pilih", vbExclamation, "Pesan")
                Exit Sub
            ElseIf txtnamapk.Text = "" Then
                MsgBox("Nama Pemakai tidak boleh kosong", vbExclamation, "Pesan")
                Exit Sub
            Else
                str = "SELECT * FROM PEMAKAI WHERE KODEPK = '" & txtkodepk.Text & "'"
                da = New MySqlDataAdapter(str, conn)
                DT.Clear()
                da.Fill(DT)
                dgvpemakai.DataSource = DT
                If DT.Rows.Count > 0 Then
                    str = "UPDATE PEMAKAI SET KODEPK ='" & txtkodepk.Text & "',NAMAPK ='" & txtnamapk.Text & "',JABATAN ='" & cbjabatan.Text & "',PASSWORD ='" & txtpassword.Text & "',FOTO ='" & XFOTO & "' WHERE KODEPK='" & txtkodepk.Text & "'"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data berhasil di Edit", MsgBoxStyle.Information, "Edit")
                    Call DGV()
                    Call KOSONG()

                    ''Else
                    ''MsgBox("Data Belum di Pilih", vbInformation, "Peringatan !")
                End If
            End If
        Catch ex As Exception
            MsgBox("Terdapat kesalahan" & ex.Message)
        End Try
    End Sub
    Private Sub TXTKODEPK_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtkodepk.Leave
        str = "SELECT * FROM PEMAKAI WHERE KODEPK = '" & txtkodepk.Text & "'"
        da = New MySqlDataAdapter(str, conn)
        DT.Clear()
        da.Fill(DT)
        dgvpemakai.DataSource = DT
        If DT.Rows.Count > 0 Then
            txtnamapk.Text = dgvpemakai.Rows.Item(dgvpemakai.CurrentRow.Index).Cells(1).Value
            cbjabatan.Text = dgvpemakai.Rows.Item(dgvpemakai.CurrentRow.Index).Cells(2).Value
            txtpassword.Text = dgvpemakai.Rows.Item(dgvpemakai.CurrentRow.Index).Cells(3).Value
            pbfoto.BackgroundImage = Image.FromFile(dgvpemakai.Rows.Item(dgvpemakai.CurrentRow.Index).Cells(4).Value)
            XFOTO = dgvpemakai.Rows.Item(dgvpemakai.CurrentRow.Index).Cells(4).Value
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        End If
        DGV()
    End Sub
    Private Sub BTHAPUS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bthapus.Click
        Dim X As String
        Dim XKODEPK As String
        XKODEPK = txtkodepk.Text
        X = MsgBox("DATA PEMAKAI" & txtnamapk.Text & " JADI DIHAPUS !", MsgBoxStyle.YesNo)
        If X = vbYes Then
            str = "DELETE FROM PEMAKAI WHERE KODEPK = '" & XKODEPK & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        End If
        DGV()
        KOSONG()
    End Sub

    Private Sub BTBLANKFORM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btblankform.Click
        KOSONG()
    End Sub

    Private Sub BTKELUAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btkeluar.Click
        Close()
    End Sub

    Private Sub FORMPEMAKAI_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Leave
        conn.Close()
    End Sub
End Class