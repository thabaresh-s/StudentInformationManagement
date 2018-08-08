Imports System.Data.SqlClient

Public Class Viewer

    Private Sub Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.conn()
        
      
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Select Case ComboBox1.SelectedIndex
        '   Case 0
        TextBox1.Text = ComboBox1.Text

        If ComboBox1.Items(0) = TextBox1.Text Then
            DataGridView1.ClearSelection()
            ds.Clear()
            cn.Open()
            str = " select * from InformationForm "
            cmd = New SqlCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, " InformationForm")
            cn.Close()
            DataGridView1.DataSource = ds.Tables(0)

            '  Case 1
        ElseIf ComboBox1.Items(1) = TextBox1.Text Then
            DataGridView1.ClearSelection()
            ds.Clear()
            cn.Open()
            str = " select * from Subject "
            cmd = New SqlCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, " Subject")
            cn.Close()
            DataGridView1.DataSource = ds.Tables(0)

            ' Case 2
        ElseIf ComboBox1.Items(2) = TextBox1.Text Then
            DataGridView1.ClearSelection()
            ds.Clear()
            cn.Open()
            str = " select * from ClassDetail "
            cmd = New SqlCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, " ClassDetail")
            cn.Close()
            DataGridView1.DataSource = ds.Tables(0)

            '  Case 3
        ElseIf ComboBox1.Items(3) = TextBox1.Text Then
            DataGridView1.ClearSelection()
            ds.Clear()
            cn.Open()
            str = " select * from Course "
            cmd = New SqlCommand(str, cn)
            da.SelectCommand = cmd
            da.Fill(ds, " Course")
            cn.Close()
            DataGridView1.DataSource = ds.Tables(0)
            ' End Select

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        DataGridView1.Refresh()
        ds.Clear()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()


    End Sub

End Class