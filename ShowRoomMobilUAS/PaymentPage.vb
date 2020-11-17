Public Class PaymentPage
    Public carIdDp As String

    Private Sub PaymentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim carData As New SHOWROOMDataSetTableAdapters.MsMobilTableAdapter
        Dim carDpData As SHOWROOMDataSet.MsMobilDataTable = carData.GetCarId(carIdDp)
        ' Dim carDownPayment As Integer = carDpData.Rows(0).Item(4) * 0.05 << Ini ga kebaca datanya
        ' lblDP.Text = CarDetail.testValue << ini jg
    End Sub
End Class