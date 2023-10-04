<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BARANG
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtkodebrg = New System.Windows.Forms.TextBox
        Me.txtnamabrg = New System.Windows.Forms.TextBox
        Me.txthrgbeli = New System.Windows.Forms.TextBox
        Me.txthrgjual = New System.Windows.Forms.TextBox
        Me.txtjmlawal = New System.Windows.Forms.TextBox
        Me.btsimpan = New System.Windows.Forms.Button
        Me.bthapus = New System.Windows.Forms.Button
        Me.btblankform = New System.Windows.Forms.Button
        Me.btkeluar = New System.Windows.Forms.Button
        Me.dgvbrg = New System.Windows.Forms.DataGridView
        Me.BTEDIT = New System.Windows.Forms.Button
        CType(Me.dgvbrg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM DATA BARANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KODE BARANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NAMA BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HARGA BELI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(90, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "HARGA JUAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(90, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "JUMLAH AWAL"
        '
        'txtkodebrg
        '
        Me.txtkodebrg.Location = New System.Drawing.Point(216, 65)
        Me.txtkodebrg.Name = "txtkodebrg"
        Me.txtkodebrg.Size = New System.Drawing.Size(145, 20)
        Me.txtkodebrg.TabIndex = 6
        '
        'txtnamabrg
        '
        Me.txtnamabrg.Location = New System.Drawing.Point(216, 92)
        Me.txtnamabrg.Name = "txtnamabrg"
        Me.txtnamabrg.Size = New System.Drawing.Size(225, 20)
        Me.txtnamabrg.TabIndex = 7
        '
        'txthrgbeli
        '
        Me.txthrgbeli.Location = New System.Drawing.Point(216, 117)
        Me.txthrgbeli.Name = "txthrgbeli"
        Me.txthrgbeli.Size = New System.Drawing.Size(194, 20)
        Me.txthrgbeli.TabIndex = 8
        '
        'txthrgjual
        '
        Me.txthrgjual.Location = New System.Drawing.Point(216, 142)
        Me.txthrgjual.Name = "txthrgjual"
        Me.txthrgjual.Size = New System.Drawing.Size(194, 20)
        Me.txthrgjual.TabIndex = 9
        '
        'txtjmlawal
        '
        Me.txtjmlawal.Location = New System.Drawing.Point(216, 170)
        Me.txtjmlawal.Name = "txtjmlawal"
        Me.txtjmlawal.Size = New System.Drawing.Size(194, 20)
        Me.txtjmlawal.TabIndex = 10
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(33, 204)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 11
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(216, 204)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 12
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btblankform
        '
        Me.btblankform.Location = New System.Drawing.Point(312, 204)
        Me.btblankform.Name = "btblankform"
        Me.btblankform.Size = New System.Drawing.Size(82, 23)
        Me.btblankform.TabIndex = 13
        Me.btblankform.Text = "BLANKFORM"
        Me.btblankform.UseVisualStyleBackColor = True
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(411, 204)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 14
        Me.btkeluar.Text = "CLOSE"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'dgvbrg
        '
        Me.dgvbrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbrg.Location = New System.Drawing.Point(18, 238)
        Me.dgvbrg.Name = "dgvbrg"
        Me.dgvbrg.Size = New System.Drawing.Size(524, 150)
        Me.dgvbrg.TabIndex = 15
        '
        'BTEDIT
        '
        Me.BTEDIT.Location = New System.Drawing.Point(123, 204)
        Me.BTEDIT.Name = "BTEDIT"
        Me.BTEDIT.Size = New System.Drawing.Size(75, 23)
        Me.BTEDIT.TabIndex = 16
        Me.BTEDIT.Text = "EDIT"
        Me.BTEDIT.UseVisualStyleBackColor = True
        '
        'BARANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Toko.My.Resources.Resources.rm380_10
        Me.ClientSize = New System.Drawing.Size(554, 423)
        Me.Controls.Add(Me.BTEDIT)
        Me.Controls.Add(Me.dgvbrg)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btblankform)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.txtjmlawal)
        Me.Controls.Add(Me.txthrgjual)
        Me.Controls.Add(Me.txthrgbeli)
        Me.Controls.Add(Me.txtnamabrg)
        Me.Controls.Add(Me.txtkodebrg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BARANG"
        Me.Text = "barang"
        CType(Me.dgvbrg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtkodebrg As System.Windows.Forms.TextBox
    Friend WithEvents txtnamabrg As System.Windows.Forms.TextBox
    Friend WithEvents txthrgbeli As System.Windows.Forms.TextBox
    Friend WithEvents txthrgjual As System.Windows.Forms.TextBox
    Friend WithEvents txtjmlawal As System.Windows.Forms.TextBox
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btblankform As System.Windows.Forms.Button
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents dgvbrg As System.Windows.Forms.DataGridView
    Friend WithEvents BTEDIT As System.Windows.Forms.Button
End Class
