<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_KARYAWAN
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTNIK = New System.Windows.Forms.TextBox()
        Me.TXTNAMA = New System.Windows.Forms.TextBox()
        Me.TXTASAL = New System.Windows.Forms.TextBox()
        Me.TXTALAMAT = New System.Windows.Forms.TextBox()
        Me.TXTNO = New System.Windows.Forms.TextBox()
        Me.TGL = New System.Windows.Forms.DateTimePicker()
        Me.CBJK = New System.Windows.Forms.ComboBox()
        Me.BTNSIMPAN = New System.Windows.Forms.Button()
        Me.DGTAMPIL = New System.Windows.Forms.DataGridView()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        Me.BTNBARU = New System.Windows.Forms.Button()
        Me.BTNHAPUS = New System.Windows.Forms.Button()
        Me.klik_kanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetingUserHakAksesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.klik_kanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID/NIK KARYAWAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ASAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TGL LAHIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "JENIS KELAMIN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 214)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ALAMAT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 251)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "NO HP"
        '
        'TXTNIK
        '
        Me.TXTNIK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNIK.Location = New System.Drawing.Point(150, 26)
        Me.TXTNIK.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTNIK.MaxLength = 12
        Me.TXTNIK.Name = "TXTNIK"
        Me.TXTNIK.ReadOnly = True
        Me.TXTNIK.Size = New System.Drawing.Size(207, 21)
        Me.TXTNIK.TabIndex = 7
        '
        'TXTNAMA
        '
        Me.TXTNAMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNAMA.Location = New System.Drawing.Point(150, 63)
        Me.TXTNAMA.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTNAMA.MaxLength = 50
        Me.TXTNAMA.Name = "TXTNAMA"
        Me.TXTNAMA.Size = New System.Drawing.Size(330, 21)
        Me.TXTNAMA.TabIndex = 8
        '
        'TXTASAL
        '
        Me.TXTASAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTASAL.Location = New System.Drawing.Point(150, 99)
        Me.TXTASAL.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTASAL.MaxLength = 50
        Me.TXTASAL.Name = "TXTASAL"
        Me.TXTASAL.Size = New System.Drawing.Size(207, 21)
        Me.TXTASAL.TabIndex = 9
        '
        'TXTALAMAT
        '
        Me.TXTALAMAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTALAMAT.Location = New System.Drawing.Point(150, 210)
        Me.TXTALAMAT.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTALAMAT.MaxLength = 100
        Me.TXTALAMAT.Name = "TXTALAMAT"
        Me.TXTALAMAT.Size = New System.Drawing.Size(409, 21)
        Me.TXTALAMAT.TabIndex = 12
        '
        'TXTNO
        '
        Me.TXTNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNO.Location = New System.Drawing.Point(150, 247)
        Me.TXTNO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTNO.MaxLength = 15
        Me.TXTNO.Name = "TXTNO"
        Me.TXTNO.Size = New System.Drawing.Size(207, 21)
        Me.TXTNO.TabIndex = 13
        '
        'TGL
        '
        Me.TGL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGL.Location = New System.Drawing.Point(150, 136)
        Me.TGL.Margin = New System.Windows.Forms.Padding(4)
        Me.TGL.Name = "TGL"
        Me.TGL.Size = New System.Drawing.Size(232, 21)
        Me.TGL.TabIndex = 14
        '
        'CBJK
        '
        Me.CBJK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBJK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBJK.FormattingEnabled = True
        Me.CBJK.Items.AddRange(New Object() {"LAKI-LAKI", "PEREMPUAN"})
        Me.CBJK.Location = New System.Drawing.Point(150, 172)
        Me.CBJK.Margin = New System.Windows.Forms.Padding(4)
        Me.CBJK.Name = "CBJK"
        Me.CBJK.Size = New System.Drawing.Size(152, 23)
        Me.CBJK.TabIndex = 15
        '
        'BTNSIMPAN
        '
        Me.BTNSIMPAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSIMPAN.Location = New System.Drawing.Point(150, 301)
        Me.BTNSIMPAN.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSIMPAN.Name = "BTNSIMPAN"
        Me.BTNSIMPAN.Size = New System.Drawing.Size(88, 26)
        Me.BTNSIMPAN.TabIndex = 16
        Me.BTNSIMPAN.Text = "SIMPAN"
        Me.BTNSIMPAN.UseVisualStyleBackColor = True
        '
        'DGTAMPIL
        '
        Me.DGTAMPIL.AllowUserToAddRows = False
        Me.DGTAMPIL.AllowUserToDeleteRows = False
        Me.DGTAMPIL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTAMPIL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGTAMPIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTAMPIL.Location = New System.Drawing.Point(32, 393)
        Me.DGTAMPIL.Margin = New System.Windows.Forms.Padding(4)
        Me.DGTAMPIL.Name = "DGTAMPIL"
        Me.DGTAMPIL.ReadOnly = True
        Me.DGTAMPIL.RowHeadersVisible = False
        Me.DGTAMPIL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGTAMPIL.Size = New System.Drawing.Size(868, 159)
        Me.DGTAMPIL.TabIndex = 17
        '
        'TXTCARI
        '
        Me.TXTCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCARI.Location = New System.Drawing.Point(32, 363)
        Me.TXTCARI.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(868, 21)
        Me.TXTCARI.TabIndex = 18
        '
        'BTNBARU
        '
        Me.BTNBARU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBARU.Location = New System.Drawing.Point(270, 301)
        Me.BTNBARU.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNBARU.Name = "BTNBARU"
        Me.BTNBARU.Size = New System.Drawing.Size(88, 26)
        Me.BTNBARU.TabIndex = 19
        Me.BTNBARU.Text = "BARU"
        Me.BTNBARU.UseVisualStyleBackColor = True
        '
        'BTNHAPUS
        '
        Me.BTNHAPUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHAPUS.Location = New System.Drawing.Point(393, 301)
        Me.BTNHAPUS.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNHAPUS.Name = "BTNHAPUS"
        Me.BTNHAPUS.Size = New System.Drawing.Size(88, 26)
        Me.BTNHAPUS.TabIndex = 20
        Me.BTNHAPUS.Text = "HAPUS"
        Me.BTNHAPUS.UseVisualStyleBackColor = True
        '
        'klik_kanan
        '
        Me.klik_kanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetingUserHakAksesToolStripMenuItem})
        Me.klik_kanan.Name = "ContextMenuStrip1"
        Me.klik_kanan.Size = New System.Drawing.Size(218, 26)
        '
        'SetingUserHakAksesToolStripMenuItem
        '
        Me.SetingUserHakAksesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetingUserHakAksesToolStripMenuItem.Name = "SetingUserHakAksesToolStripMenuItem"
        Me.SetingUserHakAksesToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.SetingUserHakAksesToolStripMenuItem.Text = "Setting User/Hak Akses"
        '
        'FR_KARYAWAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 566)
        Me.Controls.Add(Me.BTNHAPUS)
        Me.Controls.Add(Me.BTNBARU)
        Me.Controls.Add(Me.TXTCARI)
        Me.Controls.Add(Me.DGTAMPIL)
        Me.Controls.Add(Me.BTNSIMPAN)
        Me.Controls.Add(Me.CBJK)
        Me.Controls.Add(Me.TGL)
        Me.Controls.Add(Me.TXTNO)
        Me.Controls.Add(Me.TXTALAMAT)
        Me.Controls.Add(Me.TXTASAL)
        Me.Controls.Add(Me.TXTNAMA)
        Me.Controls.Add(Me.TXTNIK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FR_KARYAWAN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.klik_kanan.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTNIK As System.Windows.Forms.TextBox
    Friend WithEvents TXTNAMA As System.Windows.Forms.TextBox
    Friend WithEvents TXTASAL As System.Windows.Forms.TextBox
    Friend WithEvents TXTALAMAT As System.Windows.Forms.TextBox
    Friend WithEvents TXTNO As System.Windows.Forms.TextBox
    Friend WithEvents TGL As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBJK As System.Windows.Forms.ComboBox
    Friend WithEvents BTNSIMPAN As System.Windows.Forms.Button
    Friend WithEvents DGTAMPIL As System.Windows.Forms.DataGridView
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents BTNBARU As System.Windows.Forms.Button
    Friend WithEvents BTNHAPUS As System.Windows.Forms.Button
    Friend WithEvents klik_kanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SetingUserHakAksesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
