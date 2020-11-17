Public Class RegisterPage


    Private Sub lblMinimizeApp_Click(sender As Object, e As EventArgs) Handles lblMinimizeApp.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub lblCloseApp_Click(sender As Object, e As EventArgs) Handles lblCloseApp.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub RegisterPage_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub RegisterPage_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub RegisterPage_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        'Validasi
        If iPassword.Text = "" Then
            MessageBox.Show("   Password can't be empty")
            Exit Sub
        End If

        If iUsername.Text = "" Then
            MessageBox.Show("   Username can't be empty")
            Exit Sub
        End If

        If iName.Text = "" Then
            MessageBox.Show("Full Name can't be empty")
            Exit Sub
        End If

        Dim tableAdapter As New SHOWROOMDataSetTableAdapters.MsUserTableAdapter

        Dim userId As String = iUsername.Text
        Dim Password As String = iPassword.Text
        Dim Role As String = "Member"
        Dim fullName As String = iName.Text

        tableAdapter.Insert(userId, Password, Role, fullName)

        Dim userNameValue As String = iName.Text
        MessageBox.Show("   Registration success! Welcome, " + userNameValue)
        iUsername.Text = ""
        iPassword.Text = ""
        iName.Text = ""
        Me.Close()

    End Sub
End Class