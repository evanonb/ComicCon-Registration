Public Class frmComicCon
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' This event handler is executed when the user clicks the Calcualte Button.
        ' It calculates the total registration cost.

        ' Declaration section
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D

        ' Did user enter a numeric value?
        If IsNumeric(txtInput.Text) Then
            intGroup = Convert.ToInt32(txtInput.Text)
            ' Is number of group between zero and twenty?
            If intGroup > 0 And intGroup < 21 Then
                'Calculate and display cost
                If radSuperHero.Checked Then
                    decRegistration = decSuperHero
                ElseIf radAutographs.Checked Then
                    decRegistration = decAutographs
                ElseIf radConvention.Checked Then
                    decRegistration = decConvention
                End If

                decTotalCost = (intGroup * decRegistration)
                txtTotalCost.Text = decTotalCost.ToString("C")
            Else
                ' Display error message if user entered a negative number
                MsgBox("Enter a positive number between 1 and 20", , "Invalid Number Error")
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter a reasonable number between 1 and 20", , "Invalid Entry Error")
        End If
    End Sub

    Private Sub frmComicCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the Comic Convention Form is loaded
        radSuperHero.Checked = True
        txtTotalCost.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        txtTotalCost.Text = ""
        radSuperHero.Checked = True
        radAutographs.Checked = False
        radConvention.Checked = False
        txtInput.Focus()
    End Sub
End Class
