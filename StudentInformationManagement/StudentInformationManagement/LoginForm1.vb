Imports System.Data.SqlClient

Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim j, ctr1, en As Integer
        ctr1 = ds.Tables("login").Rows.Count
        Try
            For j = 0 To ctr1 - 1
                If ds.Tables("login").Rows(j)(0) = UsernameTextBox.Text And ds.Tables("login").Rows(j)(1) = TextBox1.Text Then
                    'MENUS.Show()
                    'Me.Hide()
                    en = 1
                
                End If
            Next
            If en = 1 Then
                MENUS.Show()
                Me.Hide()
            Else
                MsgBox("Wrong Password. Plese use correct password.")
            End If
        Catch ex As Exception

            MsgBox("Wrong Password. Plese use correct password.")
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()

        'Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i, ctr As Integer
        Module1.conn()
        cn.Open()
        str = "select * from login"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "login")
        ctr = ds.Tables("login").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.Items.Add(ds.Tables("login").Rows(i)(0).ToString)

        Next
        cn.Close()


    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        UsernameTextBox.Text = ComboBox1.Text
    End Sub

    Private Sub sasa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
