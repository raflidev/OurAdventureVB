Imports System.Data.SqlClient


Public Class Simpan

    Sub carinama()
        Call koneksi()
        cmd = New SqlCommand("select nama_member from tblmember", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmember.Items.Add(dr(0))
        Loop

    End Sub

    Sub bersihkan()
        tidsimpan.Clear()
        tuang.Clear()
        cmember.Text = ""
        DTP.Value = Today
        tpencarian.Clear()
        cmember.Focus()
        Call kodesimpan()

    End Sub
    Sub carikode()
        Call koneksi()
        cmd = New SqlCommand("select * from tblsimpan where id_simpan = '" & tidsimpan.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub
    Sub ketemu()
        tidsimpan.Text = dr(0)
        tuang.Text = dr(2)
        DTP.Value = dr(3)
        Call koneksi()
        cmd = New SqlCommand("select nama_member from tblmember where id_member='" & dr(1) & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        cmember.Text = dr(0)

    End Sub
    Sub tampilgrid()
        Call koneksi()

        da = New SqlDataAdapter("select tblsimpan.id_simpan,tblmember.nama_member,tblsimpan.uang,tblsimpan.waktu from tblsimpan,tblmember where tblsimpan.id_member = tblmember.id_member ", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Private Sub Simpan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call carinama()
        Call tampilgrid()
        Call kodesimpan()

        Me.CenterToScreen()

    End Sub
    Sub kodesimpan()
        Call koneksi()
        cmd = New SqlCommand("select id_simpan from tblsimpan order by 1 desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tidsimpan.Text = Format(Microsoft.VisualBasic.Right(dr.Item("id_simpan"), 7) + 1, "SPM0000000")
            cmember.Focus()
        Else
            tidsimpan.Text = "SPM0000001"
            cmember.Focus()
        End If
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        tidsimpan.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call carikode()
        If dr.HasRows Then
            Call ketemu()
        End If
    End Sub
    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If tidsimpan.Text = "" Or cmember.Text = "" Or tuang.Text = "" Or DTP.Text = "" Then
            MsgBox("Data masih kosong")
        End If
        Call koneksi()

        Call carikode()
        If dr.HasRows Then
            Call koneksi()
            cmd = New SqlCommand("select id_member from tblmember where nama_member='" & cmember.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            'update
            Call koneksi()
            Dim update As String = "update tblsimpan set id_member='" & cmember.Text & "', uang='" & tuang.Text & "', waktu= '" & Format(DTP.Value, "yyyy-MM-dd") & "' where id_simpan = '" & tidsimpan.Text & "'"
            cmd = New SqlCommand(update, conn)
            dr = cmd.ExecuteReader
            MsgBox("data telah diupdate")
            Call bersihkan()
            Call kodesimpan()
            Call tampilgrid()
        Else
            'insert
            Call koneksi()
            cmd = New SqlCommand("select id_member from tblmember where nama_member='" & cmember.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            Call koneksi()
            Dim simpan As String = "insert into tblsimpan values('" & tidsimpan.Text & "','" & dr(0) & "','" & tuang.Text & "','" & Format(DTP.Value, "yyyy-MM-dd") & "')"
            cmd = New SqlCommand(simpan, conn)
            dr = cmd.ExecuteReader
            MsgBox("data telah dimasukan")
            Call bersihkan()
            Call kodesimpan()
            Call tampilgrid()
        End If
    End Sub
   
    Private Sub tpencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpencarian.TextChanged
        Call koneksi()

        da = New SqlDataAdapter("select tblsimpan.id_simpan,tblmember.nama_member,tblsimpan.uang,tblsimpan.waktu from tblsimpan,tblmember where tblmember.nama_member like '%" & tpencarian.Text & "%' and tblsimpan.id_member = tblmember.id_member", conn)
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
            cmd = New SqlCommand("delete from tblsimpan where id_simpan='" & tidsimpan.Text & "'", conn)
            dr = cmd.ExecuteReader
            MsgBox("data telah dihapus")
            Call bersihkan()
            Call kodesimpan()
            Call tampilgrid()
        End If
    End Sub

    Private Sub tuang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tuang.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsimpan.Focus()

        End If
    End Sub

    Private Sub tuang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tuang.TextChanged

    End Sub
End Class