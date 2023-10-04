Imports MySql.Data.MySqlClient
Public Class MenuUtama
    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        BELI.ShowDialog()
    End Sub
    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        jual.ShowDialog()
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBarangToolStripMenuItem.Click
        BARANG.ShowDialog()
    End Sub

    Private Sub DataCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataCustomerToolStripMenuItem.Click
        CUSTOMER.ShowDialog()
    End Sub

    Private Sub DataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataToolStripMenuItem.Click
        SUPLIER.ShowDialog()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click

    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CetakDataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakDataBarangToolStripMenuItem.Click
        ljual.ShowDialog()
    End Sub

    Private Sub CetakDataSuplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakDataSuplierToolStripMenuItem.Click
        LBELI.ShowDialog()
    End Sub
End Class