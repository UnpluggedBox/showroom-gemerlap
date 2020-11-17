Public Class CarDetail
    Public carId As String
    Private Sub CarDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim carData As New SHOWROOMDataSetTableAdapters.MsMobilTableAdapter
        Dim carNameData As SHOWROOMDataSet.MsMobilDataTable = carData.GetCarId(carId)
        Dim carPrice As String = Replace(FormatCurrency(carNameData.Rows(0).Item(4)), "$", "Rp ")
        Dim carDownPayment As Integer = carNameData.Rows(0).Item(4) * 0.05
        Dim carIdPass As String = carNameData.Rows(0).Item(0)
        lblMerkMobil.Text = carNameData.Rows(0).Item(1) + " " + carNameData.Rows(0).Item(2)
        lblDeskripsiMobil.Text = carNameData.Rows(0).Item(3)
        lblHargaMobil.Text = "Price: " + Replace(carPrice, ".00", "")

        pbMobil.Image = My.Resources.ResourceManager.GetObject(carNameData.Rows(0).Item(5))



        'AddHandler btnBuy.Click, Function() passDpValue(carIdPass) di MainPage pake cara ini tp skrg ga bs
    End Sub

    ' Function passDpValue(carDp As String)
    'Dim carPaymentPage As New PaymentPage
    '   PaymentPage.carIdDp = carDp
    '     carPaymentPage.ShowDialog()
    ' End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        If MainPage.isLoggedin = False Then
            MessageBox.Show("   Please login first!")
        ElseIf MainPage.isLoggedin = True And MainPage.isAdmin = False Then
            MessageBox.Show("You can purchase cars from the main page.")
        ElseIf MainPage.isLoggedin = True And MainPage.isAdmin = True Then
            MessageBox.Show("   Admin can't buy cars.")
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

    Private Sub lblCloseApp_Click(sender As Object, e As EventArgs) Handles lblCloseApp.Click
        Me.Close()
    End Sub

    Private Sub lblMinimizeApp_Click(sender As Object, e As EventArgs) Handles lblMinimizeApp.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class