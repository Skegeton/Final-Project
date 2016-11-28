Public Class MenuForm
    Dim bill As Decimal = 0.0
    Dim chicken As Decimal = 4.25
    Dim rigatoni As Decimal = 5.75
    Dim lobster As Decimal = 4.75
    Dim tuna As Decimal = 5.5
    Dim fries As Decimal = 2.0
    Dim salad As Decimal = 2.75
    Dim tortilla As Decimal = 3.5
    Dim rice As Decimal = 2.5
    Dim water As Decimal = 1.0
    Dim soda As Decimal = 2.0
    Dim tea As Decimal = 1.5
    Dim shake As Decimal = 2.5
    Dim kueh As Decimal = 3.0
    Dim pie As Decimal = 2.5

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        If radChicken.Checked Then
            bill += chicken
        ElseIf radRigatoni.Checked Then
            bill += rigatoni
        ElseIf radLobster.Checked Then
            bill += lobster
        ElseIf radTuna.Checked Then
            bill += tuna
        ElseIf radFries.Checked Then
            bill += fries
        ElseIf radSalad.Checked Then
            bill += salad
        ElseIf radTortilla.Checked Then
            bill += tortilla
        ElseIf radRice.Checked Then
            bill += rice
        ElseIf radWater.Checked Then
            bill += water
        ElseIf radSoda.Checked Then
            bill += soda
        ElseIf radTea.Checked Then
            bill += tea
        ElseIf radShake.Checked Then
            bill += shake
        ElseIf radKueh.Checked Then
            bill += kueh
        ElseIf radPie.Checked Then
            bill += pie
        End If
        MessageBox.Show("Your total is: $" & bill)
    End Sub
End Class