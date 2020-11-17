Imports System.Data.SqlClient
Imports System.IO

Public Class BuyPage
    Dim connection As New SqlConnection("Server=localhost; Database =SHOWROOM; Integrated Security = true ")

    Public Fullname As String
    Private Sub BuyPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHOWROOMDataSet.MsWarna' table. You can move, or remove it, as needed.
        Me.MsWarnaTableAdapter.Fill(Me.SHOWROOMDataSet.MsWarna)
        'TODO: This line of code loads data into the 'SHOWROOMDataSet.MsMobil' table. You can move, or remove it, as needed.
        Me.MsMobilTableAdapter.Fill(Me.SHOWROOMDataSet.MsMobil)

        lblKetentuan.Text = "Through this application, you can only book the car you want, considering the high price" + Environment.NewLine +
            "Please come to our showroom at Season City Mall 2nd Floor, Number 17 and complete your purchase there." + Environment.NewLine +
            "If you have any questions you can call us at +62878123578420, if not, you can pay by clicking the button below."
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim command As New SqlCommand("insert into MsBooking(Type,Warna,Nama) values(@type,@warna,@nama)", connection)

        command.Parameters.Add("@type", SqlDbType.VarChar).Value = cbTypeMobil.SelectedValue
        command.Parameters.Add("@warna", SqlDbType.VarChar).Value = cbWarna.SelectedValue
        command.Parameters.Add("@nama", SqlDbType.VarChar).Value = Fullname

        ExecuteMyQuery(command, "   Booking successful. Please visit our office to complete the purchase.")
    End Sub

    Public Sub ExecuteMyQuery(MyCommand As SqlCommand, MyMessage As String)

        connection.Open()
        If MyCommand.ExecuteNonQuery = 1 Then
            MessageBox.Show(MyMessage)
        Else
            MessageBox.Show("Query Not Executed")
        End If

        connection.Close()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lblMinimizeApp_Click(sender As Object, e As EventArgs) Handles lblMinimizeApp.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub lblCloseApp_Click(sender As Object, e As EventArgs) Handles lblCloseApp.Click
        Me.Close()
    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub BuyPage_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub BuyPage_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub BuyPage_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

End Class