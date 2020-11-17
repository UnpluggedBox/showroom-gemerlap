Imports System.Data.SqlClient

Public Class MainPage
    Public isMaximized As Boolean = False
    Public isLoggedin As Boolean = False
    Public isAdmin As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim carData As New SHOWROOMDataSetTableAdapters.MsMobilTableAdapter
        Dim carName As SHOWROOMDataSet.MsMobilDataTable = carData.GetData

        Dim xCoord As Integer = 0
        Dim yCoord As Integer = 120

        For x As Integer = 0 To carData.GetCarCount - 1

            Dim carImageName As String = carName.Rows(x).Item(5)
            Dim carImages As New Button
            With carImages
                .Name = carName.Rows(x).Item(0)
                .Image = My.Resources.ResourceManager.GetObject(carImageName)
                .Size = New Size(300, 250)
                .Location = New Point(xCoord * 310 + 80, yCoord)
            End With

            If xCoord = 3 Then
                xCoord = -1
                yCoord += 280
            End If
            xCoord += 1

            AddHandler carImages.Click, Function() loadCarDetail(carImages.Name)

            Me.Controls.Add(carImages)
        Next

        pbLogout.Visible = False
        pbAdminPage.Visible = False
        pbAdminBooking.Visible = False
        pbAdminUserPage.Visible = False
        pbAdminWarna.Visible = False
        pbRefresh.Visible = False
    End Sub

    Function loadCarDetail(xCode As String)
        Dim carDetailPage As New CarDetail
        carDetailPage.carId = xCode
        carDetailPage.ShowDialog()
    End Function

    Private Sub lblCloseApp_Click(sender As Object, e As EventArgs) Handles lblCloseApp.Click
        Me.Close()
    End Sub

    Private Sub lblMinimizeApp_Click(sender As Object, e As EventArgs) Handles lblMinimizeApp.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblFullApp_Click(sender As Object, e As EventArgs) Handles lblFullApp.Click
        If isMaximized = True Then
            isMaximized = False
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
            isMaximized = True
        End If

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

    Private Sub pbRegister_Click(sender As Object, e As EventArgs) Handles pbRegister.Click
        Dim RegisterForm As New RegisterPage
        RegisterPage.ShowDialog()
    End Sub

    Private Sub pbLogout_Click(sender As Object, e As EventArgs) Handles pbLogout.Click
        MessageBox.Show("Goodbye" + Replace(lblNameUser.Text, "Welcome", ""))
        pbLogin.Visible = True
        isLoggedin = False
        isAdmin = False
        lblNameUser.Text = ""
        pbLogout.Visible = False
        pbAdminPage.Visible = False
        pbAdminBooking.Visible = False
        pbAdminUserPage.Visible = False
        pbAdminWarna.Visible = False
        pbRefresh.Visible = False
    End Sub

    Private Sub pbLogin_Click(sender As Object, e As EventArgs) Handles pbLogin.Click
        Dim LoginForm As New LoginPage
        LoginForm.ShowDialog()
    End Sub

    Private Sub pbAdminPage_Click(sender As Object, e As EventArgs) Handles pbAdminPage.Click
        Dim AdminForm As New AdminPage
        AdminForm.ShowDialog()
    End Sub

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        Me.Controls.Clear()
        Me.InitializeComponent()

        Dim carData As New SHOWROOMDataSetTableAdapters.MsMobilTableAdapter
        Dim carName As SHOWROOMDataSet.MsMobilDataTable = carData.GetData

        Dim xCoord As Integer = 0
        Dim yCoord As Integer = 120

        For x As Integer = 0 To carData.GetCarCount - 1

            Dim carImageName As String = carName.Rows(x).Item(5)
            Dim carImages As New Button
            With carImages
                .Name = carName.Rows(x).Item(0)
                .Image = My.Resources.ResourceManager.GetObject(carImageName)
                .Size = New Size(300, 250)
                .Location = New Point(xCoord * 310 + 80, yCoord)
            End With

            If xCoord = 3 Then
                xCoord = -1
                yCoord += 280
            End If
            xCoord += 1

            AddHandler carImages.Click, Function() loadCarDetail(carImages.Name)

            Me.Controls.Add(carImages)
        Next

        pbLogin.Visible = False
    End Sub

    Private Sub pbPurchase_Click(sender As Object, e As EventArgs) Handles pbPurchase.Click
        If isLoggedin = False Then
            MessageBox.Show("   Please login first!")
        ElseIf isLoggedin = True And isAdmin = False Then
            Dim BuyForm As New BuyPage
            BuyForm.Fullname = Replace(lblNameUser.Text, "Welcome,", "")
            BuyForm.ShowDialog()
        ElseIf isLoggedin = True And isAdmin = True Then
            MessageBox.Show("   Admin cannot buy cars!")
        End If
    End Sub

    Private Sub pbAdminBooking_Click(sender As Object, e As EventArgs) Handles pbAdminBooking.Click
        Dim AdminBookingForm As New AdminBookingPage
        AdminBookingForm.ShowDialog()
    End Sub

    Private Sub pbAdminUserPage_Click(sender As Object, e As EventArgs) Handles pbAdminUserPage.Click
        Dim AdminUserForm As New AdminUserPage
        AdminUserForm.ShowDialog()
    End Sub

    Private Sub pbAdminWarna_Click(sender As Object, e As EventArgs) Handles pbAdminWarna.Click
        Dim AdminWarnaForm As New AdminWarnaPage
        AdminWarnaForm.ShowDialog()
    End Sub
End Class
