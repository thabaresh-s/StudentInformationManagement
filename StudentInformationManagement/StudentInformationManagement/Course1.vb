Imports System.Data.SqlClient
Public Class Course1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        clear()


    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.ResetText()
    End Sub

    Private Sub Course_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Clear()

        Module1.conn()
        cn.Open()
        str = "select * from InformationForm"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Course")

        cn.Close()
        Dim i, ctr As Integer
        cn.Open()
        str = "select * from Course"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Course")
        ctr = ds.Tables("Course").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.Items.Add(ds.Tables("Course").Rows(i)(0).ToString)

        Next
        cn.Close()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Dim i = 0, ctr As Integer
        cn.Open()

        str = "select * from Course "
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Course")
        ctr = ds.Tables("Course").Rows.Count - 1
        For i = 0 To ctr

            If TextBox1.Text = ds.Tables("Course").Rows(i)(0).ToString Then

                TextBox1.Text = ds.Tables("Course").Rows(i)(0).ToString
                TextBox2.Text = ds.Tables("Course").Rows(i)(1).ToString
                TextBox3.Text = ds.Tables("Course").Rows(i)(2).ToString
                TextBox4.Text = ds.Tables("Course").Rows(i)(3).ToString
                TextBox5.Text = ds.Tables("Course").Rows(i)(4).ToString
                TextBox6.Text = ds.Tables("Course").Rows(i)(5).ToString
            End If
        Next
    End Sub

    

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try

            cn.Open()
            str = " update Course set course_name = '" & TextBox2.Text & "', course_duration = " & TextBox3.Text & ", total_semester = " & TextBox4.Text & ", total_subjects = " & TextBox5.Text & ", max_students = " & TextBox6.Text & " where SubjectID = " & TextBox1.Text & " "
            cmd = New SqlCommand(str, cn)
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            cn.Close()
            MsgBox("Record Updated.")
        Catch ex As Exception
            MsgBox("Enter Course ID first.")
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.Text
    End Sub
End Class