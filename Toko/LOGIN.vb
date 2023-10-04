Imports MySql.Data.MySqlClient
Public Class LOGIN
    Public SQLSTR As String
    Public LOKASI As String
    Public XFOTO As String
    Public XKODEPK As String
    Public XPASSWORD As String
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
    Private Sub FORMLOGIN_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        koneksi()

        SQLSTR = "SELECT * FROM PEMAKAI "
        cmd = New MySqlCommand(SQLSTR, conn)
        rd = cmd.ExecuteReader
        CBKODEPK.Items.Clear()
        While rd.Read
            CBKODEPK.Items.Add(rd("KODEPK") & " " & rd("NAMAPK"))
        End While
        rd.Close()
    End Sub
    Sub KOSONG()
        CBKODEPK.Text = ""
        TXTNAMAPK.Text = ""
        TXTPASSWORD.Text = ""
        TXTJABATAN.Text = ""
        PBFOTO.BackgroundImage = Nothing
        CBKODEPK.Focus()
    End Sub
    Private Sub FORMLOGIN_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        KOSONG()
    End Sub
    Private Sub CBKODEPK_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CBKODEPK.SelectedValueChanged
        XKODEPK = Microsoft.VisualBasic.Left(CBKODEPK.Text, 7)
        SQLSTR = "SELECT * FROM PEMAKAI WHERE KODEPK='" & XKODEPK & "'"
        cmd = New MySqlCommand(SQLSTR, conn)
        rd = cmd.ExecuteReader
        While rd.Read
            txtnamapk.Text = rd("NAMAPK")
            TXTJABATAN.Text = rd("JABATAN")
            XPASSWORD = rd("PASSWORD")
            pbfoto.BackgroundImage = Image.FromFile(rd("FOTO"))
        End While
        rd.Close()
        TXTPASSWORD.Focus()
    End Sub
    Private Sub BTLOGIN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTLOGIN.Click
        If TXTPASSWORD.Text = XPASSWORD Then
            Select Case TXTJABATAN.Text
                Case "MANAGER"
                    MenuUtama.DataMasterToolStripMenuItem.Enabled = False
                    MENUUTAMA.TRANSAKSIToolStripMenuItem.Enabled = False
                    MENUUTAMA.CETAKToolStripMenuItem.Enabled = True
                    MenuUtama.LogOutToolStripMenuItem.Enabled = True
                Case "KEUANGAN"
                    MenuUtama.DataMasterToolStripMenuItem.Enabled = False
                    MENUUTAMA.TRANSAKSIToolStripMenuItem.Enabled = True
                    MENUUTAMA.CETAKToolStripMenuItem.Enabled = True
                    MenuUtama.LogOutToolStripMenuItem.Enabled = True
                Case "ADMIN"
                    MenuUtama.DataMasterToolStripMenuItem.Enabled = True
                    MENUUTAMA.TRANSAKSIToolStripMenuItem.Enabled = True
                    MENUUTAMA.CETAKToolStripMenuItem.Enabled = True
                    MenuUtama.LogOutToolStripMenuItem.Enabled = True
            End Select
            MENUUTAMA.ShowDialog()
        Else
            Dim x As String
            x = MsgBox("Password Salah", vbOKOnly)
            TXTPASSWORD.Text = ""
            TXTPASSWORD.Focus()
        End If
    End Sub
    Private Sub BTKELUAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTKELUAR.Click
        conn.Close()
        Close()
    End Sub
End Class