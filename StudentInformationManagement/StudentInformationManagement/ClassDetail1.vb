Imports System.Data.SqlClient
Public Class ClassDetail1

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
        ds.Clear()

        Dim i, ctr As Integer
        cn.Open()
        str = "select * from ClassDetail"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "ClassDetail")
        ctr = ds.Tables("ClassDetail").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.Items.Add(ds.Tables("ClassDetail").Rows(i)(0).ToString)

        Next
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            Dim i = 0, ctr As Integer
            cn.Open()
            str = "select * from ClassDetail "
            cmd = New SqlCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "ClassDetail")
            ctr = ds.Tables("ClassDetail").Rows.Count - 1
            For i = 0 To ctr

                If TextBox1.Text = ds.Tables("ClassDetail").Rows(i)(0).ToString Then

                    TextBox2.Text = ds.Tables("ClassDetail").Rows(i)(1).ToString

                End If
            Next
            cn.Close()

            cn.Open()
            str = "select * from InformationForm where class = '" & TextBox2.Text & "' "
            cmd = New SqlCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "InformationForm")
            ctr = ds.Tables("InformationForm").Rows.Count - 1

            TextBox3.Text = ctr + 2
            cn.Close()
        Catch ex As Exception
            MsgBox("Insert Class Id First.")

        End Try
    End Sub

    

    

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            cn.Open()
            str = " update ClassDetail set ClassName = '" & TextBox2.Text & "'  where ClassId = " & TextBox1.Text & " "
            cmd = New SqlCommand(str, cn)
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            cn.Close()
            MsgBox("Record Updated.")
        Catch ex As Exception
            MsgBox("Enter Class ID first.")
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.Text
    End Sub
End Class