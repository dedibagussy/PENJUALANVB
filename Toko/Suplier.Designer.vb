<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUPLIER
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
        Me.BTEDIT = New System.Windows.Forms.Button
        Me.dgvsp = New System.Windows.Forms.DataGridView
        Me.btkeluar = New System.Windows.Forms.Button
        Me.btblankform = New System.Windows.Forms.Button
        Me.bthapus = New System.Windows.Forms.Button
        Me.btsimpan = New System.Windows.Forms.Button
        Me.txttelponsp = New System.Windows.Forms.TextBox
        Me.txtalamatsp = New System.Windows.Forms.TextBox
        Me.txtnamasp = New System.Windows.Forms.TextBox
        Me.txtkodesp = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgvsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEDIT
        '
        Me.BTEDIT.Location = New System.Drawing.Point(160, 217)
        Me.BTEDIT.Name = "BTEDIT"
        Me.BTEDIT.Size = New System.Drawing.Size(75, 23)
        Me.BTEDIT.TabIndex = 33
        Me.BTEDIT.Text = "EDIT"
        Me.BTEDIT.UseVisualStyleBackColor = True
        '
        'dgvsp
        '
        Me.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsp.Location = New System.Drawing.Point(55, 251)
        Me.dgvsp.Name = "dgvsp"
        Me.dgvsp.Size = New System.Drawing.Size(504, 150)
        Me.dgvsp.TabIndex = 32
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(448, 217)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 31
        Me.btkeluar.Text = "CLOSE"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btblankform
        '
        Me.btblankform.Location = New System.Drawing.Point(349, 217)
        Me.btblankform.Name = "btblankform"
        Me.btblankform.Size = New System.Drawing.Size(82, 23)
        Me.btblankform.TabIndex = 30
        Me.btblankform.Text = "BLANKFORM"
        Me.btblankform.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(253, 217)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 29
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(70, 217)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 28
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'txttelponsp
        '
        Me.txttelponsp.Location = New System.Drawing.Point(253, 155)
        Me.txttelponsp.Name = "txttelponsp"
        Me.txttelponsp.Size = New System.Drawing.Size(194, 20)
        Me.txttelponsp.TabIndex = 26
        '
        'txtalamatsp
        '
        Me.txtalamatsp.Location = New System.Drawing.Point(253, 130)
        Me.txtalamatsp.Name = "txtalamatsp"
        Me.txtalamatsp.Size = New System.Drawing.Size(194, 20)
        Me.txtalamatsp.TabIndex = 25
        '
        'txtnamasp
        '
        Me.txtnamasp.Location = New System.Drawing.Point(253, 105)
        Me.txtnamasp.Name = "txtnamasp"
        Me.txtnamasp.Size = New System.Drawing.Size(225, 20)
        Me.txtnamasp.TabIndex = 24
        '
        'txtkodesp
        '
        Me.txtkodesp.Location = New System.Drawing.Point(253, 78)
        Me.txtkodesp.Name = "txtkodesp"
        Me.txtkodesp.Size = New System.Drawing.Size(145, 20)
        Me.txtkodesp.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(127, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "NOMOR TELP."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(127, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ALAMAT SUPLIER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "NAMA SUPLIER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "KODE SUPLIER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "FORM DATA SUPLIER"
        '
        'SUPLIER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Toko.My.Resources.Resources.rm380_10
        Me.ClientSize = New System.Drawing.Size(608, 423)
        Me.Controls.Add(Me.BTEDIT)
        Me.Controls.Add(Me.dgvsp)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btblankform)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.txttelponsp)
        Me.Controls.Add(Me.txtalamatsp)
        Me.Controls.Add(Me.txtnamasp)
        Me.Controls.Add(Me.txtkodesp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SUPLIER"
        Me.Text = "Suplier"
        CType(Me.dgvsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTEDIT As System.Windows.Forms.Button
    Friend WithEvents dgvsp As System.Windows.Forms.DataGridView
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btblankform As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents txttelponsp As System.Windows.Forms.TextBox
    Friend WithEvents txtalamatsp As System.Windows.Forms.TextBox
    Friend WithEvents txtnamasp As System.Windows.Forms.TextBox
    Friend WithEvents txtkodesp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
