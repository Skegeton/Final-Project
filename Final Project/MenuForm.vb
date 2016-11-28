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
        If radChicken.Checked Then
            bill += chicken
        End If
        If radRigatoni.Checked Then
            bill += rigatoni
        End If
        If radLobster.Checked Then
                bill += lobster
            End If
            If radTuna.Checked Then
                    bill += tuna
                End If
                If radFries.Checked Then
                        bill += fries
                    End If
                    If radSalad.Checked Then
                            bill += salad
                        End If
                        If radTortilla.Checked Then
                                bill += tortilla
                            End If
                            If radRice.Checked Then
                                    bill += rice
                                End If
                                If radWater.Checked Then
                                        bill += water
                                    End If
                                    If radSoda.Checked Then
                                            bill += soda
                                        End If
                                        If radTea.Checked Then
                                                bill += tea
                                            End If
                                            If radShake.Checked Then
                                                    bill += shake
                                                End If
                                                If radKueh.Checked Then
                                                        bill += kueh
                                                    End If
                                                    If radPie.Checked Then
                                                            bill += pie
                                                        End If
        MessageBox.Show("Your total is: $" & bill)
        MessageBox.Show("Thank you for coming to Pateli's!")
        Close()

    End Sub
End Class