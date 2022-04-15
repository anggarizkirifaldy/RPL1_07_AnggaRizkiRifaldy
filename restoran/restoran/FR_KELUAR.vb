Imports System.Data.SqlClient
Public Class FR_KELUAR

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        Dim fr As New FR_MENU
        fr.Show()
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtkode_TextChanged(sender As Object, e As EventArgs) Handles txtkode.TextChanged
        Dim str As String = "select kode,menu,status,harga_satuan from tbl_menu where rtrim(kode)='" & txtkode.Text & "'"
        Dim cmd As New SqlCommand(str, CONN)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            txtmenu.Text = rd.Item("menu").ToString.Trim
            txtstatus.Text = rd.Item("status").ToString.Trim
            txtharga.Text = CInt(rd.Item("harga_satuan"))
            rd.Close()
            masuk_data()
            txtkode.Clear()
        Else
            rd.Close()
        End If
    End Sub

    Sub masuk_data()
        Dim QTY As Integer = 0
        Dim ADA_DATA As Boolean = False
        Dim BARIS_DATA As Integer = 0

        For N = 0 To dgtampil.Rows.Count - 1
            Dim KODE As String = dgtampil.Item("KODE", N).Value
            If KODE = txtkode.Text Then
                ADA_DATA = True
                BARIS_DATA = N
                Exit For
            End If
        Next

        If ADA_DATA = True Then
            dgtampil.Rows(BARIS_DATA).Cells("QTY").Value = dgtampil.Rows(BARIS_DATA).Cells("QTY").Value + 1
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("TOTAL").Value = dgtampil.Rows(BARIS_DATA).Cells("QTY").Value * dgtampil.Rows(BARIS_DATA).Cells("HARGA").Value
        Else
            dgtampil.Rows.Add()
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("KODE").Value = txtkode.Text
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("MENU").Value = txtmenu.Text
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("STATUS").Value = txtstatus.Text
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("HARGA").Value = txtharga.Text
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("QTY").Value = "1"
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("TOTAL").Value = txtharga.Text
        End If

        total_harga()
    End Sub

    Private Sub dgtampil_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgtampil.CellEndEdit
        If e.ColumnIndex = 4 Then
            Dim QTY As String = ""
            QTY = dgtampil.Item("QTY", e.RowIndex).Value
            If IsNumeric(QTY) Then
                dgtampil.Item("TOTAL", e.RowIndex).Value = QTY * dgtampil.Item("HARGA", e.RowIndex).Value
                total_harga()
            Else
                MsgBox("NIKAI TIDAK VALID..")
                dgtampil.Item("QTY", e.RowIndex).Value = QTY_LAMA
            End If
        End If
    End Sub

    Dim QTY_LAMA As Integer = 0
    Private Sub dgtampil_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgtampil.CellBeginEdit
        If e.ColumnIndex = 4 Then
            QTY_LAMA = dgtampil.Item("QTY", e.RowIndex).Value
        End If
    End Sub

    'langsung vidio 21 akhir'
    Sub total_harga()
        Dim totharga As Integer = 0
        For n = 0 To dgtampil.Rows.Count - 1
            totharga = totharga + dgtampil.Item("TOTAL", n).Value
        Next
        lbtotal.Text = FormatCurrency(totharga, 0)
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        buka_cari()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        Dim str As String = "select TOP 10 rtrim(kode) as KODE,rtrim(menu) as MENU,rtrim(status)" & _
            " as STATUS,HARGA_SATUAN from tbl_menu where menu like '%" & txtcari.Text & "%'"
        Dim da As New SqlDataAdapter(str, CONN)
        Dim tbl As New DataTable
        da.Fill(tbl)
        dgcari.DataSource = tbl
    End Sub

    Private Sub dgcari_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgcari.CellDoubleClick
        txtkode.Text = dgcari.Item("KODE", e.RowIndex).Value
        pncari.Visible = False
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        TUTUP_CARI()
    End Sub

    Private Sub FR_KELUAR_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                If pncari.Visible = False Then
                    buka_cari()
                Else
                    TUTUP_CARI()
                End If

            Case Keys.F2
                If pnbayar.Visible = False Then
                    buka_bayar()
                Else
                    TUTUP_BAYAR()
                End If

        End Select
    End Sub

    Sub buka_cari()
        pnbayar.Visible = False
        pncari.Visible = True
        txtcari.Clear()
        txtcari.Select()
    End Sub

    Sub buka_bayar()
        If CInt(lbtotal.Text) <= 0 Then Exit Sub
        dgtampil.Enabled = False
        pncari.Visible = False
        pnbayar.Visible = True
        txtbayar.Text = CInt(lbtotal.Text)
        txttunai.Clear()
        txttunai.Select()
    End Sub

    Sub TUTUP_CARI()
        pncari.Visible = False
        txtkode.Select()
    End Sub

    Sub TUTUP_BAYAR()
        pnbayar.Visible = False
        dgtampil.Enabled = True
        txtkode.Select()
    End Sub

    Private Sub btnbayar_Click(sender As Object, e As EventArgs) Handles btnbayar.Click
        buka_bayar()
    End Sub

    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        TUTUP_BAYAR()
    End Sub

    
    Private Sub txttunai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttunai.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If CInt(txtkembalian.Text) >= 0 Then
                masuk_database()
            Else
                MsgBox("PEMBAYARAN TIDAK MENCUKUPI..")
            End If
        End If
    End Sub

    Private Sub txttunai_TextChanged(sender As Object, e As EventArgs) Handles txttunai.TextChanged
        If txttunai.Text = "" Then Exit Sub
        txtkembalian.Text = txttunai.Text - txtbayar.Text
    End Sub

    
    Private Sub dgtampil_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgtampil.CellMouseClick
        If dgtampil.Rows.Count > 0 AndAlso e.RowIndex > -1 Then
            klik_kanan.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub HAPUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HAPUSToolStripMenuItem.Click
        For Each ecell As DataGridViewCell In dgtampil.SelectedCells
            dgtampil.Rows.RemoveAt(ecell.RowIndex)
        Next
        total_harga()
    End Sub

    'apakah jenis diubah status'
    'tambah kode dim status'
    Sub masuk_database()
        If dgtampil.Rows.Count <= 0 Then Exit Sub
        For Each erow As DataGridViewRow In dgtampil.Rows
            Dim kode As String = erow.Cells("KODE").Value
            Dim status As String = erow.Cells("STATUS").Value
            Dim jumlah As Integer = erow.Cells("QTY").Value
            Dim harga As Integer = erow.Cells("TOTAL").Value

            'vidio 35
            Dim str As String = "insert into tbl_transaksi (kode,jumlah,status,harga,tgl,kasir) VALUES ('" & kode & "','" & jumlah & "','" & status & "','" & harga & "','" & Format(Date.Now, "MM/dd/yyyy") & "','" & nikAdmin & "')"

            Dim cmd As New SqlCommand(str, CONN)
            cmd.ExecuteNonQuery()
        Next
        print_nota()
        TUTUP_BAYAR()
        dgtampil.Rows.Clear()
        total_harga()
        txtkode.Select()
       
    End Sub

    Private Sub nota_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles nota.PrintPage
        Dim tinggi As Integer = 10
        e.Graphics.DrawString(nama_cafe, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString(no_cafe, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString(alamat_cafe, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 20
        e.Graphics.DrawString("--------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Barang" & vbTab & vbTab & "Qty" & vbTab & "Total", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        For Each erow As DataGridViewRow In dgtampil.Rows
            tinggi = tinggi + 10
            e.Graphics.DrawString(erow.Cells("MENU").Value, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

            tinggi = tinggi + 10
            e.Graphics.DrawString(vbTab & vbTab & erow.Cells("QTY").Value & vbTab & erow.Cells("TOTAL").Value, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
        Next

        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Total" & vbTab & vbTab & ": " & txtbayar.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Tunai" & vbTab & vbTab & ": " & txttunai.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Kembali" & vbTab & ": " & txtkembalian.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Terimakasih Atas Kunjungan Anda", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
    End Sub

    Sub print_nota()
        nota.PrinterSettings.PrinterName = printer_nota
        nota.Print()
    End Sub

    Private Sub FR_KELUAR_Load(sender As Object, e As EventArgs) Handles Me.Load
        ambil_data()
    End Sub

    'Private Sub btntr_Click(sender As Object, e As EventArgs) Handles btntr.Click
    'Dim tr As New Fr_trKasir
    'tr.ShowDialog()
    'End Sub

    
    
End Class