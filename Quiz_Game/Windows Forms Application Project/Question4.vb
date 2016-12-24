Public Class Question4

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        ' Checking if the user selected the right answer

        If rb70.Checked Then

            GameScore = GameScore + 1 ' If right answer was selected, the user gains a point

        End If

        ' Showing the next question

        Me.Hide()
        Question5.Show()

    End Sub

End Class