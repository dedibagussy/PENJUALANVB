<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMPEMAKAI
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
        Me.dgvpemakai = New System.Windows.Forms.DataGridView
        Me.btkeluar = New System.Windows.Forms.Button
        Me.btblankform = New System.Windows.Forms.Button
        Me.bthapus = New System.Windows.Forms.Button
        Me.btsimpan = New System.Windows.Forms.Button
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtnamapk = New System.Windows.Forms.TextBox
        Me.txtkodepk = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbjabatan = New System.Windows.Forms.ComboBox
        Me.pbfoto = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.dgvpemakai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEDIT
        '
        Me.BTEDIT.Location = New System.Drawing.Point(120, 197)
        Me.BTEDIT.Name = "BTEDIT"
        Me.BTEDIT.Size = New System.Drawing.Size(75, 23)
        Me.BTEDIT.TabIndex = 48
        Me.BTEDIT.Text = "EDIT"
        Me.BTEDIT.UseVisualStyleBackColor = True
        '
        'dgvpemakai
        '
        Me.dgvpemakai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpemakai.Location = New System.Drawing.Point(15, 231)
        Me.dgvpemakai.Name = "dgvpemakai"
        Me.dgvpemakai.Size = New System.Drawing.Size(524, 150)
        Me.dgvpemakai.TabIndex = 47
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(408, 197)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 46
        Me.btkeluar.Text = "CLOSE"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btblankform
        '
        Me.btblankform.Location = New System.Drawing.Point(309, 197)
        Me.btblankform.Name = "btblankform"
        Me.btblankform.Size = New System.Drawing.Size(82, 23)
        Me.btblankform.TabIndex = 45
        Me.btblankform.Text = "BLANKFORM"
        Me.btblankform.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(213, 197)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 44
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(30, 197)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 43
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(155, 135)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(194, 20)
        Me.txtpassword.TabIndex = 42
        '
        'txtnamapk
        '
        Me.txtnamapk.Location = New System.Drawing.Point(155, 84)
        Me.txtnamapk.Name = "txtnamapk"
        Me.txtnamapk.Size = New System.Drawing.Size(194, 20)
        Me.txtnamapk.TabIndex = 40
        '
        'txtkodepk
        '
        Me.txtkodepk.Location = New System.Drawing.Point(155, 58)
        Me.txtkodepk.Name = "txtkodepk"
        Me.txtkodepk.Size = New System.Drawing.Size(145, 20)
        Me.txtkodepk.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "JABATAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "NAMA PEMAKAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "KODE PEMAKAI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "FORM DATA PEMAKAI"
        '
        'cbjabatan
        '
        Me.cbjabatan.DisplayMember = "MANAGER"
        Me.cbjabatan.FormattingEnabled = True
        Me.cbjabatan.Items.AddRange(New Object() {"MANAGER", "ADMINISTRASI", "KEUANGAN"})
        Me.cbjabatan.Location = New System.Drawing.Point(155, 110)
        Me.cbjabatan.Name = "cbjabatan"
        Me.cbjabatan.Size = New System.Drawing.Size(194, 21)
        Me.cbjabatan.TabIndex = 49
        '
        'pbfoto
        '
        Me.pbfoto.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pbfoto.Location = New System.Drawing.Point(388, 53)
        Me.pbfoto.Name = "pbfoto"
        Me.pbfoto.Size = New System.Drawing.Size(121, 124)
        Me.pbfoto.TabIndex = 50
        Me.pbfoto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FORMPEMAKAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Toko.My.Resources.Resources.rm380_10
        Me.ClientSize = New System.Drawing.Size(555, 383)
        Me.Controls.Add(Me.pbfoto)
        Me.Controls.Add(Me.cbjabatan)
        Me.Controls.Add(Me.BTEDIT)
        Me.Controls.Add(Me.dgvpemakai)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btblankform)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtnamapk)
        Me.Controls.Add(Me.txtkodepk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FORMPEMAKAI"
        Me.Text = "PEMAKAI"
        CType(Me.dgvpemakai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTEDIT As System.Windows.Forms.Button
    Friend WithEvents dgvpemakai As System.Windows.Forms.DataGridView
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btblankform As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapk As System.Windows.Forms.TextBox
    Friend WithEvents txtkodepk As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbjabatan As System.Windows.Forms.ComboBox
    Friend WithEvents pbfoto As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
