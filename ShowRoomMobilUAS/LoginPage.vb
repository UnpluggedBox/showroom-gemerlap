Public Class LoginPage
    Public isMaximized As Boolean = False
    Private Sub lblMinimizeApp_Click(sender As Object, e As EventArgs) Handles lblMinimizeApp.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub lblCloseApp_Click(sender As Object, e As EventArgs) Handles lblCloseApp.Click
        Me.Close()
    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub LoginPage_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub LoginPage_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub LoginPage_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validasi
        If iUsername.Text = "" Then
            MessageBox.Show("Username can't be empty")
            Exit Sub
        End If

        If iPassword.Text = "" Then
            MessageBox.Show("Password can't be empty")
            Exit Sub
        End If

        Dim tableAdapter As New SHOWROOMDataSetTableAdapters.MsUserTableAdapter
        Dim dataTable As SHOWROOMDataSet.MsUserDataTable = tableAdapter.GetDataById(iUsername.Text, iPassword.Text)

        If dataTable IsNot Nothing Then

            If dataTable.Rows.Count = 0 Then
                MessageBox.Show("Username and Password not found")
                Exit Sub

            Else
                Dim userNameValue As String = dataTable.Rows(0).Item(3)
                Dim role As String = dataTable.Rows(0).Item(2)
                MessageBox.Show("   Login Success")
                MainPage.lblNameUser.Text = "Welcome, " + userNameValue
                MainPage.pbLogin.Visible = False
                MainPage.isLoggedin = True
                If role = "Administrator" Then
                    MainPage.pbAdminPage.Visible = True
                    MainPage.pbAdminBooking.Visible = True
                    MainPage.pbAdminUserPage.Visible = True
                    MainPage.pbAdminWarna.Visible = True
                    MainPage.pbRefresh.Visible = True
                    MainPage.isAdmin = True
                End If
                Me.Close()
                MainPage.pbLogout.Visible = True

            End If
        End If

    End Sub


End Class