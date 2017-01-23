Public Class Game

    Dim paint_count As Integer = 0
    Dim game_score As Integer

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        paint_count = paint_count + 1

        ' Clear screen with green background

        e.Graphics.Clear(Color.LimeGreen)


        Dim x As Integer 'x will hold a random number 
        Dim y As Integer 'y will hold a random number 

        Randomize()

        x = random_int(50, 300)
        y = random_int(50, 300)

        ' Writing the user's game score at the bottom of the screen

        Dim fontObj As Font = New System.Drawing.Font("Arial", 14, FontStyle.Bold)

        e.Graphics.DrawString(CStr(game_Score), fontObj, Brushes.Red, 315, 290)


    End Sub

    Private Sub Mole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mole.Click

        game_score = game_score + 1

        Mole.Location = New Point(random_int(0, Me.Size.Width - Me.Mole.Size.Width), random_int(0, Me.Size.Height - Me.Mole.Size.Height))
        Refresh()


    End Sub

    Function random_int(ByVal small As Integer, ByVal big As Integer) As Integer

        Return Int(Rnd() * (big - small + 1)) + small

    End Function
End Class