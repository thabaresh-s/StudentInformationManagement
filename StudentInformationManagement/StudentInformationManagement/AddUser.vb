Imports System.Data.SqlClient
Public Class AddUser

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            cn.Open()
            str = "insert into login values (" & TextBox1.Text & ",'" & TextBox2.Text & "')"
            cmd = New SqlCommand(str, cn)
            da.InsertCommand = cmd
            da.InsertCommand.ExecuteNonQuery()
            MsgBox(" Record Saved.")
            cn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Close()

        Catch ex As Exception
            MsgBox(" Record Not Saved.")

            cn.Close()
        End Try
    End Sub




    Private Sub AddUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.conn()
        cn.Open()
        str = "select * from ClassDetail"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "ClassDetail")

        cn.Close()
    End Sub
End Class