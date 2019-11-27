Imports System.Data.SqlClient

Public Class Laporan

    Sub nama()
        Call koneksi()
        cmd = New SqlCommand("select nama_member from tblmember", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read()
            ComboBox1.Items.Add(dr(0))
        Loop

    End Sub

    Private Sub Laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call nama()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV.SelectionFormula = "{TBLMEMBER.nama_member} = '" & ComboBox1.Text & "'"
        CRV.ReportSource = "LaporanSimpanan.rpt"
        CRV.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CRV.ReportSource = "LaporanSemuaMember.rpt"
        CRV.RefreshReport()
    End Sub
End Class