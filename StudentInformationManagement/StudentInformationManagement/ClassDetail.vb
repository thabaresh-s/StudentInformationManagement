Imports System.Data.SqlClient
Public Class ClassDetail

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub ClassDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.conn()
        cn.Open()
        str = "select * from ClassDetail"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "ClassDetail")

        cn.Close()
    End Sub

    

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            cn.Open()
            str = "insert into ClassDetail values (" & TextBox1.Text & ",'" & TextBox2.Text & "')"
            cmd = New SqlCommand(str, cn)
            da.InsertCommand = cmd
            da.InsertCommand.ExecuteNonQuery()
            MsgBox(" Record Saved.")
            cn.Close()

        Catch ex As Exception
            MsgBox(" Record Not Saved.")

            cn.Close()
        End Try
    End Sub

    

   
End Class