Imports System.Data.SqlClient
Public Class FR_ADMIN
    'VIDIO 32'
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtuser.Text = "" Or txtpass.Text = "" Or txtpass2.Text = "" Then
            MsgBox("Data Tidak Lengkap..")
        ElseIf txtpass.Text <> txtpass2.Text Then
            MsgBox("Ulangi Penulisan Password..")
        Else
            Dim str As String = ""
            str = "select nik from tbl_admin where nik='" & lbnik.Text & "'"
            Dim cmd As SqlCommand
            Dim rd As SqlDataReader
            cmd = New SqlCommand(str, CONN)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Close()
                cmd = New SqlCommand("update tbl_admin set username='" & _
                                     txtuser.Text & "',password='" & txtpass2.Text & _
                                     "',type='" & cbtype.Text & "' where rtrim(nik)='" & lbnik.Text & "'", CONN)
                cmd.ExecuteNonQuery()
            Else
                rd.Close()
                cmd = New SqlCommand("insert into tbl_admin values ('" & _
                                     lbnik.Text & "','" & txtuser.Text & "','" & _
                                     txtpass2.Text & "','" & cbtype.Text & "')", CONN)
                cmd.ExecuteNonQuery()
            End If
            MsgBox("Data Tersimpan..")
        End If
    End Sub


End Class