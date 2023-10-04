<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.pbfoto = New System.Windows.Forms.PictureBox
        Me.CBKODEPK = New System.Windows.Forms.ComboBox
        Me.btLOGIN = New System.Windows.Forms.Button
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtnamapk = New System.Windows.Forms.TextBox
        Me.TXTJABATAN = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btkeluar = New System.Windows.Forms.Button
        CType(Me.pbfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbfoto
        '
        Me.pbfoto.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pbfoto.Location = New System.Drawing.Point(389, 66)
        Me.pbfoto.Name = "pbfoto"
        Me.pbfoto.Size = New System.Drawing.Size(121, 124)
        Me.pbfoto.TabIndex = 66
        Me.pbfoto.TabStop = False
        '
        'CBKODEPK
        '
        Me.CBKODEPK.DisplayMember = "MANAGER"
        Me.CBKODEPK.FormattingEnabled = True
        Me.CBKODEPK.Items.AddRange(New Object() {"MANAGER", "ADMINISTRASI", "KEUANGAN"})
        Me.CBKODEPK.Location = New System.Drawing.Point(156, 71)
        Me.CBKODEPK.Name = "CBKODEPK"
        Me.CBKODEPK.Size = New System.Drawing.Size(194, 21)
        Me.CBKODEPK.TabIndex = 65
        '
        'btLOGIN
        '
        Me.btLOGIN.BackgroundImage = Global.Toko.My.Resources.Resources.natural_light_white_background
        Me.btLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLOGIN.Location = New System.Drawing.Point(156, 210)
        Me.btLOGIN.Name = "btLOGIN"
        Me.btLOGIN.Size = New System.Drawing.Size(75, 23)
        Me.btLOGIN.TabIndex = 59
        Me.btLOGIN.Text = "LOGIN"
        Me.btLOGIN.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(156, 148)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(194, 20)
        Me.txtpassword.TabIndex = 58
        '
        'txtnamapk
        '
        Me.txtnamapk.Location = New System.Drawing.Point(156, 97)
        Me.txtnamapk.Name = "txtnamapk"
        Me.txtnamapk.Size = New System.Drawing.Size(194, 20)
        Me.txtnamapk.TabIndex = 57
        '
        'TXTJABATAN
        '
        Me.TXTJABATAN.Location = New System.Drawing.Point(156, 123)
        Me.TXTJABATAN.Name = "TXTJABATAN"
        Me.TXTJABATAN.Size = New System.Drawing.Size(145, 20)
        Me.TXTJABATAN.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "JABATAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "NAMA USER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "KODE USER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "FORM LOGIN"
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(237, 210)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 62
        Me.btkeluar.Text = "CLOSE"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Toko.My.Resources.Resources.rm380_10
        Me.ClientSize = New System.Drawing.Size(525, 261)
        Me.Controls.Add(Me.pbfoto)
        Me.Controls.Add(Me.CBKODEPK)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btLOGIN)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtnamapk)
        Me.Controls.Add(Me.TXTJABATAN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LOGIN"
        Me.Text = "LOGIN"
        CType(Me.pbfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbfoto As System.Windows.Forms.PictureBox
    Friend WithEvents CBKODEPK As System.Windows.Forms.ComboBox
    Friend WithEvents btLOGIN As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapk As System.Windows.Forms.TextBox
    Friend WithEvents TXTJABATAN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btkeluar As System.Windows.Forms.Button
End Class
