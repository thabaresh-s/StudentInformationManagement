Imports System.Data.SqlClient
Public Class Subject1

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

        Dim i, ctr As Integer
        cn.Open()
        str = "select * from Subject"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Subject")
        ctr = ds.Tables("Subject").Rows.Count - 1
        For i = 0 To ctr
            ComboBox2.Items.Add(ds.Tables("Subject").Rows(i)(0).ToString)

        Next
        cn.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            ComboBox1.Visible = False
            Dim i = 0, ctr As Integer
            cn.Open()
            str = "select * from Subject "
            cmd = New SqlCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "Subject")
            ctr = ds.Tables("Subject").Rows.Count - 1
            For i = 0 To ctr

                If TextBox1.Text = ds.Tables("Subject").Rows(i)(0).ToString Then

                    TextBox2.Text = ds.Tables("Subject").Rows(i)(1).ToString
                    TextBox3.Text = ds.Tables("Subject").Rows(i)(2).ToString
                    TextBox4.Text = ds.Tables("Subject").Rows(i)(3).ToString
                    TextBox5.Text = ds.Tables("Subject").Rows(i)(4).ToString
                End If
            Next
            cn.Close()
        Catch ex As Exception
            MsgBox("Insert Subject Id First.")

        End Try
    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            cn.Open()
            str = " update Subject set SubjectName = '" & TextBox2.Text & "', SubjectClass = '" & TextBox3.Text & "', mark = " & TextBox4.Text & " semister = '" & ComboBox1.Text & "' where SubjectID = " & TextBox1.Text & " "
            cmd = New SqlCommand(str, cn)
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            cn.Close()
            MsgBox("Record Updated.")
        Catch ex As Exception
            MsgBox("Enter Subject ID first.")
        End Try
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox1.Text = ComboBox2.Text
    End Sub
End Class