<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tpencarian = New System.Windows.Forms.TextBox
        Me.btntutup = New System.Windows.Forms.Button
        Me.btnbersihkan = New System.Windows.Forms.Button
        Me.btnhapus = New System.Windows.Forms.Button
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.clevel = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tpassword = New System.Windows.Forms.TextBox
        Me.tusername = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tiduser = New System.Windows.Forms.TextBox
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(0, 193)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(568, 207)
        Me.DGV.TabIndex = 121
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tpencarian)
        Me.GroupBox2.Controls.Add(Me.btntutup)
        Me.GroupBox2.Controls.Add(Me.btnbersihkan)
        Me.GroupBox2.Controls.Add(Me.btnhapus)
        Me.GroupBox2.Controls.Add(Me.btnsimpan)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 80)
        Me.GroupBox2.TabIndex = 120
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fitur"
        '
        'tpencarian
        '
        Me.tpencarian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tpencarian.Location = New System.Drawing.Point(403, 16)
        Me.tpencarian.Multiline = True
        Me.tpencarian.Name = "tpencarian"
        Me.tpencarian.Size = New System.Drawing.Size(162, 61)
        Me.tpencarian.TabIndex = 14
        '
        'btntutup
        '
        Me.btntutup.Dock = System.Windows.Forms.DockStyle.Left
        Me.btntutup.Image = CType(resources.GetObject("btntutup.Image"), System.Drawing.Image)
        Me.btntutup.Location = New System.Drawing.Point(303, 16)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(100, 61)
        Me.btntutup.TabIndex = 13
        Me.btntutup.Text = "Tutup"
        Me.btntutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'btnbersihkan
        '
        Me.btnbersihkan.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnbersihkan.Image = CType(resources.GetObject("btnbersihkan.Image"), System.Drawing.Image)
        Me.btnbersihkan.Location = New System.Drawing.Point(203, 16)
        Me.btnbersihkan.Name = "btnbersihkan"
        Me.btnbersihkan.Size = New System.Drawing.Size(100, 61)
        Me.btnbersihkan.TabIndex = 12
        Me.btnbersihkan.Text = "Bersihkan"
        Me.btnbersihkan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbersihkan.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.Location = New System.Drawing.Point(103, 16)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(100, 61)
        Me.btnhapus.TabIndex = 10
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(3, 16)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(100, 61)
        Me.btnsimpan.TabIndex = 9
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clevel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tpassword)
        Me.GroupBox1.Controls.Add(Me.tusername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tiduser)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 113)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        '
        'clevel
        '
        Me.clevel.FormattingEnabled = True
        Me.clevel.Location = New System.Drawing.Point(135, 82)
        Me.clevel.Name = "clevel"
        Me.clevel.Size = New System.Drawing.Size(162, 21)
        Me.clevel.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(303, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "PASSWORD"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(12, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "USERNAME"
        '
        'tpassword
        '
        Me.tpassword.Location = New System.Drawing.Point(426, 55)
        Me.tpassword.Name = "tpassword"
        Me.tpassword.Size = New System.Drawing.Size(127, 20)
        Me.tpassword.TabIndex = 2
        '
        'tusername
        '
        Me.tusername.Location = New System.Drawing.Point(135, 53)
        Me.tusername.Name = "tusername"
        Me.tusername.Size = New System.Drawing.Size(162, 20)
        Me.tusername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "USER LEVEL"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID USER"
        '
        'tiduser
        '
        Me.tiduser.Location = New System.Drawing.Point(135, 27)
        Me.tiduser.Name = "tiduser"
        Me.tiduser.ReadOnly = True
        Me.tiduser.Size = New System.Drawing.Size(162, 20)
        Me.tiduser.TabIndex = 99
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 400)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Users"
        Me.Text = "USERS - RAFLI RAMADHAN"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tpencarian As System.Windows.Forms.TextBox
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents btnbersihkan As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tiduser As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tpassword As System.Windows.Forms.TextBox
    Friend WithEvents tusername As System.Windows.Forms.TextBox
    Friend WithEvents clevel As System.Windows.Forms.ComboBox
End Class
