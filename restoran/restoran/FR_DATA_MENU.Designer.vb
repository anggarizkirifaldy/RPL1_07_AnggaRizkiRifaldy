<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_DATA_MENU
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
        Me.TXTKODE = New System.Windows.Forms.TextBox()
        Me.TXTMENU = New System.Windows.Forms.TextBox()
        Me.TXTHARGA = New System.Windows.Forms.TextBox()
        Me.CBSTATUS = New System.Windows.Forms.ComboBox()
        Me.BTNSIMPAN = New System.Windows.Forms.Button()
        Me.DGTAMPIL = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MENU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "STATUS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " HARGA  SATUAN"
        '
        'TXTKODE
        '
        Me.TXTKODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKODE.Location = New System.Drawing.Point(150, 18)
        Me.TXTKODE.Name = "TXTKODE"
        Me.TXTKODE.Size = New System.Drawing.Size(120, 21)
        Me.TXTKODE.TabIndex = 4
        '
        'TXTMENU
        '
        Me.TXTMENU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMENU.Location = New System.Drawing.Point(149, 51)
        Me.TXTMENU.Name = "TXTMENU"
        Me.TXTMENU.Size = New System.Drawing.Size(270, 21)
        Me.TXTMENU.TabIndex = 5
        '
        'TXTHARGA
        '
        Me.TXTHARGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHARGA.Location = New System.Drawing.Point(149, 117)
        Me.TXTHARGA.Name = "TXTHARGA"
        Me.TXTHARGA.Size = New System.Drawing.Size(120, 21)
        Me.TXTHARGA.TabIndex = 6
        '
        'CBSTATUS
        '
        Me.CBSTATUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSTATUS.FormattingEnabled = True
        Me.CBSTATUS.Items.AddRange(New Object() {"MAKANAN", "MINUMAN"})
        Me.CBSTATUS.Location = New System.Drawing.Point(149, 84)
        Me.CBSTATUS.Name = "CBSTATUS"
        Me.CBSTATUS.Size = New System.Drawing.Size(121, 23)
        Me.CBSTATUS.TabIndex = 7
        '
        'BTNSIMPAN
        '
        Me.BTNSIMPAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSIMPAN.Location = New System.Drawing.Point(149, 178)
        Me.BTNSIMPAN.Name = "BTNSIMPAN"
        Me.BTNSIMPAN.Size = New System.Drawing.Size(75, 23)
        Me.BTNSIMPAN.TabIndex = 8
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
        Me.DGTAMPIL.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGTAMPIL.Location = New System.Drawing.Point(27, 261)
        Me.DGTAMPIL.Name = "DGTAMPIL"
        Me.DGTAMPIL.ReadOnly = True
        Me.DGTAMPIL.RowHeadersVisible = False
        Me.DGTAMPIL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGTAMPIL.Size = New System.Drawing.Size(761, 150)
        Me.DGTAMPIL.TabIndex = 9
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HAPUSToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 26)
        '
        'HAPUSToolStripMenuItem
        '
        Me.HAPUSToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.HAPUSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HAPUSToolStripMenuItem.Name = "HAPUSToolStripMenuItem"
        Me.HAPUSToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.HAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'TXTCARI
        '
        Me.TXTCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCARI.Location = New System.Drawing.Point(27, 235)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(761, 20)
        Me.TXTCARI.TabIndex = 10
        '
        'FR_DATA_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 423)
        Me.Controls.Add(Me.TXTCARI)
        Me.Controls.Add(Me.DGTAMPIL)
        Me.Controls.Add(Me.BTNSIMPAN)
        Me.Controls.Add(Me.CBSTATUS)
        Me.Controls.Add(Me.TXTHARGA)
        Me.Controls.Add(Me.TXTMENU)
        Me.Controls.Add(Me.TXTKODE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FR_DATA_MENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATA MENU"
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTKODE As System.Windows.Forms.TextBox
    Friend WithEvents TXTMENU As System.Windows.Forms.TextBox
    Friend WithEvents TXTHARGA As System.Windows.Forms.TextBox
    Friend WithEvents CBSTATUS As System.Windows.Forms.ComboBox
    Friend WithEvents BTNSIMPAN As System.Windows.Forms.Button
    Friend WithEvents DGTAMPIL As System.Windows.Forms.DataGridView
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
