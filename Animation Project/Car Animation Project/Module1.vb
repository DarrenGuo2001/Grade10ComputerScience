Module Module1

    Declare Sub Sleep Lib "kernel32" Alias "Sleep" _
   (ByVal dwMilliseconds As Long)

    Sub Main()

        'x Controls the movement of the cloud
        Dim x As Integer
        x = 12


        'y controls the movement of the rocket
        Dim y As Integer
        y = 19


        Console.Title = "Animation Project"
        Console.WindowWidth = 75
        Console.WindowHeight = 50
        Console.BufferWidth = Console.WindowWidth
        Console.BufferHeight = Console.WindowHeight


        'Making the first world

        Console.BackgroundColor = ConsoleColor.DarkCyan
        Console.Clear()
        Console.SetCursorPosition(0, 40)
        Console.BackgroundColor = ConsoleColor.Green
        Console.Write(Space(800))
        Console.SetCursorPosition(5, 4)
        Console.BackgroundColor = ConsoleColor.Yellow
        Console.Write(Space(9))

        For i As Integer = 5 To 8
            Console.SetCursorPosition(5, i)
            Console.Write(Space(9))
        Next


        'Making the launchpad

        'loopstart
        Console.BackgroundColor = ConsoleColor.Black
        Console.SetCursorPosition(22, 26)
        For j = 26 To 38
            Console.SetCursorPosition(22, j)
            Console.Write(Space(4))
        Next

        Console.SetCursorPosition(22, 24)
        Console.Write(Space(12))
        Console.SetCursorPosition(22, 25)
        Console.Write(Space(12))


        'Making and moving the cloud

loopstartCloud:

        'Re-paint the corner of the sun
        Console.SetCursorPosition(10, 8)
        Console.BackgroundColor = ConsoleColor.Yellow
        Console.Write(Space(4))

        'Covering the trail of the cloud

        Console.BackgroundColor = ConsoleColor.DarkCyan

        For i = 8 To 11
            Console.SetCursorPosition(x, i)
            Console.Write(Space(100))
        Next
       

        x = x + 1

        Console.ForegroundColor = ConsoleColor.Gray
        Console.BackgroundColor = ConsoleColor.White
        Console.SetCursorPosition(x, 8)
        Console.Write("_  _")
        Console.SetCursorPosition(x, 9)
        Console.Write("( `   )_")
        Console.SetCursorPosition(x - 1, 10)
        Console.Write("(    )    `)")
        Console.SetCursorPosition(x - 1, 11)
        Console.Write("(_   (_ .  _)")
        Sleep(30)

        If x = 63 Then GoTo programendCloud

        GoTo loopstartCloud

programendCloud:

        'Writing over the cloud
        Console.BackgroundColor = ConsoleColor.DarkCyan
        For i = 8 To 11
            Console.SetCursorPosition(50, i)
            Console.Write(Space(300))
        Next


        'Making and launching the rocket

loopstartRocket:
        Console.BackgroundColor = ConsoleColor.DarkCyan
        For i = 34 To 49
            Console.SetCursorPosition(35, i)
            Console.Write(Space(100))
        Next

        Console.BackgroundColor = ConsoleColor.Red
        Console.ForegroundColor = ConsoleColor.Red
        Console.SetCursorPosition(38, y)
        Console.Write("/\")
        Console.SetCursorPosition(37, y + 1)
        Console.Write("/  \")
        Console.SetCursorPosition(36, y + 2)
        Console.Write("/    \")
        Console.SetCursorPosition(35, y + 3)
        Console.Write("/      \")
        Console.SetCursorPosition(34, y + 4)
        Console.Write("/        \")

        Console.BackgroundColor = ConsoleColor.DarkGray

        For i = 5 To 17
            Console.SetCursorPosition(34, y + i)
            Console.Write(Space(10))

        Next

        Console.BackgroundColor = ConsoleColor.Black
        Console.SetCursorPosition(37, y + 7)
        Console.Write(Space(4))
        Console.SetCursorPosition(37, y + 8)
        Console.Write(Space(4))

        Console.BackgroundColor = ConsoleColor.Red
        For i = 0 To 4
            Console.SetCursorPosition(32, y + 15 + i)
            Console.Write(Space(1))
        Next

        For i = 0 To 6
            Console.SetCursorPosition(33, y + 13 + i)
            Console.Write(Space(1))
        Next

        For i = 0 To 4
            Console.SetCursorPosition(45, y + 15 + i)
            Console.Write(Space(1))
        Next

        For i = 0 To 6
            Console.SetCursorPosition(44, y + 13 + i)
            Console.Write(Space(1))
        Next

        y = y - 1

        If y = 1 Then GoTo programendRocket

        Sleep(50)
        GoTo loopstartRocket

programendRocket:


        'Making the countdown

        ' '' '' '' ''Console.SetCursorPosition(28, 10)
        ' '' '' '' ''Console.BackgroundColor = ConsoleColor.DarkCyan
        ' '' '' '' ''Console.ForegroundColor = ConsoleColor.Red
        ' '' '' '' ''Console.Write("Liftoff in T-5 seconds")
        ' '' '' '' ''Sleep(1500)
        ' '' '' '' ''Console.SetCursorPosition(28, 10)
        ' '' '' '' ''Console.Write(Space(22))
        ' '' '' '' ''Console.ForegroundColor = ConsoleColor.Red
        ' '' '' '' ''Console.SetCursorPosition(39, 10)
        ' '' '' '' ''Console.Write("5")
        ' '' '' '' ''Console.Beep(1400, 250)
        ' '' '' '' ''Sleep(1000)
        ' '' '' '' ''Console.SetCursorPosition(39, 10)
        ' '' '' '' ''Console.Write("4")
        ' '' '' '' ''Console.Beep(1400, 250)
        ' '' '' '' ''Sleep(1000)
        ' '' '' '' ''Console.SetCursorPosition(39, 10)
        ' '' '' '' ''Console.Write("3")
        ' '' '' '' ''Console.Beep(1400, 250)
        ' '' '' '' ''Sleep(1000)
        ' '' '' '' ''Console.SetCursorPosition(39, 10)
        ' '' '' '' ''Console.Write("2")
        ' '' '' '' ''Console.Beep(1400, 250)
        ' '' '' '' ''Sleep(1000)
        ' '' '' '' ''Console.SetCursorPosition(39, 10)
        ' '' '' '' ''Console.Write("1")
        ' '' '' '' ''Console.Beep(1400, 250)
        ' '' '' '' ''Sleep(1000)
        ' '' '' '' ''Console.SetCursorPosition(35, 10)
        ' '' '' '' ''Console.Write("Takeoff!")


    End Sub

End Module
