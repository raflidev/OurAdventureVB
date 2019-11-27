Imports System.Data.SqlClient

Public Class Member

    Sub bersihkan()
        tidmember.Clear()
        tnamamember.Clear()
        tpencarian.Clear()
    End Sub
    Sub kodemember()
        Call koneksi()
        cmd = New SqlCommand("select id_member from tblmember order by 1 desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tidmember.Text = Format(Microsoft.VisualBasic.Right(dr.Item("id_member"), 7) + 1, "MBR0000000")
            tnamamember.Focus()
        Else
            tidmember.Text = "MBR0000001"
            tnamamember.Focus()
        End If



    End Sub
    Sub carikode()
        Call koneksi()

        cmd = New SqlCommand("select * from tblmember where id_member= '" & tidmember.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()

    End Sub
    Sub ketemu()
        tidmember.Text = dr(0)
        tnamamember.Text = dr(0)
        btnsimpan.Focus()

    End Sub
    Sub tampilgrid()
        Call koneksi()

        da = New SqlDataAdapter("select * from tblmember", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call tampilgrid()
        Call kodemember()
        tnamamember.Focus()

    End Sub


    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If tidmember.Text = "" Or tnamamember.Text = "" Then
            MsgBox("Data masih kosong")
        End If
        Call koneksi()

        Call carikode()
        If dr.HasRows Then
            'update
            Call koneksi()
            Dim update As String = "update tblmember set nama_member= '" & tnamamember.Text & "' where id_member = '" & tidmember.Text & "'"
            cmd = New SqlCommand(update, conn)
            dr = cmd.ExecuteReader
            MsgBox("data telah diupdate")
            Call bersihkan()
            Call kodemember()
            Call tampilgrid()
        Else
            'insert
            Call koneksi()
            Dim simpan As String = "insert into tblmember values('" & tidmember.Text & "','" & tnamamember.Text & "')"
            cmd = New SqlCommand(simpan, conn)
            dr = cmd.ExecuteReader
            MsgBox("data telah dimasukan")
            Call bersihkan()
            Call kodemember()
            Call tampilgrid()
        End If
    End Sub

    Private Sub tpencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpencarian.TextChanged
        Call koneksi()

        da = New SqlDataAdapter("select * from tblmember where nama_member like '%" & tpencarian.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Private Sub btntutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntutup.Click
        Me.Close()

    End Sub

    Private Sub btnbersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbersihkan.Click
        Call bersihkan()

    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If MessageBox.Show("yakin mau dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            cmd = New SqlCommand("delete from tblmember where id_member='" & tidmember.Text & "'", conn)
            dr = cmd.ExecuteReader
            MsgBox("data telah dihapus")
            Call bersihkan()
            Call kodemember()
            Call tampilgrid()
        End If
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        tidmember.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call carikode()
        If dr.HasRows Then
            Call ketemu()
        End If
    End Sub
End Class
