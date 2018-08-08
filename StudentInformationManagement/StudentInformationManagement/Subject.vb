Imports System.Data.SqlClient
Public Class Subject

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Clear()

        Module1.conn()
        cn.Open()
        str = "select * from Subject"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Subject")

        cn.Close()
        ds.Clear()
        ComboBox2.ResetText()

        Dim i, ctr As Integer
        cn.Open()
        str = "select * from ClassDetail"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "ClassDetail")
        ctr = ds.Tables("ClassDetail").Rows.Count - 1
        For i = 0 To ctr
            ComboBox2.Items.Add(ds.Tables("ClassDetail").Rows(i)(1).ToString)

        Next
        cn.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Open()
            str = "insert into Subject values (" & TextBox1.Text & ",'" & TextBox2.Text & "','" & TextBox3.Text & "'," & TextBox4.Text & ",'" & ComboBox1.Text & "')"
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

   

    

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

   

    
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox3.Text = ComboBox2.Text
    End Sub
End Class