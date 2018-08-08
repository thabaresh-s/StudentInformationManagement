Imports System.Data.SqlClient
Imports System.IO

Public Class SearchForm
    Dim Photos1() As Byte
    Dim dr As SqlDataReader
    Dim str1 As String

    Private Sub SearchForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Module1.conn()
        cn.Open()
        str = "select * from InformationForm"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "InformationForm")
        ds.Clear()
        ComboBox1.ResetText()

        cn.Close()
        Dim i, ctr As Integer
        cn.Open()
        str = "select * from InformationForm"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "InformationForm")
        ctr = ds.Tables("InformationForm").Rows.Count - 1
        For i = 0 To ctr
            ComboBox1.Items.Add(ds.Tables("InformationForm").Rows(i)(2).ToString)

        Next
        cn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        AddmisionForm1.DateTimePicker1.Visible = False
        AddmisionForm1.ComboBox1.Visible = False
        AddmisionForm1.ComboBox2.Visible = False
        
        AddmisionForm1.TextBox1.Text = TextBox2.Text
        AddmisionForm1.TextBox3.Text = TextBox1.Text
        AddmisionForm1.ComboBox2.Text = TextBox1.Text
        AddmisionForm1.PictureBox1.Image = PictureBox1.Image
        Dim i = 0, ctr As Integer
        cn.Open()

        str = "select * from InformationForm "
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "InformationForm")
        ctr = ds.Tables("InformationForm").Rows.Count - 1
        For i = 0 To ctr

            If AddmisionForm1.TextBox3.Text = ds.Tables("InformationForm").Rows(i)(2).ToString Then

                AddmisionForm1.TextBox1.Text = ds.Tables("InformationForm").Rows(i)(0).ToString
                AddmisionForm1.TextBox2.Text = ds.Tables("InformationForm").Rows(i)(1).ToString
                AddmisionForm1.TextBox3.Text = ds.Tables("InformationForm").Rows(i)(2).ToString
                AddmisionForm1.TextBox4.Text = ds.Tables("InformationForm").Rows(i)(3).ToString
                AddmisionForm1.TextBox5.Text = ds.Tables("InformationForm").Rows(i)(4).ToString
                AddmisionForm1.TextBox6.Text = ds.Tables("InformationForm").Rows(i)(5).ToString
                AddmisionForm1.TextBox7.Text = ds.Tables("InformationForm").Rows(i)(6).ToString
                AddmisionForm1.TextBox8.Text = ds.Tables("InformationForm").Rows(i)(7).ToString
                AddmisionForm1.TextBox9.Text = ds.Tables("InformationForm").Rows(i)(8).ToString
                AddmisionForm1.TextBox10.Text = ds.Tables("InformationForm").Rows(i)(9).ToString
                AddmisionForm1.TextBox11.Text = ds.Tables("InformationForm").Rows(i)(10).ToString
                AddmisionForm1.ComboBox2.Text = ds.Tables("InformationForm").Rows(i)(6).ToString
                AddmisionForm1.ComboBox1.Text = ds.Tables("InformationForm").Rows(i)(2).ToString

            End If
        Next
        cn.Close()
        Me.Hide()
        AddmisionForm1.Show()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim i = 0, ctr As Integer
        cn.Open()

        str = "select * from InformationForm "
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "InformationForm")
        ctr = ds.Tables("InformationForm").Rows.Count - 1
        For i = 0 To ctr

            If TextBox1.Text = ds.Tables("InformationForm").Rows(i)(2).ToString Then

                TextBox1.Text = ds.Tables("InformationForm").Rows(i)(2).ToString
                TextBox2.Text = ds.Tables("InformationForm").Rows(i)(0).ToString
                TextBox3.Text = ds.Tables("InformationForm").Rows(i)(7).ToString

            End If
        Next

        Try
            cmd = New SqlCommand
            cmd.CommandText = "select image,name from Photos where prn = " & TextBox1.Text & ""
            cmd.Parameters.AddWithValue("@prn", TextBox1.Text)
            If cn.State = ConnectionState.Closed Then
                cn.Open()

            End If
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read() Then
                TextBox2.Text = dr(1)
                Photos1 = dr(0)
                File.WriteAllBytes("photo.jpg", Photos1)
                PictureBox1.Load("photo.jpg")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
            dr.Close()

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i = 0
        cn.Open()

        str = "delete * from InformationForm where prn='" & TextBox1.Text & "'"
        cmd = New SqlCommand(str, cn)
        da.SelectCommand = cmd
        cn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)


        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try

            cmd = New SqlCommand
            cmd.CommandText = " insert into Photos values (@image, @prn, @name) "
            cmd.Parameters.AddWithValue("@prn", TextBox1.Text)
            cmd.Parameters.AddWithValue("@name", TextBox2.Text)
            Photos1 = File.ReadAllBytes(OpenFileDialog1.FileName)
            cmd.Parameters.AddWithValue("@image", Photos1)
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            MsgBox("Image Saved.")
            AddmisionForm.PictureBox1.Load(OpenFileDialog1.FileName)
            AddmisionForm.Show()
            Me.Close()


        Catch ex As Exception
            MsgBox("Record Not Found.")

        End Try
        cmd = New SqlCommand
        cn.Close()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.Text
    End Sub
End Class