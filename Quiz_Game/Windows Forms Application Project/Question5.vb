Public Class Question5

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        ' Checking if the user selected the right answer

        If rb9.Checked Then

            GameScore = GameScore + 1 ' If right answer was selected, the user gains a point

        End If

        ' Showing the next question

        Me.Hide()
        EndQuiz.Show()

    End Sub
End Class