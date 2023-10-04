<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JUAL
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
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.txtjumlah = New System.Windows.Forms.TextBox
        Me.txthrgjual = New System.Windows.Forms.TextBox
        Me.txtnamabrg = New System.Windows.Forms.TextBox
        Me.txtkodebrg = New System.Windows.Forms.ComboBox
        Me.txtkodecs = New System.Windows.Forms.ComboBox
        Me.txttanggal = New System.Windows.Forms.DateTimePicker
        Me.bttambah = New System.Windows.Forms.Button
        Me.dgvdetailJUAL = New System.Windows.Forms.DataGridView
        Me.btkeluar = New System.Windows.Forms.Button
        Me.btblankform = New System.Windows.Forms.Button
        Me.bthapus = New System.Windows.Forms.Button
        Me.btsimpan = New System.Windows.Forms.Button
        Me.txtnamacs = New System.Windows.Forms.TextBox
        Me.txtnota = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgvdetailJUAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(448, 190)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(92, 20)
        Me.txttotal.TabIndex = 60
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(331, 190)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(111, 20)
        Me.txtjumlah.TabIndex = 59
        '
        'txthrgjual
        '
        Me.txthrgjual.Location = New System.Drawing.Point(214, 190)
        Me.txthrgjual.Name = "txthrgjual"
        Me.txthrgjual.Size = New System.Drawing.Size(111, 20)
        Me.txthrgjual.TabIndex = 58
        '
        'txtnamabrg
        '
        Me.txtnamabrg.Location = New System.Drawing.Point(97, 190)
        Me.txtnamabrg.Name = "txtnamabrg"
        Me.txtnamabrg.Size = New System.Drawing.Size(111, 20)
        Me.txtnamabrg.TabIndex = 57
        '
        'txtkodebrg
        '
        Me.txtkodebrg.FormattingEnabled = True
        Me.txtkodebrg.Location = New System.Drawing.Point(16, 190)
        Me.txtkodebrg.Name = "txtkodebrg"
        Me.txtkodebrg.Size = New System.Drawing.Size(75, 21)
        Me.txtkodebrg.TabIndex = 56
        '
        'txtkodecs
        '
        Me.txtkodecs.FormattingEnabled = True
        Me.txtkodecs.Location = New System.Drawing.Point(386, 91)
        Me.txtkodecs.Name = "txtkodecs"
        Me.txtkodecs.Size = New System.Drawing.Size(75, 21)
        Me.txtkodecs.TabIndex = 55
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(143, 117)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(130, 20)
        Me.txttanggal.TabIndex = 54
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(143, 152)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 23)
        Me.bttambah.TabIndex = 53
        Me.bttambah.Text = "TAMBAH"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'dgvdetailJUAL
        '
        Me.dgvdetailJUAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetailJUAL.Location = New System.Drawing.Point(16, 217)
        Me.dgvdetailJUAL.Name = "dgvdetailJUAL"
        Me.dgvdetailJUAL.Size = New System.Drawing.Size(524, 170)
        Me.dgvdetailJUAL.TabIndex = 52
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(441, 152)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 51
        Me.btkeluar.Text = "CLOSE"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btblankform
        '
        Me.btblankform.Location = New System.Drawing.Point(326, 152)
        Me.btblankform.Name = "btblankform"
        Me.btblankform.Size = New System.Drawing.Size(82, 23)
        Me.btblankform.TabIndex = 50
        Me.btblankform.Text = "BLANKFORM"
        Me.btblankform.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(236, 152)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 49
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(47, 152)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 48
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'txtnamacs
        '
        Me.txtnamacs.Location = New System.Drawing.Point(386, 115)
        Me.txtnamacs.Name = "txtnamacs"
        Me.txtnamacs.Size = New System.Drawing.Size(145, 20)
        Me.txtnamacs.TabIndex = 47
        Me.txtnamacs.Visible = False
        '
        'txtnota
        '
        Me.txtnota.Location = New System.Drawing.Point(143, 91)
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(111, 20)
        Me.txtnota.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(279, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "NAMA CUSTOMER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(279, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "KODE CUSTOMER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "TANGGAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "NOMER NOTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 23)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "FORM TRANSAKSI PENJUALAN"
        '
        'JUAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Toko.My.Resources.Resources.rm380_10
        Me.ClientSize = New System.Drawing.Size(557, 417)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txthrgjual)
        Me.Controls.Add(Me.txtnamabrg)
        Me.Controls.Add(Me.txtkodebrg)
        Me.Controls.Add(Me.txtkodecs)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.dgvdetailJUAL)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btblankform)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.txtnamacs)
        Me.Controls.Add(Me.txtnota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "JUAL"
        Me.Text = "jual"
        CType(Me.dgvdetailJUAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents txthrgjual As System.Windows.Forms.TextBox
    Friend WithEvents txtnamabrg As System.Windows.Forms.TextBox
    Friend WithEvents txtkodebrg As System.Windows.Forms.ComboBox
    Friend WithEvents txtkodecs As System.Windows.Forms.ComboBox
    Friend WithEvents txttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents dgvdetailJUAL As System.Windows.Forms.DataGridView
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btblankform As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents txtnamacs As System.Windows.Forms.TextBox
    Friend WithEvents txtnota As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
