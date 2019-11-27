Imports System.Data.SqlClient

Public Class Users

    Sub bersihkan()
        tiduser.Clear()
        clevel.Text = ""
        tpencarian.Clear()
        tpassword.Clear()
        tusername.Clear()
        Call kodeuser()

    End Sub
    Sub kodeuser()
        Call koneksi()
        cmd = New SqlCommand("select id_user from tbluser order by 1 desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tiduser.Text = Format(Microsoft.VisualBasic.Right(dr.Item("id_user"), 7) + 1, "USR0000000")
            tusername.Focus()
        Else
            tiduser.Text = "USR0000001"
            tusername.Focus()
        End If
    End Sub
    Sub carikode()
        Call koneksi()

        cmd = New SqlCommand("select * from tbluser where id_user= '" & tiduser.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub
    Sub ketemu()
        tiduser.Text = dr(0)
        tusername.Text = dr(1)
        tpassword.Text = dr(2)
        clevel.Text = dr(3)
        btnsimpan.Focus()
    End Sub
    Sub tampilgrid()
        Call koneksi()
        da = New SqlDataAdapter("select * from tbluser", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub userlevel()
        clevel.Items.Add(0)
        clevel.Items.Add(1)
    End Sub

    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call tampilgrid()
        Call kodeuser()
        Call userlevel()

    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If tiduser.Text = "" Or clevel.Text = "" Or tpassword.Text = "" Or tusername.Text = "" Then
            MsgBox("Data masih kosong")
        End If
        Call koneksi()

        Call carikode()
        If dr.HasRows Then
            'update
            Call koneksi()
            Dim update As String = "update tbluser set password='" & tpassword.Text & "', username='" & tusername.Text & "', level_user= '" & clevel.Text & "' where id_user = '" & tiduser.Text & "'"
            cmd = New SqlCommand(update, conn)
            dr = cmd.ExecuteReader
            MsgBox("data telah diupdate")
            Call bersihkan()
            Call kodeuser()
            Call tampilgrid()
        Else
            'insert
            Call koneksi()
            Dim simpan As String = "insert into tbluser values('" & tiduser.Text & "','" & tusername.Text & "','" & tpassword.Text & "','" & clevel.Text & "')"
            cmd = New SqlCommand(simpan, conn)
            dr = cmd.ExecuteReader
            MsgBox("data telah dimasukan")
            Call bersihkan()
            Call kodeuser()
            Call tampilgrid()
        End If
    End Sub

    Private Sub tpencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpencarian.TextChanged
        Call koneksi()

        da = New SqlDataAdapter("select * from tbluser where nama_member like '%" & tpencarian.Text & "%'", conn)
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
            cmd = New SqlCommand("delete from tbluser where id_user='" & tiduser.Text & "'", conn)
            dr = cmd.ExecuteReader
            MsgBox("data telah dihapus")
            Call bersihkan()
            Call kodeuser()
            Call tampilgrid()
        End If
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        tiduser.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call carikode()
        If dr.HasRows Then
            Call ketemu()
        End If
    End Sub


    Private Sub clevel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles clevel.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsimpan.Focus()

        End If
    End Sub
End Class