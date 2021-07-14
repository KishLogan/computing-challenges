Imports System
Module program
    'N:\Y10\Computing\Programming challenges
    Structure songlist
        Dim name As String
        Dim artist As String
        Dim used As Boolean
    End Structure

    Dim name As String = ""
    Dim randomNum As Integer = 0
    Dim score As Integer = 0

    Sub Main()

        Dim tempPass As String ""
            Dim tempname As String = ""
        Dim name As String = ""
        Dim pass As String = ""
        Dim found As Boolean = False
        Dim slist(9) As songlist


        Console.WriteLine("Please enter your name")
        name = Console.ReadLine()
        Console.WriteLine("Please enter your password")
        pass = Console.ReadLine()

        FileOpen(1, "N:\Y10\Computing\Programming challenges\login.txt", OpenMode.Input)

        Do While found = False And Not EOF(1)
            Input(1, tempname)
            Input(1, tempPass)
            If LCase(name) = LCase(tempPass) And LCase(pass) = LCase(tempPass) Then
                found = True
            End If
        Loop
        FileClose(1)
        Console.Clear(1)

        If found = False Then
            Call signup(name, pass)
        End If

        Console.WriteLine("welcome to the Conyers Song Game")
        Call songs(slist)
        Call game(slist)
        Call play(slist)
        Call Sort()


        'Dim pass As String
        'Dim name As String = ""
        'Dim found As Boolean = False
        'Dim slist(9) As songlist
        'FileOpen(1, "N:\Y10\Computing\Programming challenges\login.txt", OpenMode.Append)
        'Console.Write("Username: ")
        'name = Console.ReadLine()
        'Console.Write("password: ")
        'pass = Console.ReadLine()

        'Do While found = False And Not EOF(1)
        '    Input(1, name)
        '    Input(1, pass)

        '    If found = True Then
        '        Console.WriteLine(“Welcome to the Conyers Quiz!”)
        '    Else
        '        Call signup(name, pass)
        '    End If

        'Loop
        'FileClose(1)
    End Sub
    Sub signup(ByRef name As String, ByRef pass As String)
        FileOpen(1, "N:\Y10\Computing\Programming challenges\login.txt", OpenMode.Append)
        Console.Write("sorry you havent got a login. Please sign up")
        PrintLine(1, Tname & "," & Tpass)
        FileClose(1)
        'Console.Write("Enter Password: ")
    End Sub

    Sub songs(ByRef slist() As songlist)
        Dim file As String
        Dim used As Boolean
        FileOpen(1, "N:\Y10\Computing\Programming challenges\songlist.txt", OpenMode.Input)
        For i = 0 To 9
            Input(1, slist(i).artist)
            Input(1, slist(i).song)
            slist(i).used = False
        Next
        FileClose(1)

        'file = 2
        'used = False
        'Dim x As Integer
        'For x = 0 To 9
        '    songs(x) = file
        'Next
    End Sub
    Sub game(ByRef slist() As songlist)
        Dim ran As New Random
        randomNum = ran.Next(0, 10)
        Dim spacepos As Integer = 0
        Dim falsecheck As Boolean = False
        Dim checkAllUsed As Boolean = True


        For i = 0 To 9
            If slist(i).used = False Then
                checkAllUsed = False
            End If
        Next

        If checkAllUsed = False Then
            Do Until falsecheck = True
                randomNum = ran.Next(0, 10)
                If slist(randomNum).used = False Then
                    falsecheck = True
                    slist(randomNum).used = True
                    Exit Do
                End If
            Loop
        End If

        falsecheck = True Then
            Console.WriteLine(slist(randomNum).artist)
        spacepos = InStr(slist(randomNum).song)" ")

            Console.WriteLine(slist(randomNum).song, 1) & vbtab & mid(slist(randomNum.song, spacepos + 1, 1)
        Else
        Console.WriteLine(Left(slist(randomNum).song, 1)
        End If
    End Sub
End Module
