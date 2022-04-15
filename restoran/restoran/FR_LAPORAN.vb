Imports System.Data.SqlClient
Public Class FR_LAPORAN
    'direfisi
    Dim tbl As New DataTable
    Dim TBL2 As New DataTable
    Sub tampil()

        Dim str As String = "select tgl,kode,(select rtrim(menu) from tbl_menu" & _
            " where kode=tbl_transaksi.kode) as menu,jumlah," & _
            " harga from tbl_transaksi where status=tbl_transaksi.status and tgl >= '" & _
            Format(tglmulai.Value, "MM/dd/yyyy") & "' and tgl <='" & _
            Format(tglsampai.Value, "MM/dd/yyyy") & "'"

        Dim da As New SqlDataAdapter(str, CONN)
        tbl.Clear()
        da.Fill(tbl)
        dgtampil.DataSource = tbl
        dgtampil.Columns("harga").DefaultCellStyle.Format = "N0"
        dgtampil.Columns("harga").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub


    Private Sub btntampil_Click(sender As Object, e As EventArgs) Handles btntampil.Click
        tampil()

    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        If dgtampil.Rows.Count > 0 Then
            Dim rpt As New RPT_TRANSAKSI
            With rpt
                .SetDataSource(tbl)
                .SetParameterValue("tgl_mulai", tglmulai.Value)
                .SetParameterValue("tgl_sampai", tglsampai.Value)
            End With
            Dim FR As New FR_PREVIEW
            With FR
                .CRV.ReportSource = rpt
                .ShowDialog()
            End With
        End If
    End Sub

    'direfisi
    Private Sub TAMPILNAMA_Click(sender As Object, e As EventArgs) Handles TAMPILNAMA.Click

        Dim str As String = "SELECT TBL_ADMIN.USERNAME AS NAMA, TBL_TRANSAKSI.TGL, TBL_TRANSAKSI.KODE, TBL_MENU.MENU, TBL_TRANSAKSI.JUMLAH, TBL_TRANSAKSI.HARGA FROM TBL_ADMIN INNER JOIN TBL_TRANSAKSI ON TBL_ADMIN.NIK = TBL_TRANSAKSI.KASIR INNER JOIN TBL_MENU ON TBL_TRANSAKSI.KODE = TBL_MENU.KODE WHERE USERNAME LIKE '%" & txtnama.Text & "%'"
        Dim da As New SqlDataAdapter(str, CONN)
        TBL2.Clear()
        da.Fill(TBL2)
        dgtampil.DataSource = TBL2

    End Sub
End Class