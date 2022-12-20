Public Class Students

    Dim student As Student
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        student = New Student(1, "GAMLIGO", "Charles Dieu-Donné", CDate("03/03/03"), Student.genders.M, "gamligocharles@gmail.com", "+228 98676615", "/home/mawena/dums.jpg", 1)
        LBL_VIEW.Text = student.ToString()
    End Sub
End Class