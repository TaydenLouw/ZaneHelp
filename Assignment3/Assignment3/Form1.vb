Imports System.IO
Imports System.Linq
Public Class Form1
    'Assume only 12 months at a time
    Private salesFigures As Double(,) = New Double(3, 13) {}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fileReader = New StreamReader("data.csv")
        Dim headings = fileReader.ReadLine().Split(",")
        Dim index = 0
        While (Not fileReader.EndOfStream And index < 12)
            Dim monthlySales = fileReader.ReadLine().Split(",")
            salesFigures(0, index) = Double.Parse(monthlySales(1))
            salesFigures(1, index) = Double.Parse(monthlySales(2))
            salesFigures(2, index) = Double.Parse(monthlySales(3))
        End While
        For province = 0 To 2
            For monthOfYear = 0 To 11
                salesFigures(province, 12) += salesFigures(province, monthOfYear)
            Next
        Next
        Dim totalSales = salesFigures(0, 12) + salesFigures(1, 12) + salesFigures(2, 12)
        ListBox1.Items.Add("Sales report")
        ListBox1.Items.Add(String.Format("{0,-20}{1,20}{2,20}{3,20}", "Value", "Kwa-Zulu Natal", "Gauteng", "Western Cape"))
        ListBox1.Items.Add(String.Format("{0,-20}{1,20:C}{2,20:C}{3,20:C}", "Total", salesFigures(0, 12), salesFigures(1, 12), salesFigures(2, 12)))
        ListBox1.Items.Add(String.Format("{0,-20}{1,20:P0}{2,20:P0}{3,20:P0}", "Percentage", (salesFigures(0, 12) / totalSales), (salesFigures(1, 12) / totalSales), (salesFigures(2, 12) / totalSales)))
    End Sub
End Class
