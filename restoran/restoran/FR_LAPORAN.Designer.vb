<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_LAPORAN
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TAMPILNAMA = New System.Windows.Forms.Button()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.tglmulai = New System.Windows.Forms.DateTimePicker()
        Me.btntampil = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tglsampai = New System.Windows.Forms.DateTimePicker()
        Me.dgtampil = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 147)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TAMPILNAMA)
        Me.GroupBox2.Controls.Add(Me.txtnama)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 110)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Berdasarkan Nama"
        '
        'TAMPILNAMA
        '
        Me.TAMPILNAMA.Location = New System.Drawing.Point(151, 77)
        Me.TAMPILNAMA.Name = "TAMPILNAMA"
        Me.TAMPILNAMA.Size = New System.Drawing.Size(75, 23)
        Me.TAMPILNAMA.TabIndex = 7
        Me.TAMPILNAMA.Text = "Tampil"
        Me.TAMPILNAMA.UseVisualStyleBackColor = True
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(80, 33)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(219, 22)
        Me.txtnama.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btncetak)
        Me.GroupBox1.Controls.Add(Me.tglmulai)
        Me.GroupBox1.Controls.Add(Me.btntampil)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tglsampai)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(432, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 110)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Berdasarkan TGL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mulai TGL"
        '
        'btncetak
        '
        Me.btncetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncetak.Location = New System.Drawing.Point(184, 77)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(75, 23)
        Me.btncetak.TabIndex = 6
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'tglmulai
        '
        Me.tglmulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglmulai.Location = New System.Drawing.Point(79, 21)
        Me.tglmulai.Name = "tglmulai"
        Me.tglmulai.Size = New System.Drawing.Size(107, 22)
        Me.tglmulai.TabIndex = 2
        '
        'btntampil
        '
        Me.btntampil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntampil.Location = New System.Drawing.Point(103, 77)
        Me.btntampil.Name = "btntampil"
        Me.btntampil.Size = New System.Drawing.Size(75, 23)
        Me.btntampil.TabIndex = 5
        Me.btntampil.Text = "Tampil"
        Me.btntampil.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sampai TGL"
        '
        'tglsampai
        '
        Me.tglsampai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglsampai.Location = New System.Drawing.Point(292, 21)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Size = New System.Drawing.Size(109, 22)
        Me.tglsampai.TabIndex = 4
        '
        'dgtampil
        '
        Me.dgtampil.AllowUserToAddRows = False
        Me.dgtampil.AllowUserToDeleteRows = False
        Me.dgtampil.AllowUserToResizeColumns = False
        Me.dgtampil.AllowUserToResizeRows = False
        Me.dgtampil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgtampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtampil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtampil.Location = New System.Drawing.Point(0, 147)
        Me.dgtampil.Name = "dgtampil"
        Me.dgtampil.ReadOnly = True
        Me.dgtampil.RowHeadersVisible = False
        Me.dgtampil.Size = New System.Drawing.Size(874, 312)
        Me.dgtampil.TabIndex = 1
        '
        'FR_LAPORAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 459)
        Me.Controls.Add(Me.dgtampil)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FR_LAPORAN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAPORAN DATA TRANSAKSI"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tglsampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tglmulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgtampil As System.Windows.Forms.DataGridView
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents btntampil As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TAMPILNAMA As System.Windows.Forms.Button
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
