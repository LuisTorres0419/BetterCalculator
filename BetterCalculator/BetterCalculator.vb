Option Strict On
Option Explicit On
Option Compare Text
'Luis Torres
'RCET0265
'Fall 2020
'Better Calculator
'
Module BetterCalculator

    Sub Main()
        Dim userInput1, userInput2, userRespons As String
        Dim firstNumber, seconNumber As Integer
        Dim betterData As Boolean
        Do
            Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.")

            Do

                Try

                    Console.WriteLine("give me the number.")
                    userInput1 = Console.ReadLine()
                    firstNumber = CInt(userInput1)
                    Console.WriteLine("give secon num")
                    userInput2 = Console.ReadLine()
                    seconNumber = CInt(userInput2)
                    betterData = True
                Catch ex As Exception
                    Console.WriteLine("numbers!!!!! you give me bad numbers!!! ")
                    betterData = False

                    If userInput1 = "Q" Or userInput2 = "Q" Then

                        Exit Sub

                    End If

                End Try
            Loop Until betterData = True
            Console.Clear()

            Do
                Console.WriteLine("1.Add " & vbNewLine &
                    "2.suntract" & vbNewLine &
                    "3.multiply" & vbNewLine &
                    "4.divide" & vbNewLine)

                userRespons = Console.ReadLine()

                If userRespons = "Add" Or userRespons = "+" Then

                    Console.WriteLine("You entered: " & firstNumber & " + " & seconNumber & " that = " &
                                      firstNumber + seconNumber)

                ElseIf userRespons = "Subtract" Or userRespons = "-" Then

                    Console.WriteLine("You entered: " & firstNumber & " - " & seconNumber & " that = " &
                                      firstNumber - seconNumber)

                ElseIf userInput1 = "q" Or userInput2 = "q" Then

                    Exit Sub

                ElseIf userRespons = "multiply" Or userRespons = "*" Then

                    Console.WriteLine("You entered: " & firstNumber & " * " & seconNumber & " that = " &
                                      firstNumber * seconNumber)
                ElseIf userRespons = "Divsion" Or userRespons = "/" Then
                    Console.WriteLine("You entered: " & firstNumber & " / " & seconNumber & " that = " &
                                      firstNumber / seconNumber)
                ElseIf userRespons <> "multiply" Or userRespons <> "*" Or userRespons <> "Add" Or userRespons <>
                    "+" Then
                    Console.WriteLine("Big wrong try again!")
                End If
            Loop Until userRespons = "multiply" Or userRespons = "*" Or userRespons = "Add" Or userRespons = "+" _
                Or userRespons = "Divide" Or userRespons = "/" Or userRespons = "Subtract" Or userRespons = "-"
            Console.ReadLine()
            Console.Clear()
        Loop

    End Sub

End Module
