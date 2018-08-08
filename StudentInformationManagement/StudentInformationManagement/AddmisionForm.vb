Imports System.Data.SqlClient
Public Class AddmisionForm
    Dim Photos1() As Byte
    Dim dr As SqlDataReader
    Dim str1 As String

    Private Sub AddmisionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Visible = True
        ComboBox1.Visible = True
        ComboBox2.Visible = True



        Module1.conn()
        cn.Open()
        str = "select * from ClassDetail"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "ClassDetail")

        cn.Close()

        Dim i, ctr As Integer
        cn.Open()
        str = "select * from ClassDetail"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "ClassDetail")
        ctr = ds.Tables("ClassDetail").Rows.Count - 1
        For i = 0 To ctr
            ComboBox3.Items.Add(ds.Tables("ClassDetail").Rows(i)(1).ToString)

        Next
        cn.Close()
        'cn.Open()
        'str = "select * from InformationForm "
        'cmd = New SqlCommand(str, cn)
        'da.SelectCommand = cmd
        'da.Fill(ds, "InformationForm")
        'If ds.Tables("InformationForm").Rows(i)(0) = TextBox1.Text Then
        '    ctr = ds.Tables("InformationForm").Rows.Count - 1
        '    For i = 0 To ctr
        '        If ds.Tables("InformationForm").Rows(i)(0) = TextBox1.Text Then

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
        '            ' TextBox11.Text = GetCurrentAge(DateTimePicker1.Value)
        '            TextBox11.Text = ds.Tables("InformationForm").Rows(i)(10).ToString

        '        End If
        '    Next
        'End If
        'cn.Close()
        'clear()
    End Sub
    

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        TextBox11.Text = Today.Date.Year - DateTimePicker1.Value.Year


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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim en As Integer = 0
        If TextBox1.Text = "" Then
            MsgBox("Please enter the name.")
            en = 1
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please enter the address.")
            en = 1
        ElseIf TextBox3.Text = "" Then
            MsgBox("Please enter the PRN.")
            en = 1
        ElseIf TextBox4.Text = "" Then
            MsgBox("Please enter the Email.")
            en = 1
        ElseIf TextBox5.Text = "" Then
            MsgBox("Please enter the Mobile no.")
            en = 1
        ElseIf TextBox6.Text = "" Then
            MsgBox("Please enter the DOB.")
            en = 1
        ElseIf TextBox7.Text = "" Then
            MsgBox("Please enter the Gender.")
            en = 1

        ElseIf TextBox8.Text = "" Then
            MsgBox("Please enter the Course.")
            en = 1
        ElseIf TextBox9.Text = "" Then
            MsgBox("Please enter the Parent Phone.")
            en = 1
        ElseIf TextBox10.Text = "" Then
            MsgBox("Please enter the Doc.")
            en = 1
        ElseIf TextBox11.Text = "" Then
            MsgBox("Please enter the Age.")
            en = 1
        End If
        Try
            If en = 0 Then


                cn.Open()
                'TextBox11.Text = GetCurrentAge(DateTimePicker1.Value)
                str = "Insert into InformationForm values ('" & TextBox1.Text & "','" & TextBox2.Text & "'," & TextBox3.Text & ",'" & TextBox4.Text & "'," & TextBox5.Text & "," & DateTimePicker1.Value & ",'" & ComboBox1.Text & "','" & ComboBox2.Text & "'," & TextBox9.Text & ",'" & TextBox10.Text & "'," & TextBox11.Text & "," & ComboBox3.Text & ")"
                cmd = New SqlCommand(str, cn)
                da.InsertCommand = cmd
                cmd.ExecuteNonQuery()
                MsgBox(" Record Saved.")
                clear()

                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(" Record Not Saved.")
            'clear()
            cn.Close()
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Close()

    End Sub

    

   

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub
End Class