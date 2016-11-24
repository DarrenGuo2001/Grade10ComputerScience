Module Module1

    Declare Function GetAsyncKeyState Lib "user32" _
        (ByVal vKey As Long) As Integer
    Declare Sub Sleep Lib "kernel32" Alias "Sleep" _
        (ByVal dwMilliseconds As Long)

    Sub Main()

        'I will be making a maze game

        Dim username As String 'username will hold the user's username

        Dim r As Integer 'r will hold a random number that will be part of the user's username

        Randomize()

        'Customizing the window

        Console.Title = "Interaction Project 2.0"
        Console.WindowWidth = 70
        Console.WindowHeight = 30
        Console.BufferWidth = Console.WindowWidth
        Console.BufferHeight = Console.WindowHeight
        Console.BackgroundColor = ConsoleColor.Gray
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red

        'Welcoming the user

        Console.SetCursorPosition(25, 12)
        Console.Write("Hello, what is your name? ")

        'Generating one random number between 1 and 10

        username = Console.ReadLine()
        r = random_int(1, 10)
        Console.SetCursorPosition(34, 14)
        Console.Clear()
        Console.SetCursorPosition(18, 12)

        'Giving the user a username with a random number

        Console.Write("Hi there, " & username & " your username will be ")
        Console.SetCursorPosition(21, 14)
        Console.Write(username & r & "" & " Welcome to Maze Game!")
        Sleep(1500)

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

        Do

            If GetAsyncKeyState(49) Then  'If user presses 1

                Play_Menu() 'Call Play_Menu

            ElseIf GetAsyncKeyState(50) Then  'If user presses 2

                Arena_Menu() 'Call Arena_Menu

            End If

        Loop

        'If the spacebar is pressed, the user will be directed to the first level of the game

        Do

            If GetAsyncKeyState(32) Then  'If user presses spacebar

                Level_1()

            End If

        Loop

        'Detecting which arena the user chooses

        Do

            If GetAsyncKeyState(51) Then  'If user presses 3

                Level_1()

            ElseIf GetAsyncKeyState(52) Then  'If user presses 4

                Level_1()

            End If

        Loop

    End Sub

    Sub Level_1()

        'Making the first level in the game


        Console.BackgroundColor = ConsoleColor.White
        Console.Clear()

        'X and Y control the movement of the character

        'User starts at (3, 15)

        Dim x As Integer = 3 'left and right
        Dim y As Integer = 15 'up and down

        Do

            Console.CursorVisible = False

            'Writing "Level 1"

            Console.SetCursorPosition(30, 3)
            Console.Write("Level 1")

            'Drawing the user's character

            Console.SetCursorPosition(x, y)
            Console.BackgroundColor = ConsoleColor.White
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write("*")

            'Drawing the first obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(9, 4)
            Console.Write(Space(5))
            Console.SetCursorPosition(9, 5)
            Console.Write(Space(5))

            'Drawing the second obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(17, 15)
            Console.Write(Space(5))
            Console.SetCursorPosition(17, 16)
            Console.Write(Space(5))

            'Drawing the third obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(28, 10)
            Console.Write(Space(5))
            Console.SetCursorPosition(28, 11)
            Console.Write(Space(5))

            'Drawing the fourth obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(32, 20)
            Console.Write(Space(5))
            Console.SetCursorPosition(32, 21)
            Console.Write(Space(5))

            'Drawing the fifth obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(45, 12)
            Console.Write(Space(5))
            Console.SetCursorPosition(45, 13)
            Console.Write(Space(5))

            'Drawing the sixth obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(9, 23)
            Console.Write(Space(5))
            Console.SetCursorPosition(9, 24)
            Console.Write(Space(5))

            'Drawing the seventh obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(57, 23)
            Console.Write(Space(5))
            Console.SetCursorPosition(57, 24)
            Console.Write(Space(5))

            'Drawing the eigth obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(7, 10)
            Console.Write(Space(5))
            Console.SetCursorPosition(7, 11)
            Console.Write(Space(5))

            'Drawing the ninth obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(57, 4)
            Console.Write(Space(5))
            Console.SetCursorPosition(57, 5)
            Console.Write(Space(5))

            'Drawing the tenth obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(45, 25)
            Console.Write(Space(5))
            Console.SetCursorPosition(45, 26)
            Console.Write(Space(5))

            'Drawing the eleventh obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(25, 25)
            Console.Write(Space(5))
            Console.SetCursorPosition(25, 26)
            Console.Write(Space(5))

            'Drawing the twelth obstacle

            Console.BackgroundColor = ConsoleColor.Red
            Console.SetCursorPosition(48, 19)
            Console.Write(Space(5))
            Console.SetCursorPosition(48, 20)
            Console.Write(Space(5))

            'Drawing the finish line

            Console.BackgroundColor = ConsoleColor.Blue

            For i = 0 To 29
                Console.SetCursorPosition(65, i)
                Console.Write(Space(2))
            Next

            Console.BackgroundColor = ConsoleColor.White

            'Pausing before clearing the screen

            Sleep(60)

            'Movement of the user's character

            If GetAsyncKeyState(37) Then ' Left arrow
                x = x - 1
            ElseIf GetAsyncKeyState(39) Then ' Right arrow
                x = x + 1
            ElseIf GetAsyncKeyState(38) Then ' Up arrow
                y = y - 1
            ElseIf GetAsyncKeyState(40) Then ' Down arrow
                y = y + 1
            End If

            'If the user reaches any edge of the screen

            If x = -1 Then x = 0 'left side
            If x = 70 Then x = 69 'right side
            If y = -1 Then y = 0 'top
            If y = 30 Then y = 29 'bottom

            'If the user reaches the finish line

            If x = 65 Then
                End_Game()
            End If

            'If the user hits any of the obstacles

            'If user hits obstacle 1

            If x <= 13 And x >= 9 And y >= 4 And y <= 5 Then
                End_Game()
            End If

            'If user hits obstacle 2

            If x <= 21 And x >= 17 And y >= 15 And y <= 16 Then
                End_Game()
            End If

            'If user hits obstacle 3

            If x <= 32 And x >= 28 And y >= 10 And y <= 11 Then
                End_Game()
            End If

            'If user hits obstacle 4

            If x <= 36 And x >= 32 And y >= 20 And y <= 21 Then
                End_Game()
            End If

            'If user hits obstacle 5

            If x <= 49 And x >= 45 And y >= 12 And y <= 13 Then
                End_Game()
            End If

            'If user hits obstacle 6

            If x <= 13 And x >= 9 And y >= 23 And y <= 24 Then
                End_Game()
            End If

            'If user hits obstacle 7

            If x <= 61 And x >= 57 And y >= 23 And y <= 24 Then
                End_Game()
            End If

            'If user hits obstacle 8

            If x <= 11 And x >= 7 And y >= 10 And y <= 11 Then
                End_Game()
            End If

            'If user hits obstacle 9

            If x <= 61 And x >= 57 And y >= 4 And y <= 5 Then
                End_Game()
            End If

            'If user hits obstacle 10

            If x <= 49 And x >= 45 And y >= 25 And y <= 26 Then
                End_Game()
            End If

            'If user hits obstacle 11

            If x <= 29 And x >= 25 And y >= 25 And y <= 26 Then
                End_Game()
            End If

            'If user hits obstacle 12

            If x <= 52 And x >= 48 And y >= 19 And y <= 20 Then
                End_Game()
            End If

        Loop

    End Sub

    Sub Play_Menu()

        'Play Menu

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

    End Sub

    Sub Arena_Menu()

        'Making the arena menu

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

    End Sub

    Sub End_Game()

        'If user hits an obstacle

        Console.BackgroundColor = ConsoleColor.White
        Console.Clear()
        Sleep(500)
        Console.SetCursorPosition(32, 5)
        Console.Write("Game Over!")
        Console.SetCursorPosition(28, 10)

    End Sub

    Sub Finish_Game()

        'If user reaches the finish line

        Console.BackgroundColor = ConsoleColor.White
        Console.Clear()
        Console.SetCursorPosition(33, 8)
        Console.Write("Good Job!")
        Console.SetCursorPosition(27, 10)
        'Console.Write("You have won " & username & r)

    End Sub

    Function random_int(ByVal small As Integer, ByVal big As Integer) As Integer

        Return Int(Rnd() * (big - small + 1)) + small

    End Function

End Module



