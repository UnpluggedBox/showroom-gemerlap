Imports System.Data.SqlClient
Imports System.IO

Public Class AdminPage
    Dim connection As New SqlConnection("Server=localhost; Database =SHOWROOM; Integrated Security = true ")

    Private Sub AdminPage_Load(sender As Object, e As EventArgs)
        Dim command As New SqlCommand("select * From MsMobil", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.DataSource = table
        DataGridView1.RowTemplate.Height = 50
    End Sub

    Private Sub BTN_INSER_Click(sender As Object, e As EventArgs) Handles BTN_INSER.Click
        Dim command As New SqlCommand("insert into MsMobil(Merk,Type,Deskripsi,Harga,ImagePath) values(@merk,@type,@desc,@harga,@path)", connection)

        command.Parameters.Add("@merk", SqlDbType.VarChar).Value = TextBoxMerk.Text
        command.Parameters.Add("@type", SqlDbType.VarChar).Value = TextBoxType.Text
        command.Parameters.Add("@desc", SqlDbType.VarChar).Value = TextBoxDesc.Text
        command.Parameters.Add("@harga", SqlDbType.Int).Value = TextBoxPrice.Text
        command.Parameters.Add("@path", SqlDbType.VarChar).Value = TextBoxPath.Text
        ExecuteMyQuery(command, "Data berhasil masuk")

    End Sub
    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click

        Dim command As New SqlCommand("UPDATE MsMobil SET Merk = @merk, Type = @type, Deskripsi = @desc, Harga = @harga,ImagePath = @path WHERE IdMobil = @id", connection)

        command.Parameters.Add("@id", SqlDbType.Int).Value = TextBoxID.Text
        command.Parameters.Add("@merk", SqlDbType.VarChar).Value = TextBoxMerk.Text
        command.Parameters.Add("@type", SqlDbType.VarChar).Value = TextBoxType.Text
        command.Parameters.Add("@desc", SqlDbType.VarChar).Value = TextBoxDesc.Text
        command.Parameters.Add("@harga", SqlDbType.Int).Value = TextBoxPrice.Text
        command.Parameters.Add("@path", SqlDbType.VarChar).Value = TextBoxPath.Text

        ExecuteMyQuery(command, "Data berhasil Update")

    End Sub
    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Dim command As New SqlCommand("DELETE FROM MsMobil WHERE IdMobil = @id", connection)

        command.Parameters.Add("@id", SqlDbType.Int).Value = TextBoxID.Text
        ExecuteMyQuery(command, "Data berhasil hapus")

    End Sub

    Public Sub ExecuteMyQuery(MyCommand As SqlCommand, MyMessage As String)

        connection.Open()
        If MyCommand.ExecuteNonQuery = 1 Then
            MessageBox.Show(MyMessage)
        Else
            MessageBox.Show("Query Not Executed")
        End If

        connection.Close()
        populateDataGridView("")
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxMerk.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBoxType.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBoxDesc.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBoxPrice.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBoxPath.Text = DataGridView1.CurrentRow.Cells(5).Value


    End Sub
    Public Sub populateDataGridView(valueToSearch As String)
        Dim command As New SqlCommand("Select * from MsMobil WHERE CONCAT(Merk,Type,Deskripsi,Harga,ImagePath) like '%" & valueToSearch & "%'", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)


        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 50
        DataGridView1.DataSource = table

    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        populateDataGridView(TextBoxSearch.Text)
    End Sub
    Private Sub Button_FIND_Click(sender As Object, e As EventArgs) Handles Button_FIND.Click
        Dim command As New SqlCommand("SELECT * FROM MsMobil WHERE IdMobil = @id", connection)
        command.Parameters.Add("@id", SqlDbType.Int).Value = TextBoxID.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("No Data Found")
        Else
            TextBoxID.Text = table.Rows(0)(0).ToString()
            TextBoxMerk.Text = table.Rows(0)(1).ToString()
            TextBoxType.Text = table.Rows(0)(2).ToString()
            TextBoxDesc.Text = table.Rows(0)(3).ToString()
            TextBoxPrice.Text = table.Rows(0)(4).ToString()
            TextBoxPath.Text = table.Rows(0)(5).ToString()

        End If
    End Sub

    Private Sub lblCloseApp_Click(sender As Object, e As EventArgs) Handles lblCloseApp.Click
        Me.Close()
    End Sub

    Private Sub lblMinimizeApp_Click(sender As Object, e As EventArgs) Handles lblMinimizeApp.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub MainPage_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub MainPage_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub MainPage_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub pbIconAdmin_Click(sender As Object, e As EventArgs) Handles pbIconAdmin.Click
        Me.Close()
    End Sub

End Class