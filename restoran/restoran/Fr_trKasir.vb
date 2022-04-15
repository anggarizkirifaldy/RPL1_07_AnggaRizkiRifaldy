Imports System.Data.SqlClient
Public Class Fr_trKasir

    Sub tampil()
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("select a.ID,a.TGL,a.KODE,rtrim(b.menu) as MENU,a.JUMLAH,a.HARGA from tbl_transaksi as a inner join tbl_menu as b on a.kode=b.kode where kasir='" & txtNIK.Text & "' and tgl='" & Format(dttgl.Value, "MM-dd-yyyy") & "'", CONN)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Dgtampil.DataSource = tbl
        Dgtampil.Columns("HARGA").DefaultCellStyle.Format = "N0"
        hitung_total()
    End Sub

    Private Sub txtNIK_TextChanged(sender As Object, e As EventArgs) Handles txtNIK.TextChanged
        Dim cmd As New SqlCommand("select rtrim(nama) as nama from tbl_karyawan where rtrim(nik)='" & txtNIK.Text & "'", CONN)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            txtNAMA.Text = rd.Item("nama").ToString
            rd.Close()
        Else
            rd.Close()
            txtNAMA.Clear()
        End If

        tampil()
    End Sub

    Private Sub Fr_trKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNIK.Text = nikAdmin
    End Sub

    Sub hitung_total()
        Dim jlh As Long = 0
        For n = 0 To Dgtampil.Rows.Count - 1
            jlh = jlh + Dgtampil.Item("HARGA", n).Value
        Next
        txtjumlah.Text = jlh
    End Sub

    Private Sub dttgl_ValueChanged(sender As Object, e As EventArgs) Handles dttgl.ValueChanged
        tampil()
    End Sub
End Class