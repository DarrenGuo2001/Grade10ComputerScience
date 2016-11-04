Module Module1

    Declare Function GetAsyncKeyState Lib "user32" _
        (ByVal vKey As Long) As Integer
    Declare Sub Sleep Lib "kernel32" Alias "Sleep" _
        (ByVal dwMilliseconds As Long)

    Sub Main()

        'I will be making a maze game


        'Customizing the window

        Console.Title = "Interaction Project"
        Console.WindowWidth = 70
        Console.WindowHeight = 30
        Console.BufferWidth = Console.WindowWidth
        Console.BufferHeight = Console.WindowHeight
        Console.BackgroundColor = ConsoleColor.Gray
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red


        'Welcoming the user

        'Dim username As String
        'Console.SetCursorPosition(25, 12)
        'Console.Write("Hello, what is your name? ")
        'Console.SetCursorPosition(34, 14)
        'username = Console.ReadLine()
        'Console.Clear()
        'Console.SetCursorPosition(20, 12)
        'Console.Write("Hi there, " + username + "," + " Welcome to Maze Game!")
        'Sleep(2000)


        'Making the main menu

        Console.Clear()
        Console.SetCursorPosition(33, 5)
        Console.Write("Maze Game")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.SetCursorPosition(35, 10)
        Console.Write("Play")
        Console.SetCursorPosition(33, 12)
        Console.Write("(Press 1)")
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.SetCursorPosition(31, 16)
        Console.Write("Select Arena")
        Console.SetCursorPosition(33, 18)
        Console.Write("(Press 2)")
        Console.CursorVisible = False


        'Detecting what the user chooses

loopstartMenu:

        If GetAsyncKeyState(49) Then

            GoTo PlayMenu

        ElseIf GetAsyncKeyState(50) Then

            GoTo SelectArena

        End If

        GoTo loopstartMenu


        'Play Menu

PlayMenu:

        Console.BackgroundColor = ConsoleColor.Gray
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        Console.SetCursorPosition(34, 5)
        Console.Write("Controls")
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.SetCursorPosition(29, 9)
        Console.Write("Up Arrow = move up")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.SetCursorPosition(27, 12)
        Console.Write("Down Arrow = move down")
        Console.ForegroundColor = ConsoleColor.Green
        Console.SetCursorPosition(27, 15)
        Console.Write("Left Arrow = move left")
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.SetCursorPosition(26, 18)
        Console.Write("Right Arrow = move right")
        Console.SetCursorPosition(36, 21)
        Console.ForegroundColor = ConsoleColor.Red
        Console.SetCursorPosition(28, 24)
        Console.Write("Press Space to start")


        'Checking if the user selects play

Play:
        If GetAsyncKeyState(32) Then

            GoTo Arena1

        End If

        GoTo Play


        'Making the arena menu

SelectArena:

        Console.BackgroundColor = ConsoleColor.Gray
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        Console.SetCursorPosition(30, 2)
        Console.Write("Select Arena")
        Console.SetCursorPosition(32, 8)
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("Arena 1")
        Console.SetCursorPosition(31, 10)
        Console.Write("(Press 3)")
        Console.SetCursorPosition(32, 14)
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.Write("Arena 2")
        Console.SetCursorPosition(31, 16)
        Console.Write("(Press 4)")

loopstartArena:

        If GetAsyncKeyState(51) Then

            GoTo Arena1

        ElseIf GetAsyncKeyState(52) Then

            GoTo Arena2

        End If

        GoTo loopstartArena

Arena:

        GoTo Arena


        'Making the different arenas

Arena1:

        Console.BackgroundColor = ConsoleColor.White
        Console.Clear()


        'X and Y control the movement of the *

        Dim x As Integer = 3
        Dim y As Integer = 15
        Const obstacle_x = 4 'x starts from
        Const obstacle_y = 9 'y start from
        Const obstacle_size = 4 'Size of the first obstacle

loopstart2:

        'Clearing the trail of the *

        Console.Clear()
        Console.CursorVisible = False

        'Writing "Level 1"

        Console.SetCursorPosition(30, 3)
        Console.Write("Level 1")

        'Drawing the * and the obstacles

        Console.SetCursorPosition(x, y)
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write("*")
        Console.BackgroundColor = ConsoleColor.Red
        Console.SetCursorPosition(obstacle_x, obstacle_y)

        'Drawing the first obstacle

        For i = 0 To obstacle_size
            Console.SetCursorPosition(obstacle_x, obstacle_y + i)
            Console.Write(Space(2 * (obstacle_size - 1)))
        Next

        Console.BackgroundColor = ConsoleColor.White

        'Drawing the second obstacle

        Console.BackgroundColor = ConsoleColor.Red
        Console.SetCursorPosition(17, 15)
        Console.Write(Space(5))
        Console.SetCursorPosition(17, 16)
        Console.Write(Space(5))
        Console.BackgroundColor = ConsoleColor.White

        'Drawing the third obstacle

        Console.BackgroundColor = ConsoleColor.Red
        Console.SetCursorPosition(28, 10)
        Console.Write(Space(5))
        Console.SetCursorPosition(28, 11)
        Console.Write(Space(5))
        Console.BackgroundColor = ConsoleColor.White

        'Drawing the fourth obstacle

        Console.BackgroundColor = ConsoleColor.Red
        Console.SetCursorPosition(32, 20)
        Console.Write(Space(5))
        Console.SetCursorPosition(32, 21)
        Console.Write(Space(5))
        Console.BackgroundColor = ConsoleColor.White

        'Drawing the fifth obstacle

        Console.BackgroundColor = ConsoleColor.Red
        Console.SetCursorPosition(45, 12)
        Console.Write(Space(5))
        Console.SetCursorPosition(45, 13)
        Console.Write(Space(5))
        Console.BackgroundColor = ConsoleColor.White

        'Drawing the finish line

        Console.BackgroundColor = ConsoleColor.Blue

        For i = 0 To 29
            Console.SetCursorPosition(65, i)
            Console.Write(Space(2))
        Next

        Console.BackgroundColor = ConsoleColor.White

        'Step 4

        Sleep(60)

        'Movement

        If GetAsyncKeyState(37) Then ' Left arrow
            x = x - 1
        ElseIf GetAsyncKeyState(39) Then ' Right arrow
            x = x + 1
        ElseIf GetAsyncKeyState(38) Then ' Up arrow
            y = y - 1
        ElseIf GetAsyncKeyState(40) Then ' Down arrow
            y = y + 1
        End If


        'Making the borders

        If x = -1 Then x = 0
        If x = 70 Then x = 69
        If y = -1 Then y = 0
        If y = 30 Then y = 29

        'If the user reaches the end of the level

        If x = 65 Then
            GoTo Finish
        End If

        'If the user hits the obstacles

        'Obstacle 1
        If x >= obstacle_x And x <= 2 * obstacle_size And y >= obstacle_y And y <= obstacle_y + obstacle_size Then GoTo endprogram

        'Obstacle 2


        GoTo loopstart2

Finish:

        GoTo Finish
endprogram:

        Console.Clear()
        Sleep(500)
        Console.SetCursorPosition(32, 5)
        Console.Write("Game Over!")
        Console.SetCursorPosition(28, 10)

EndGame:

        Console.SetCursorPosition(25, 10)
        Sleep(500)
        'Console.Write("Thanks for playing " & username)

GameEnd:

        GoTo GameEnd

Arena2:

        Console.BackgroundColor = ConsoleColor.Cyan
        Console.Clear()
Arena4:

        GoTo Arena4

    End Sub

End Module