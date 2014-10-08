Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click


        Dim population As Double = 7000
        Dim year As Integer = 2014

        Do Until population < 6
            population = population / 2
            year = year - 50
        Loop

        MessageBox.Show("The answer is " & year)
    End Sub
End Class
