Public Class MenuForm
    Dim bill As Decimal = 0.0
    Public Const chicken As Decimal = 4.25
    Public Const rigatoni As Decimal = 5.75
    Public Const lobster As Decimal = 4.75
    Public Const tuna As Decimal = 5.5
    Public Const fries As Decimal = 2.0
    Public Const salad As Decimal = 2.75
    Public Const tortilla As Decimal = 3.5
    Public Const rice As Decimal = 2.5
    Public Const water As Decimal = 1.0
    Public Const soda As Decimal = 2.0
    Public Const tea As Decimal = 1.5
    Public Const shake As Decimal = 2.5
    Public Const kueh As Decimal = 3.0
    Public Const pie As Decimal = 2.5

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        If chkChicken.Checked Then
            bill += chicken
        End If
        If chkRigatoni.Checked Then
            bill += rigatoni
        End If
        If chkLobster.Checked Then
            bill += lobster
        End If
        If chkTuna.Checked Then
            bill += tuna
        End If
        If chkFries.Checked Then
            bill += fries
        End If
        If chkSalad.Checked Then
            bill += salad
        End If
        If chkTortilla.Checked Then
            bill += tortilla
        End If
        If chkWater.Checked Then
            bill += water
        End If
        If chkSoda.Checked Then
            bill += soda
        End If
        If chkTea.Checked Then
            bill += tea
        End If
        If chkShake.Checked Then
            bill += shake
        End If
        If chkKueh.Checked Then
            bill += kueh
        End If
        If chkPie.Checked Then
            bill += pie
        End If
        Dim input As String = Nothing
        input = InputBox("Your total is: $" & bill & ". Would you like to be in our database for future visits?", "Total Bill", , , )
        If input = "Yes" Then
            'Add to database
        ElseIf input = "No" Then
            MessageBox.Show("Thank you for coming to Pateli's!")
        Else
            InputBox("Sorry, I didn't catch that. Did you want to be in our database? It makes visits much easier!")
            If input = "Yes" Then
                'Add to database
            Else
                MessageBox.Show("Thank you for coming to Pateli's!")
            End If
        End If
        Close()

    End Sub
End Class