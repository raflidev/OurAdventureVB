Imports System.Data.SqlClient


Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Sub kosongkan()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        UsernameTextBox.Focus()

    End Sub
    Sub carikode()
        Call koneksi()

        cmd = New SqlCommand("select * from tbluser where username='" & UsernameTextBox.Text & "' AND password='" & PasswordTextBox.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Call carikode()
        If dr.HasRows Then
            MenuUtama.kodeuser.Text = dr(0)
            MenuUtama.leveluser.Text = dr(3)
            Me.Visible = False

            MenuUtama.Show()
        Else
            MsgBox("Username atau password salah")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Call kosongkan()

    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub
End Class
