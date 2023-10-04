<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUSTOMER
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
        Me.dgvcS = New System.Windows.Forms.DataGridView
        Me.btkeluar = New System.Windows.Forms.Button
        Me.btblankform = New System.Windows.Forms.Button
        Me.bthapus = New System.Windows.Forms.Button
        Me.btsimpan = New System.Windows.Forms.Button
        Me.txttelponcs = New System.Windows.Forms.TextBox
        Me.txtalamatcs = New System.Windows.Forms.TextBox
        Me.txtnamacs = New System.Windows.Forms.TextBox
        Me.txtkodeCS = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgvcS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEDIT
        '
        Me.BTEDIT.Location = New System.Drawing.Point(145, 213)
        Me.BTEDIT.Name = "BTEDIT"
        Me.BTEDIT.Size = New System.Drawing.Size(75, 23)
        Me.BTEDIT.TabIndex = 33
        Me.BTEDIT.Text = "EDIT"
        Me.BTEDIT.UseVisualStyleBackColor = True
        '
        'dgvcS
        '
        Me.dgvcS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcS.Location = New System.Drawing.Point(40, 247)
        Me.dgvcS.Name = "dgvcS"
        Me.dgvcS.Size = New System.Drawing.Size(524, 150)
        Me.dgvcS.TabIndex = 32
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(433, 213)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 31
        Me.btkeluar.Text = "CLOSE"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btblankform
        '
        Me.btblankform.Location = New System.Drawing.Point(334, 213)
        Me.btblankform.Name = "btblankform"
        Me.btblankform.Size = New System.Drawing.Size(82, 23)
        Me.btblankform.TabIndex = 30
        Me.btblankform.Text = "BLANKFORM"
        Me.btblankform.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(238, 213)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 29
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(55, 213)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 28
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'txttelponcs
        '
        Me.txttelponcs.Location = New System.Drawing.Point(238, 151)
        Me.txttelponcs.Name = "txttelponcs"
        Me.txttelponcs.Size = New System.Drawing.Size(194, 20)
        Me.txttelponcs.TabIndex = 26
        '
        'txtalamatcs
        '
        Me.txtalamatcs.Location = New System.Drawing.Point(238, 126)
        Me.txtalamatcs.Name = "txtalamatcs"
        Me.txtalamatcs.Size = New System.Drawing.Size(194, 20)
        Me.txtalamatcs.TabIndex = 25
        '
        'txtnamacs
        '
        Me.txtnamacs.Location = New System.Drawing.Point(238, 101)
        Me.txtnamacs.Name = "txtnamacs"
        Me.txtnamacs.Size = New System.Drawing.Size(225, 20)
        Me.txtnamacs.TabIndex = 24
        '
        'txtkodeCS
        '
        Me.txtkodeCS.Location = New System.Drawing.Point(238, 74)
        Me.txtkodeCS.Name = "txtkodeCS"
        Me.txtkodeCS.Size = New System.Drawing.Size(145, 20)
        Me.txtkodeCS.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "TELPON "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ALAMAT CUSTOMER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "NAMA CUSTOMER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "KODE CUSTOMER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "FORM DATA CUSTOMER"
        '
        'CUSTOMER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Toko.My.Resources.Resources.rm380_10
        Me.ClientSize = New System.Drawing.Size(604, 415)
        Me.Controls.Add(Me.BTEDIT)
        Me.Controls.Add(Me.dgvcS)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btblankform)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.txttelponcs)
        Me.Controls.Add(Me.txtalamatcs)
        Me.Controls.Add(Me.txtnamacs)
        Me.Controls.Add(Me.txtkodeCS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CUSTOMER"
        Me.Text = "customer"
        CType(Me.dgvcS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTEDIT As System.Windows.Forms.Button
    Friend WithEvents dgvcS As System.Windows.Forms.DataGridView
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btblankform As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents txttelponcs As System.Windows.Forms.TextBox
    Friend WithEvents txtalamatcs As System.Windows.Forms.TextBox
    Friend WithEvents txtnamacs As System.Windows.Forms.TextBox
    Friend WithEvents txtkodeCS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
