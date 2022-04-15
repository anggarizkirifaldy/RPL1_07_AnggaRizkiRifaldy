<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_KELUAR
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnatas = New System.Windows.Forms.Panel()
        Me.pncari = New System.Windows.Forms.Panel()
        Me.dgcari = New System.Windows.Forms.DataGridView()
        Me.keluar = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbtotal = New System.Windows.Forms.Label()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.txtmenu = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.pnbawah = New System.Windows.Forms.Panel()
        Me.btnbayar = New System.Windows.Forms.Button()
        Me.dgtampil = New System.Windows.Forms.DataGridView()
        Me.KODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MENU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnbayar = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.txttunai = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.klik_kanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nota = New System.Drawing.Printing.PrintDocument()
        Me.pnatas.SuspendLayout()
        Me.pncari.SuspendLayout()
        CType(Me.dgcari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnbawah.SuspendLayout()
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnbayar.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.klik_kanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnatas
        '
        Me.pnatas.Controls.Add(Me.pncari)
        Me.pnatas.Controls.Add(Me.GroupBox2)
        Me.pnatas.Controls.Add(Me.btnmenu)
        Me.pnatas.Controls.Add(Me.GroupBox1)
        Me.pnatas.Controls.Add(Me.btnminimize)
        Me.pnatas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnatas.Location = New System.Drawing.Point(0, 0)
        Me.pnatas.Name = "pnatas"
        Me.pnatas.Size = New System.Drawing.Size(1039, 189)
        Me.pnatas.TabIndex = 0
        '
        'pncari
        '
        Me.pncari.Controls.Add(Me.dgcari)
        Me.pncari.Controls.Add(Me.keluar)
        Me.pncari.Controls.Add(Me.txtcari)
        Me.pncari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pncari.Location = New System.Drawing.Point(0, 0)
        Me.pncari.Name = "pncari"
        Me.pncari.Size = New System.Drawing.Size(1039, 189)
        Me.pncari.TabIndex = 3
        Me.pncari.Visible = False
        '
        'dgcari
        '
        Me.dgcari.AllowUserToAddRows = False
        Me.dgcari.AllowUserToDeleteRows = False
        Me.dgcari.AllowUserToResizeColumns = False
        Me.dgcari.AllowUserToResizeRows = False
        Me.dgcari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgcari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgcari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcari.Location = New System.Drawing.Point(3, 27)
        Me.dgcari.Name = "dgcari"
        Me.dgcari.ReadOnly = True
        Me.dgcari.RowHeadersVisible = False
        Me.dgcari.Size = New System.Drawing.Size(1033, 160)
        Me.dgcari.TabIndex = 2
        '
        'keluar
        '
        Me.keluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keluar.BackColor = System.Drawing.Color.Red
        Me.keluar.Location = New System.Drawing.Point(972, 3)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(55, 20)
        Me.keluar.TabIndex = 1
        Me.keluar.Text = "X"
        Me.keluar.UseVisualStyleBackColor = False
        '
        'txtcari
        '
        Me.txtcari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcari.Location = New System.Drawing.Point(3, 3)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(944, 20)
        Me.txtcari.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbtotal)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(360, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(667, 138)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total bayar"
        '
        'lbtotal
        '
        Me.lbtotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbtotal.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotal.Location = New System.Drawing.Point(6, 32)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(640, 97)
        Me.lbtotal.TabIndex = 0
        Me.lbtotal.Text = "0"
        Me.lbtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnmenu
        '
        Me.btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.BackColor = System.Drawing.Color.Red
        Me.btnmenu.Location = New System.Drawing.Point(960, 10)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(53, 27)
        Me.btnmenu.TabIndex = 1
        Me.btnmenu.Text = "X"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncari)
        Me.GroupBox1.Controls.Add(Me.txtharga)
        Me.GroupBox1.Controls.Add(Me.txtstatus)
        Me.GroupBox1.Controls.Add(Me.txtmenu)
        Me.GroupBox1.Controls.Add(Me.txtkode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data menu"
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(249, 22)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 8
        Me.btncari.Text = "Cari "
        Me.btncari.UseVisualStyleBackColor = True
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(77, 104)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.ReadOnly = True
        Me.txtharga.Size = New System.Drawing.Size(247, 22)
        Me.txtharga.TabIndex = 7
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(77, 78)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.ReadOnly = True
        Me.txtstatus.Size = New System.Drawing.Size(247, 22)
        Me.txtstatus.TabIndex = 6
        '
        'txtmenu
        '
        Me.txtmenu.Location = New System.Drawing.Point(77, 51)
        Me.txtmenu.Name = "txtmenu"
        Me.txtmenu.ReadOnly = True
        Me.txtmenu.Size = New System.Drawing.Size(247, 22)
        Me.txtmenu.TabIndex = 5
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(77, 24)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(166, 22)
        Me.txtkode.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'btnminimize
        '
        Me.btnminimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimize.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimize.Location = New System.Drawing.Point(862, 12)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(80, 23)
        Me.btnminimize.TabIndex = 2
        Me.btnminimize.Text = "Minimize"
        Me.btnminimize.UseVisualStyleBackColor = True
        '
        'pnbawah
        '
        Me.pnbawah.Controls.Add(Me.btnbayar)
        Me.pnbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnbawah.Location = New System.Drawing.Point(0, 452)
        Me.pnbawah.Name = "pnbawah"
        Me.pnbawah.Size = New System.Drawing.Size(1039, 55)
        Me.pnbawah.TabIndex = 1
        '
        'btnbayar
        '
        Me.btnbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbayar.Location = New System.Drawing.Point(28, 16)
        Me.btnbayar.Name = "btnbayar"
        Me.btnbayar.Size = New System.Drawing.Size(75, 23)
        Me.btnbayar.TabIndex = 0
        Me.btnbayar.Text = "Bayar"
        Me.btnbayar.UseVisualStyleBackColor = True
        '
        'dgtampil
        '
        Me.dgtampil.AllowUserToAddRows = False
        Me.dgtampil.AllowUserToDeleteRows = False
        Me.dgtampil.AllowUserToResizeColumns = False
        Me.dgtampil.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgtampil.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgtampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtampil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KODE, Me.MENU, Me.STATUS, Me.HARGA, Me.QTY, Me.TOTAL})
        Me.dgtampil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtampil.Location = New System.Drawing.Point(0, 189)
        Me.dgtampil.Name = "dgtampil"
        Me.dgtampil.RowHeadersVisible = False
        Me.dgtampil.Size = New System.Drawing.Size(1039, 263)
        Me.dgtampil.TabIndex = 2
        '
        'KODE
        '
        Me.KODE.HeaderText = "KODE"
        Me.KODE.Name = "KODE"
        Me.KODE.ReadOnly = True
        Me.KODE.Width = 150
        '
        'MENU
        '
        Me.MENU.HeaderText = "MENU"
        Me.MENU.Name = "MENU"
        Me.MENU.ReadOnly = True
        Me.MENU.Width = 300
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        Me.STATUS.Width = 150
        '
        'HARGA
        '
        Me.HARGA.HeaderText = "HARGA"
        Me.HARGA.Name = "HARGA"
        Me.HARGA.ReadOnly = True
        Me.HARGA.Width = 150
        '
        'QTY
        '
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.Width = 80
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Width = 150
        '
        'pnbayar
        '
        Me.pnbayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnbayar.Controls.Add(Me.GroupBox3)
        Me.pnbayar.Location = New System.Drawing.Point(189, 233)
        Me.pnbayar.Name = "pnbayar"
        Me.pnbayar.Size = New System.Drawing.Size(546, 195)
        Me.pnbayar.TabIndex = 4
        Me.pnbayar.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btntutup)
        Me.GroupBox3.Controls.Add(Me.txtkembalian)
        Me.GroupBox3.Controls.Add(Me.txttunai)
        Me.GroupBox3.Controls.Add(Me.txtbayar)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(519, 161)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pembayaran"
        '
        'btntutup
        '
        Me.btntutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntutup.BackColor = System.Drawing.Color.Red
        Me.btntutup.Location = New System.Drawing.Point(442, 17)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(59, 28)
        Me.btntutup.TabIndex = 6
        Me.btntutup.Text = "X"
        Me.btntutup.UseVisualStyleBackColor = False
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(124, 107)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.ReadOnly = True
        Me.txtkembalian.Size = New System.Drawing.Size(252, 22)
        Me.txtkembalian.TabIndex = 5
        Me.txtkembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttunai
        '
        Me.txttunai.Location = New System.Drawing.Point(124, 72)
        Me.txttunai.Name = "txttunai"
        Me.txttunai.Size = New System.Drawing.Size(252, 22)
        Me.txttunai.TabIndex = 4
        Me.txttunai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(124, 37)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.ReadOnly = True
        Me.txtbayar.Size = New System.Drawing.Size(252, 22)
        Me.txtbayar.TabIndex = 3
        Me.txtbayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Kembalian"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tunai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Bayar"
        '
        'klik_kanan
        '
        Me.klik_kanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HAPUSToolStripMenuItem})
        Me.klik_kanan.Name = "klik_kanan"
        Me.klik_kanan.Size = New System.Drawing.Size(113, 26)
        '
        'HAPUSToolStripMenuItem
        '
        Me.HAPUSToolStripMenuItem.Name = "HAPUSToolStripMenuItem"
        Me.HAPUSToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'nota
        '
        '
        'FR_KELUAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 507)
        Me.Controls.Add(Me.pnbayar)
        Me.Controls.Add(Me.dgtampil)
        Me.Controls.Add(Me.pnbawah)
        Me.Controls.Add(Me.pnatas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FR_KELUAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_KELUAR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnatas.ResumeLayout(False)
        Me.pncari.ResumeLayout(False)
        Me.pncari.PerformLayout()
        CType(Me.dgcari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnbawah.ResumeLayout(False)
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnbayar.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.klik_kanan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnatas As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pnbawah As System.Windows.Forms.Panel
    Friend WithEvents dgtampil As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbtotal As System.Windows.Forms.Label
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents txtmenu As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents btnbayar As System.Windows.Forms.Button
    Friend WithEvents pncari As System.Windows.Forms.Panel
    Friend WithEvents dgcari As System.Windows.Forms.DataGridView
    Friend WithEvents keluar As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents pnbayar As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents txtkembalian As System.Windows.Forms.TextBox
    Friend WithEvents txttunai As System.Windows.Forms.TextBox
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents klik_kanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MENU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HARGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nota As System.Drawing.Printing.PrintDocument
End Class
