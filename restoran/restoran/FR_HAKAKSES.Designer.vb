<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_hakAkses
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
        Me.dgAdmin = New System.Windows.Forms.DataGridView()
        Me.dgakses = New System.Windows.Forms.DataGridView()
        Me.btnsimpan = New System.Windows.Forms.Button()
        CType(Me.dgAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgakses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAdmin
        '
        Me.dgAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAdmin.Location = New System.Drawing.Point(12, 12)
        Me.dgAdmin.Name = "dgAdmin"
        Me.dgAdmin.Size = New System.Drawing.Size(332, 438)
        Me.dgAdmin.TabIndex = 0
        '
        'dgakses
        '
        Me.dgakses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgakses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgakses.Location = New System.Drawing.Point(350, 12)
        Me.dgakses.Name = "dgakses"
        Me.dgakses.Size = New System.Drawing.Size(508, 397)
        Me.dgakses.TabIndex = 1
        '
        'btnsimpan
        '
        Me.btnsimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsimpan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(760, 427)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 2
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'fr_hakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 462)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.dgakses)
        Me.Controls.Add(Me.dgAdmin)
        Me.Name = "fr_hakAkses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_HAKAKSES"
        CType(Me.dgAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgakses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgAdmin As System.Windows.Forms.DataGridView
    Friend WithEvents dgakses As System.Windows.Forms.DataGridView
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
End Class
