<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class beli
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
        Me.bttambah = New System.Windows.Forms.Button
        Me.dgvdetailbeli = New System.Windows.Forms.DataGridView
        Me.btkeluar = New System.Windows.Forms.Button
        Me.btblankform = New System.Windows.Forms.Button
        Me.bthapus = New System.Windows.Forms.Button
        Me.btsimpan = New System.Windows.Forms.Button
        Me.txtnamasp = New System.Windows.Forms.TextBox
        Me.txtfaktur = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txttanggal = New System.Windows.Forms.DateTimePicker
        Me.txtkodesp = New System.Windows.Forms.ComboBox
        Me.txtkodebrg = New System.Windows.Forms.ComboBox
        Me.txtnamabrg = New System.Windows.Forms.TextBox
        Me.txthrgbeli = New System.Windows.Forms.TextBox
        Me.txtjumlah = New System.Windows.Forms.TextBox
        Me.txttotal = New System.Windows.Forms.TextBox
        CType(Me.dgvdetailbeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(139, 136)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 23)
        Me.bttambah.TabIndex = 33
        Me.bttambah.Text = "TAMBAH"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'dgvdetailbeli
        '
        Me.dgvdetailbeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetailbeli.Location = New System.Drawing.Point(12, 210)
        Me.dgvdetailbeli.Name = "dgvdetailbeli"
        Me.dgvdetailbeli.Size = New System.Drawing.Size(524, 150)
        Me.dgvdetailbeli.TabIndex = 32
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(437, 136)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 31
        Me.btkeluar.Text = "CLOSE"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btblankform
        '
        Me.btblankform.Location = New System.Drawing.Point(322, 136)
        Me.btblankform.Name = "btblankform"
        Me.btblankform.Size = New System.Drawing.Size(82, 23)
        Me.btblankform.TabIndex = 30
        Me.btblankform.Text = "BLANKFORM"
        Me.btblankform.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(232, 136)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 29
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(43, 136)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 28
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'txtnamasp
        '
        Me.txtnamasp.Location = New System.Drawing.Point(367, 101)
        Me.txtnamasp.Name = "txtnamasp"
        Me.txtnamasp.Size = New System.Drawing.Size(145, 20)
        Me.txtnamasp.TabIndex = 26
        '
        'txtfaktur
        '
        Me.txtfaktur.Location = New System.Drawing.Point(139, 75)
        Me.txtfaktur.Name = "txtfaktur"
        Me.txtfaktur.Size = New System.Drawing.Size(111, 20)
        Me.txtfaktur.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(275, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "NAMA SUPLIER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(275, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "KODE SUPLIER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "TANGGAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "NOMER FAKTUR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "FORM DATA PEMBELIAN"
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(139, 101)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(130, 20)
        Me.txttanggal.TabIndex = 34
        '
        'txtkodesp
        '
        Me.txtkodesp.FormattingEnabled = True
        Me.txtkodesp.Location = New System.Drawing.Point(367, 75)
        Me.txtkodesp.Name = "txtkodesp"
        Me.txtkodesp.Size = New System.Drawing.Size(75, 21)
        Me.txtkodesp.TabIndex = 35
        '
        'txtkodebrg
        '
        Me.txtkodebrg.FormattingEnabled = True
        Me.txtkodebrg.Location = New System.Drawing.Point(12, 174)
        Me.txtkodebrg.Name = "txtkodebrg"
        Me.txtkodebrg.Size = New System.Drawing.Size(75, 21)
        Me.txtkodebrg.TabIndex = 36
        '
        'txtnamabrg
        '
        Me.txtnamabrg.Location = New System.Drawing.Point(93, 174)
        Me.txtnamabrg.Name = "txtnamabrg"
        Me.txtnamabrg.Size = New System.Drawing.Size(111, 20)
        Me.txtnamabrg.TabIndex = 37
        '
        'txthrgbeli
        '
        Me.txthrgbeli.Location = New System.Drawing.Point(210, 174)
        Me.txthrgbeli.Name = "txthrgbeli"
        Me.txthrgbeli.Size = New System.Drawing.Size(111, 20)
        Me.txthrgbeli.TabIndex = 38
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(327, 174)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(111, 20)
        Me.txtjumlah.TabIndex = 39
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(444, 174)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(92, 20)
        Me.txttotal.TabIndex = 40
        '
        'beli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Toko.My.Resources.Resources.rm380_10
        Me.ClientSize = New System.Drawing.Size(552, 417)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txthrgbeli)
        Me.Controls.Add(Me.txtnamabrg)
        Me.Controls.Add(Me.txtkodebrg)
        Me.Controls.Add(Me.txtkodesp)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.dgvdetailbeli)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btblankform)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.txtnamasp)
        Me.Controls.Add(Me.txtfaktur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "beli"
        Me.Text = "beli"
        CType(Me.dgvdetailbeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents dgvdetailbeli As System.Windows.Forms.DataGridView
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btblankform As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents txtnamasp As System.Windows.Forms.TextBox
    Friend WithEvents txtfaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtkodesp As System.Windows.Forms.ComboBox
    Friend WithEvents txtkodebrg As System.Windows.Forms.ComboBox
    Friend WithEvents txtnamabrg As System.Windows.Forms.TextBox
    Friend WithEvents txthrgbeli As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
End Class
