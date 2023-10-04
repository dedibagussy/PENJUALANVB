<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakDataSuplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PDBarang = New System.Drawing.Printing.PrintDocument
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem, Me.DataMasterToolStripMenuItem, Me.CetakToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(457, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.DataCustomerToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataCustomerToolStripMenuItem
        '
        Me.DataCustomerToolStripMenuItem.Name = "DataCustomerToolStripMenuItem"
        Me.DataCustomerToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DataCustomerToolStripMenuItem.Text = "Data Customer"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DataToolStripMenuItem.Text = "Data Suplier"
        '
        'CetakToolStripMenuItem
        '
        Me.CetakToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CetakDataBarangToolStripMenuItem, Me.CetakDataSuplierToolStripMenuItem})
        Me.CetakToolStripMenuItem.Name = "CetakToolStripMenuItem"
        Me.CetakToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CetakToolStripMenuItem.Text = "Laporan"
        '
        'CetakDataBarangToolStripMenuItem
        '
        Me.CetakDataBarangToolStripMenuItem.Name = "CetakDataBarangToolStripMenuItem"
        Me.CetakDataBarangToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CetakDataBarangToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'CetakDataSuplierToolStripMenuItem
        '
        Me.CetakDataSuplierToolStripMenuItem.Name = "CetakDataSuplierToolStripMenuItem"
        Me.CetakDataSuplierToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CetakDataSuplierToolStripMenuItem.Text = "Laporan Pembelian"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Toko.My.Resources.Resources.rm380_10
        Me.ClientSize = New System.Drawing.Size(457, 327)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakDataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakDataSuplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDBarang As System.Drawing.Printing.PrintDocument
End Class
