Imports System.Data.SqlClient
Public Class AddmisionForm1
    Dim Photos1() As Byte
    Dim dr As SqlDataReader
    Dim str1 As String

    Private Sub AddmisionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        ds.Clear()


        Dim i, ctr As Integer
        Module1.conn()
        'cn.Open()
        'str = "select * from InformationForm "
        'cmd = New SqlCommand(str, cn)
        'da.SelectCommand = cmd
        'da.Fill(ds, "InformationForm")
        'If ds.Tables("InformationForm").Rows(i)(0) = TextBox1.Text Then
        '    ctr = ds.Tables("InformationForm").Rows.Count - 1
        '    For i = 0 To ctr
        '        If ds.Tables("InformationForm").Rows(i)(2) = TextBox3.Text Then

        '            TextBox1.Text = ds.Tables("InformationForm").Rows(i)(0).ToString
        '            TextBox2.Text = ds.Tables("InformationForm").Rows(i)(1).ToString
        '            TextBox3.Text = ds.Tables("InformationForm").Rows(i)(2).ToString
        '            TextBox4.Text = ds.Tables("InformationForm").Rows(i)(3).ToString
        '            TextBox5.Text = ds.Tables("InformationForm").Rows(i)(4).ToString
        '            TextBox6.Text = ds.Tables("InformationForm").Rows(i)(5).ToString
        '            TextBox7.Text = ds.Tables("InformationForm").Rows(i)(6).ToString
        '            TextBox8.Text = ds.Tables("InformationForm").Rows(i)(7).ToString
        '            TextBox9.Text = ds.Tables("InformationForm").Rows(i)(8).ToString
        '            TextBox10.Text = ds.Tables("InformationForm").Rows(i)(9).ToString

        '        End If
        '    Next
        'End If
        'cn.Close()




        cn.Open()
        str = "select * from InformationForm"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "InformationForm")
        ctr = ds.Tables("InformationForm").Rows.Count - 1
        For i = 0 To ctr
            ComboBox2.Items.Add(ds.Tables("InformationForm").Rows(i)(2).ToString)

        Next
        cn.Close()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            DateTimePicker1.Visible = False
            ComboBox1.Visible = False
            Dim i = 0, ctr As Integer
            cn.Open()
            str = "select * from InformationForm "
            cmd = New SqlCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "InformationForm")
            ctr = ds.Tables("InformationForm").Rows.Count - 1
            For i = 0 To ctr

                If TextBox3.Text = ds.Tables("InformationForm").Rows(i)(2).ToString Then

                    TextBox1.Text = ds.Tables("InformationForm").Rows(i)(0).ToString
                    TextBox2.Text = ds.Tables("InformationForm").Rows(i)(1).ToString
                    TextBox3.Text = ds.Tables("InformationForm").Rows(i)(2).ToString
                    TextBox4.Text = ds.Tables("InformationForm").Rows(i)(3).ToString
                    TextBox5.Text = ds.Tables("InformationForm").Rows(i)(4).ToString
                    TextBox6.Text = ds.Tables("InformationForm").Rows(i)(5).ToString
                    TextBox7.Text = ds.Tables("InformationForm").Rows(i)(6).ToString
                    TextBox8.Text = ds.Tables("InformationForm").Rows(i)(7).ToString
                    TextBox9.Text = ds.Tables("InformationForm").Rows(i)(8).ToString
                    TextBox10.Text = ds.Tables("InformationForm").Rows(i)(9).ToString
                    TextBox11.Text = ds.Tables("InformationForm").Rows(i)(10).ToString


                End If
            Next

        Catch ex As Exception
            MsgBox("Insert PRN First.")

        End Try

        Try
            cmd = New SqlCommand
            cmd.CommandText = "select image from Photos where prn = " & TextBox3.Text & ""
            cmd.Parameters.AddWithValue("@prn", TextBox3.Text)
            If cn.State = ConnectionState.Closed Then
                cn.Open()

            End If
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Photos1 = dr(0)
                PictureBox1.Load("photo.jpg")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
            dr.Close()
        End Try
    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        PictureBox1.Refresh()
        ComboBox2.ResetText()
        ComboBox1.ResetText()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        SearchForm.Show()
        SearchForm.TextBox1.Text = TextBox3.Text
        SearchForm.TextBox2.Text = TextBox1.Text
        SearchForm.TextBox3.Text = TextBox8.Text
        SearchForm.PictureBox1.Image = PictureBox1.Image




    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Close()

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try


            cn.Open()
            str = " update InformationForm set name = '" & TextBox1.Text & "', address = '" & TextBox2.Text & "', email = '" & TextBox4.Text & "', sphno = " & TextBox5.Text & " , dob = " & DateTimePicker1.Value & " , gender = '" & ComboBox1.Text & "' , course = '" & TextBox8.Text & "' , pphno = " & TextBox9.Text & " , docatach = '" & TextBox10.Text & "',class = '" & TextBox11.Text & "' where prn = " & TextBox3.Text & " "
            cmd = New SqlCommand(str, cn)
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            cn.Close()
            MsgBox("Record Updated.")
        Catch ex As Exception
            MsgBox("Enter PRN first.")
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        DateTimePicker1.Visible = False
        ComboBox1.Visible = False

        clear()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox3.Text = ComboBox2.Text
    End Sub
End Class