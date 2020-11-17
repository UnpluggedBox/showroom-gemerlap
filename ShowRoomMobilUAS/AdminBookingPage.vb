Imports System.Data.SqlClient
Imports System.IO
Public Class AdminBookingPage

    Dim connection As New SqlConnection("Server=localhost; Database =SHOWROOM; Integrated Security = true ")

    Private Sub AdminBookingPage_Load(sender As Object, e As EventArgs)
        Dim command As New SqlCommand("select * From MsBooking", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.DataSource = table
        DataGridView1.RowTemplate.Height = 50
    End Sub

    Private Sub BTN_INSER_Click(sender As Object, e As EventArgs) Handles BTN_INSER.Click
        Dim command As New SqlCommand("insert into MsBooking(Type,Warna,Nama) values(@type,@warna,@nama)", connection)

        command.Parameters.Add("@type", SqlDbType.VarChar).Value = TextBoxType.Text
        command.Parameters.Add("@warna", SqlDbType.VarChar).Value = TextBoxWarna.Text
        command.Parameters.Add("@nama", SqlDbType.VarChar).Value = TextBoxNama.Text
        ExecuteMyQuery(command, "Data berhasil masuk")

    End Sub
    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click

        Dim command As New SqlCommand("UPDATE MsBooking SET Type = @type, Warna = @warna, Nama = @nama WHERE IdBooking = @id", connection)

        command.Parameters.Add("@id", SqlDbType.Int).Value = TextBoxID.Text
        command.Parameters.Add("@type", SqlDbType.VarChar).Value = TextBoxType.Text
        command.Parameters.Add("@warna", SqlDbType.VarChar).Value = TextBoxWarna.Text
        command.Parameters.Add("@nama", SqlDbType.VarChar).Value = TextBoxNama.Text

        ExecuteMyQuery(command, "Data berhasil diupdate")

    End Sub
    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Dim command As New SqlCommand("DELETE FROM MsBooking WHERE IdBooking = @id", connection)

        command.Parameters.Add("@id", SqlDbType.Int).Value = TextBoxID.Text
        ExecuteMyQuery(command, "Data berhasil dihapus")

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
        TextBoxType.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBoxWarna.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBoxNama.Text = DataGridView1.CurrentRow.Cells(3).Value

    End Sub
    Public Sub populateDataGridView(valueToSearch As String)
        Dim command As New SqlCommand("Select * from MsBooking WHERE CONCAT(Type,Warna,Nama) like '%" & valueToSearch & "%'", connection)
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
        Dim command As New SqlCommand("SELECT * FROM MsBooking WHERE IdBooking = @id", connection)
        command.Parameters.Add("@id", SqlDbType.Int).Value = TextBoxID.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("No Data Found")
        Else
            TextBoxID.Text = table.Rows(0)(0).ToString()
            TextBoxType.Text = table.Rows(0)(1).ToString()
            TextBoxWarna.Text = table.Rows(0)(2).ToString()
            TextBoxNama.Text = table.Rows(0)(3).ToString()

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