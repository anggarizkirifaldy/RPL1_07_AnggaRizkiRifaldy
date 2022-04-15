<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_ADMIN
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.lbnama = New System.Windows.Forms.Label()
        Me.lbnik = New System.Windows.Forms.Label()
        Me.cbtype = New System.Windows.Forms.ComboBox()
        Me.txtpass2 = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.lbnama)
        Me.GroupBox1.Controls.Add(Me.lbnik)
        Me.GroupBox1.Controls.Add(Me.cbtype)
        Me.GroupBox1.Controls.Add(Me.txtpass2)
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.txtuser)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(670, 377)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setting User/Hak Akses"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(200, 324)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(5)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(101, 29)
        Me.btnsimpan.TabIndex = 12
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'lbnama
        '
        Me.lbnama.AutoSize = True
        Me.lbnama.Location = New System.Drawing.Point(196, 102)
        Me.lbnama.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbnama.Name = "lbnama"
        Me.lbnama.Size = New System.Drawing.Size(54, 17)
        Me.lbnama.TabIndex = 11
        Me.lbnama.Text = "NAMA"
        '
        'lbnik
        '
        Me.lbnik.AutoSize = True
        Me.lbnik.Location = New System.Drawing.Point(196, 59)
        Me.lbnik.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbnik.Name = "lbnik"
        Me.lbnik.Size = New System.Drawing.Size(112, 17)
        Me.lbnik.TabIndex = 10
        Me.lbnik.Text = "ID KARYAWAN"
        '
        'cbtype
        '
        Me.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Items.AddRange(New Object() {"ADMIN", "MANAGER", "KASIR"})
        Me.cbtype.Location = New System.Drawing.Point(200, 271)
        Me.cbtype.Margin = New System.Windows.Forms.Padding(5)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(189, 25)
        Me.cbtype.TabIndex = 9
        '
        'txtpass2
        '
        Me.txtpass2.Location = New System.Drawing.Point(200, 228)
        Me.txtpass2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtpass2.Name = "txtpass2"
        Me.txtpass2.Size = New System.Drawing.Size(425, 25)
        Me.txtpass2.TabIndex = 8
        Me.txtpass2.UseSystemPasswordChar = True
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(200, 184)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(5)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(425, 25)
        Me.txtpass.TabIndex = 7
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(200, 142)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(5)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(425, 25)
        Me.txtuser.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 275)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 231)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "RE PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID/NIK Karyawan"
        '
        'FR_ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 408)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FR_ADMIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_ADMIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents lbnama As System.Windows.Forms.Label
    Friend WithEvents lbnik As System.Windows.Forms.Label
    Friend WithEvents cbtype As System.Windows.Forms.ComboBox
    Friend WithEvents txtpass2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
